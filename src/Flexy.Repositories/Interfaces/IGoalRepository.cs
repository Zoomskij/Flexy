using Flexy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Repositories.Interfaces
{
    public interface IGoalRepository
    {
        IEnumerable<Goal> Get();
        Task AddAsync(Goal goal);
        Task UpdateAsync(Goal goal);
        Task DeleteAsync(Guid goalGuid);
    }
}
