using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Entities
{
    public class DiaryComment : BaseEntity
    {
        public User? User { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? Text { get; set; }
        public string? Img { get; set; }
        public IEnumerable<DiaryComment>? Answers { get; set; }
        
    }
}
