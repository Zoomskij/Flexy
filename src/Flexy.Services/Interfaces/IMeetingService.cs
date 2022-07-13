using Flexy.Entities;
using Flexy.Models.Meettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Services.Interfaces
{
    public interface IMeetingService
    {
        IEnumerable<Meeting> Get();
        Task AddAsync(AddMeetingRequest meetingRequest);
        Task UpdateAsync(Meeting meeting);
        Task DeleteAsync(Guid guid);
    }
}
