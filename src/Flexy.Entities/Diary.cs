using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Entities
{
    public class Diary : BaseEntity
    {
        public IEnumerable<DiaryComment> Comment { get; set; }
    }
}
