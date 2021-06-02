using Core;
using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    public interface ILessonDal:IEntityRepository<Lesson>
    {
    }
}
