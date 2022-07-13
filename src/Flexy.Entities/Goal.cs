using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Entities
{
    public class Goal : BaseEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Text { get; set; }
        public string? Img { get; set; }
        /// <summary>
        /// 0 - Цель. 1 - Мечта. 2 - Идея.
        /// </summary>
        public int Status { get; set; } = 0;
        public User? Owner { get; set; }
    }
}
