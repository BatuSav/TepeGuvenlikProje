using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGradeService
    {
        void Add(Grade grade);
        List<Grade> GetAll();
    }
}
