using Flexy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Services.Interfaces
{
    public interface IAchievmentService
    {
        IEnumerable<Achievment> GetAchievments();
        Task AddAsync(Achievment achievment);
        Task UpdateAsync(Achievment achievment);
        Task DeleteAsync(Guid guid);
    }
}
