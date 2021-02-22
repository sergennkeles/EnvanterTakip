using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDebitService
    {
        IDataResult<List<Debit>> GetAll();

        IDataResult<List<DebitDetailDto>> GetAllDebitDetails();

        IResult  Add(Debit debit);

        IResult Update(Debit debit);

        IResult Delete(Debit debit);
    }
}
