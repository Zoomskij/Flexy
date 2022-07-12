using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Entities
{
    public class StudentLessonId : BaseEntity
    {
        public Guid StudentGuid { get; set; }
        public Guid LessonGuid { get; set; }
        public bool IsComplete { get; set; } = false;
        public IEnumerable<StudentTaskId> StudentTaskIds { get; set; }
    }
}
