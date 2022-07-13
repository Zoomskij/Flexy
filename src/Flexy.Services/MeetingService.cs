using Flexy.Entities;
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
        public MeetingService(IMeetingRepository meetingRepository)
        {
            _meetingRepository = meetingRepository;
        }

        public IEnumerable<Meeting> Get()
        {
            return _meetingRepository.Get();
        }
        public async Task AddAsync(string text)
        {
            var meeting = new Meeting
            {
                Name = text,
            };
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
