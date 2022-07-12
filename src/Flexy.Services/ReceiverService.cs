using Flexy.Entities;
using Flexy.Repositories;
using Flexy.Repositories.Interfaces;
using Flexy.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Services
{
    public class ReceiverService : IReceiverService
    {
        private readonly IUpdateRepository _updateRepository;
        public ReceiverService(IUpdateRepository updateRepository)
        {
            _updateRepository = updateRepository;
        }

        public IEnumerable<Person> GetTeachers()
        {
            var persons = _updateRepository.GetTeachers();
            return persons.ToList();
        }

        public async Task AddOrUpdateUserPersonId(StudentPersonIds userPersonIds)
        {
            await _updateRepository.AddOrUpdateUserPersonId(userPersonIds);
        }

        public async Task<Person> GetPersonByStudentGuid(Guid studentGuid)
        {
            return await _updateRepository.GetPersonByStudentGuid(studentGuid);
        }

        public IEnumerable<string> GetPhrases()
        {
            return _updateRepository.GetPhrases().ToList();
        }

        public IEnumerable<string> GetPhrasesByStudentGuid(Guid studentGuid)
        {
            return _updateRepository.GetPhrasesByStudentGuid(studentGuid).ToList();
        }

        public async Task AddPhrase(int teacherId, string phrase)
        {
            await _updateRepository.AddPhrase(teacherId, phrase);
        }
    }
}
