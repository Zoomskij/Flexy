using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Entities
{
    public class Scenario : BaseEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Guid? ParrentGuid { get; set; } = null;
        public string? Command { get; set; }
        public string? Text { get; set; }
        public byte? Type { get; set; }
        
    }
}
