using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Entities
{
    public class UserCharacter : BaseEntity
    {
        public User? User { get; set; }
        public Character? Character { get; set; }
        public int Value { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
