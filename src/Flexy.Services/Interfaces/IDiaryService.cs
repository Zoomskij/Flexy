using Flexy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Services.Interfaces
{
    public interface IDiaryService
    {
        IEnumerable<DiaryComment> Get();
        Task AddAsync(DiaryComment diaryComment);
        Task UpdateAsync(DiaryComment diaryComment);
        Task DeleteAsync(Guid diaryCommentGuid);
    }
}
