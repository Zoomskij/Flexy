using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Entities
{
    public class StudentCourseId : BaseEntity
    {
        public Guid StudentGuid { get; set; }
        public Guid CourseGuid { get; set; }
        public IEnumerable<StudentLessonId> StudentLessonIds { get; set; }
    }
}
