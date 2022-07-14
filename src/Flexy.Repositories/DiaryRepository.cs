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
    public class DiaryRepository : IDiaryRepository
    {
        private readonly FlexyContext _context;
        private readonly DbSet<DiaryComment> _dbSet;
        public DiaryRepository(FlexyContext context)
        {
            _context = context;
            _dbSet = context.Set<DiaryComment>();
        }

        public IEnumerable<DiaryComment> Get()
        {
            var data = _dbSet.OrderByDescending(x => x.CreatedDate).Include(x => x.User).AsNoTracking();
            return data;
        }

        public async Task AddAsync(DiaryComment diaryComment)
        {
            await _dbSet.AddAsync(diaryComment);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(DiaryComment diaryComment)
        {
            var currentDiaryComment = await _dbSet.FirstOrDefaultAsync(x => x.Guid == diaryComment.Guid);
            if (currentDiaryComment != null)
            {
                currentDiaryComment.Text = diaryComment.Text;
                _context.Entry(currentDiaryComment).CurrentValues.SetValues(currentDiaryComment);
            }

            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid diaryCommentGuid)
        {
            var currentDiaryComment = await _dbSet.FirstOrDefaultAsync(x => x.Guid == diaryCommentGuid);
            if (currentDiaryComment != null)
            {
                 _dbSet.Remove(currentDiaryComment);
                await _context.SaveChangesAsync();
            }

        }
    }
}
