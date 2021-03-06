using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Models
{
    public class ScenarioDto
    {
        public Guid Guid { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Guid? ParrentGuid { get; set; } = null;
        public string Text { get; set; }
        public string Command { get; set; }
        public byte? Type { get; set; }
        public string Label { get; set; }
        public ScenarioDto Item { get; set; }
        public IEnumerable<ScenarioDto> Children { get; set; }
    }
}
