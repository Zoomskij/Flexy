using Flexy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Models.Meettings
{
    public class AddMeetingRequest
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? FinishDate { get; set; } = DateTime.Now;
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public bool IsMetro { get; set; } = false;
        public string? Metro { get; set; }
        public string? Category { get; set; }
        public string? Status { get; set; }
        public string? Img { get; set; }
        public User? Owner { get; set; }
    }
}
