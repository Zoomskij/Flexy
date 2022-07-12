using Flexy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Services.Interfaces
{
    public interface IReceiverService
    {
        IEnumerable<Person> GetTeachers();

        Task AddOrUpdateUserPersonId(StudentPersonIds userPersonIds);

        Task<Person> GetPersonByStudentGuid(Guid studentGuid);

        IEnumerable<string> GetPhrases();

        IEnumerable<string> GetPhrasesByStudentGuid(Guid studentGuid);

        Task AddPhrase(int teacherId, string phrase);

    }
}
