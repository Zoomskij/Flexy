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
    public class AchievmentService : IAchievmentService
    {
        private readonly IAchievmentRepository _achievmentRepository;
        public AchievmentService(IAchievmentRepository achievmentRepository)
        {
            _achievmentRepository = achievmentRepository;
        }

        public IEnumerable<Achievment> GetAchievments()
        {
            return _achievmentRepository.GetAchievments();
        }

        public async Task AddAsync(Achievment achievment)
        {
            await _achievmentRepository.AddAsync(achievment);
        }
        public async Task UpdateAsync(Achievment achievment)
        {
            await _achievmentRepository.UpdateAsync(achievment);
        }
        public async Task DeleteAsync(Guid guid)
        {
            await _achievmentRepository.DeleteAsync(guid);
        }
    }
}
