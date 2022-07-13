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
    public class GoalService : IGoalService
    {
        private readonly IGoalRepository _goalRepository;
        public GoalService(IGoalRepository goalRepository)
        {
            _goalRepository = goalRepository;
        }

        public IEnumerable<Goal> Get()
        {
            return _goalRepository.Get();
        }
        public async Task AddAsync(Goal goal)
        {
            await _goalRepository.AddAsync(goal);
        }
        public async Task UpdateAsync(Goal goal)
        {
            await _goalRepository.UpdateAsync(goal);
        }
        public async Task DeleteAsync(Guid goalGuid)
        {
            await _goalRepository.DeleteAsync(goalGuid);
        }
    }
}
