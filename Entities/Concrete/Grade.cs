using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Grade : IEntity
    {
        public int Id { get; set; }
        public int StudentsLessonsId { get; set; }
        public int GradePoint { get; set; }
    }
}
