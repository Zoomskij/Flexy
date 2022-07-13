using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Entities
{
    public class Meeting : BaseEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public bool IsMetro { get; set; } = false;
        public string? Metro { get; set; }
        public string? Category { get; set; }
        public string? Status { get; set; }
        public User Owner { get; set; }
        public IEnumerable<User>? Users { get; set; }

    }
}
