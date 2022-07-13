using AutoMapper;
using Flexy.Entities;
using Flexy.Models.Meettings;
using Flexy.Repositories.Interfaces;
using Flexy.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Services
{
    public class MeetingService : IMeetingService
    {
        private readonly IMeetingRepository _meetingRepository;
        private readonly IMapper _mapper;
        public MeetingService(IMeetingRepository meetingRepository, IMapper mapper)
        {
            _meetingRepository = meetingRepository;
            _mapper = mapper;
        }

        public IEnumerable<Meeting> Get()
        {
            return _meetingRepository.Get();
        }
        public async Task AddAsync(AddMeetingRequest meetingRequest)
        {
            var meeting = _mapper.Map<Meeting>(meetingRequest);
            meeting.StartDate = DateTime.Now;
            await _meetingRepository.AddAsync(meeting);
        }
        public async Task UpdateAsync(Meeting meeting)
        {
            await _meetingRepository.UpdateAsync(meeting);
        }
        public async Task DeleteAsync(Guid guid)
        {
            await _meetingRepository.DeleteAsync(guid);
        }
    }
}
