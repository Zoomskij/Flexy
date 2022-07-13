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
    public class MeetingRepository : IMeetingRepository
    {
        private readonly FlexyContext _context;
        private readonly DbSet<Meeting> _dbSet;
        public MeetingRepository(FlexyContext context)
        {
            _context = context;
            _dbSet = context.Set<Meeting>();
        }

        public IEnumerable<Meeting> Get()
        {
            var data = _dbSet.AsNoTracking();
            return data;
        }

        public async Task AddAsync(Meeting meeting)
        {
            await _dbSet.AddAsync(meeting);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Meeting meeting)
        {
            var currentMeeting = await _dbSet.FirstOrDefaultAsync(x => x.Guid == meeting.Guid);
            if (currentMeeting != null)
            {
                currentMeeting.Name = meeting.Name;
                _context.Entry(currentMeeting).CurrentValues.SetValues(currentMeeting);
            }

            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid guid)
        {
            var currentMeeting = await _dbSet.FirstOrDefaultAsync(x => x.Guid == guid);
            if (currentMeeting != null)
            {
                 _dbSet.Remove(currentMeeting);
                await _context.SaveChangesAsync();
            }

        }
    }
}
