using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Models
{
    public class TreeScenario
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Guid? ParrentGuid { get; set; } = null;
        public string Command { get; set; }
        public string Label { get; set; }
        public IEnumerable<TreeScenario> Children { get; set; }
    }
}
