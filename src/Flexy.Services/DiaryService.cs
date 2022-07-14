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
    public class DiaryService : IDiaryService
    {
        private readonly IDiaryRepository _diaryRepository;
        public DiaryService(IDiaryRepository diaryRepository)
        {
            _diaryRepository = diaryRepository;
        }

        public IEnumerable<DiaryComment> Get()
        {
            return _diaryRepository.Get();
        }
        public async Task AddAsync(DiaryComment diaryComment)
        {
            await _diaryRepository.AddAsync(diaryComment);
        }
        public async Task UpdateAsync(DiaryComment diaryComment)
        {
            await _diaryRepository.UpdateAsync(diaryComment);
        }
        public async Task DeleteAsync(Guid diaryCommentGuid)
        {
            await _diaryRepository.DeleteAsync(diaryCommentGuid);
        }
    }
}
