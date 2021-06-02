using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStudentService
    {
        IResult Add(Student student);
        IDataResult<List<Student>> GetAll();
        IDataResult<Student> GetByStudentNumber(string studentNumber);
    }
}
