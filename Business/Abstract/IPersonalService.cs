using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IPersonalService
    {
       IDataResult<List<Personal>> GetAll();

        IResult Add(Personal personal);

        IResult Update(Personal personal);

        IResult Delete(Personal personal);
    }
}
