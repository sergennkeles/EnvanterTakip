using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PersonalManager : IPersonalService
    {
        IPersonalDal _personalDal;
        public PersonalManager(IPersonalDal personalDal)
        {
            _personalDal = personalDal;
        }
        public IResult Add(Personal personal)
        {
            _personalDal.Add(personal);
            return new SuccessResult(Messages.Added);

        }

        public IResult Delete(Personal personal)
        {
            _personalDal.Delete(personal);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Personal>> GetAll()
        {
          return new SuccessDataResult<List<Personal>>(_personalDal.GetAll(),Messages.Listed);
        }

        public IResult Update(Personal personal)
        {
            _personalDal.Update(personal);
            return new SuccessResult(Messages.Updated);
        }
    }
}
