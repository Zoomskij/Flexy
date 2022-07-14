using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Entities
{
    public class DiaryCommentLikes : BaseEntity
    {
        public User? User { get; set; }
        public DiaryComment DiaryComment { get; set; }
        public int? Reaction { get; set; }

    }
}
