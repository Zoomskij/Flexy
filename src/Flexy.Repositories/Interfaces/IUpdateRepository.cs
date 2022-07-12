using Flexy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Repositories.Interfaces
{
    public interface IUpdateRepository
    {
        IQueryable<Person> GetTeachers();

        Task AddOrUpdateUserPersonId(StudentPersonIds userPersonIds);

        Task<Person> GetPersonByStudentGuid(Guid studentGuid);

        IEnumerable<string> GetPhrases();

        IQueryable<string> GetPhrasesByStudentGuid(Guid studentGuid);

        Task AddPhrase(int teacherId, string phrase);

    }
}
