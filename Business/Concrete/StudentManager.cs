using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public IResult Add(Student student)
        {
            _studentDal.Add(student);
            return new SuccessResult(Messages.StudentAdded);
        }
        [SecuredOperation("admin,teacher")]
        public IDataResult<List<Student>> GetAll()
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll(),Messages.StudentsListed);
        }

        public IDataResult<Student> GetByStudentNumber(string studentNumber)
        {
            return new SuccessDataResult<Student>(_studentDal.Get(x => x.StudentNumber == studentNumber));
        }
    }
}
