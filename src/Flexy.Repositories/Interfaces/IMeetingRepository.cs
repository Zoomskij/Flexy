using Flexy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Repositories.Interfaces
{
    public interface IMeetingRepository
    {
        IEnumerable<Meeting> Get();
        Task AddAsync(Meeting meeting);
        Task UpdateAsync(Meeting meeting);
        Task DeleteAsync(Guid guid);
    }
}
