using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDebitDal : EfEntityRepositoryBase<Debit, StockContext>, IDebitDal
    {
        public List<DebitDetailDto> GetAllDebitDetails()
        {
            using (StockContext context = new StockContext())
            {
                var result = from debit in context.Debits
                             join person in context.Personals
                             on debit.PersonalId equals person.Id
                             join product in context.Products on
                             debit.ProductId equals product.Id
                             orderby (debit.Id)
                             select new DebitDetailDto
                             {
                                 Id = debit.Id,
                                 BrandName = product.BrandName,
                                 Model = product.Model,
                                 FirstName = person.FirstName,
                                 LastName = person.LastName,
                                 Title = person.Title,
                                 Department = person.Department,
                                 Status = debit.Status,
                                 ProcessType = debit.ProcessType,
                                 ProcessDate = debit.ProcessDate,
                                 Description = debit.Description

                             };
                       return result.ToList();   
            }
        }
    }
}
