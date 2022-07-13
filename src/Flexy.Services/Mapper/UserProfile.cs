using AutoMapper;
using Flexy.Entities;
using Flexy.Models;
using Flexy.Models.Meettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Services.Mapper
{
    public class MeetingProfile : Profile
    {
        public MeetingProfile()
        {
            CreateMap<AddMeetingRequest, Meeting>();
        }
    }
}
