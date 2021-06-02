using Core;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfGradeDal : EfEntityRepositoryBase<Grade,TepeGuvenlikProjeContext>,IGradeDal
    {
    }
}
