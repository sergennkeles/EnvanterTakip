using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DebitManager : IDebitService
    {
        IDebitDal _debitDal;
        public DebitManager(IDebitDal debitDal)
        {
            _debitDal = debitDal;
        }
        public IResult Add(Debit debit)
        {
            _debitDal.Add(debit);
            return new SuccessResult(Messages.Added);

        }

        public IResult Delete(Debit debit)
        {
            _debitDal.Delete(debit);
            return new SuccessResult(Messages.Deleted);

        }

        public IDataResult<List<Debit>> GetAll()
        {
            return new SuccessDataResult<List<Debit>>(_debitDal.GetAll(),Messages.Listed);
        }

        public IDataResult<List<DebitDetailDto>> GetAllDebitDetails()
        {
            return new SuccessDataResult<List<DebitDetailDto>>(_debitDal.GetAllDebitDetails(), Messages.Listed);
        }

        public IResult Update(Debit debit)
        {
            _debitDal.Update(debit);
            return new SuccessResult(Messages.Updated);
        }
    }
}
