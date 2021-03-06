using Microsoft.EntityFrameworkCore;
using Flexy.Data;
using Flexy.Entities;
using Flexy.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Repositories
{
    public class GoalRepository : IGoalRepository
    {
        private readonly FlexyContext _context;
        private readonly DbSet<Goal> _dbSet;
        public GoalRepository(FlexyContext context)
        {
            _context = context;
            _dbSet = context.Set<Goal>();
        }

        public IEnumerable<Goal> Get()
        {
            var data = _dbSet.AsNoTracking();
            return data;
        }

        public async Task AddAsync(Goal goal)
        {
            await _dbSet.AddAsync(goal);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Goal goal)
        {
            var currentGoal = await _dbSet.FirstOrDefaultAsync(x => x.Guid == goal.Guid);
            if (currentGoal != null)
            {
                currentGoal.Text = goal.Text;
                _context.Entry(currentGoal).CurrentValues.SetValues(currentGoal);
            }

            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid goalGuid)
        {
            var currentGoal = await _dbSet.FirstOrDefaultAsync(x => x.Guid == goalGuid);
            if (currentGoal != null)
            {
                 _dbSet.Remove(currentGoal);
                await _context.SaveChangesAsync();
            }

        }
    }
}
