using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class StudentLesson : IEntity
    {
        public int Id { get; set; }
        public int StudentsId { get; set; }
        public int LessonsId { get; set; }
    }
}
