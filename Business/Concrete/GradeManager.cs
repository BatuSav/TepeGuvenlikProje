using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GradeManager : IGradeService
    {
        IGradeDal _gradeDal;

        public GradeManager(IGradeDal gradeDal)
        {
            _gradeDal = gradeDal;
        }
        //[SecuredOperation("admin,teacher")]
        public IResult Add(Grade grade)
        {
            _gradeDal.Add(grade);
            return new SuccessResult();
        }

        public IDataResult<List<Grade>> GetAll()
        {
            return new SuccessDataResult<List<Grade>>(_gradeDal.GetAll());
        }
    }
}
