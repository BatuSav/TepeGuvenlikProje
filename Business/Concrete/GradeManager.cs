using Business.Abstract;
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

        public void Add(Grade grade)
        {
            throw new NotImplementedException();
        }

        public List<Grade> GetAll()
        {
            return _gradeDal.GetAll();
        }
    }
}
