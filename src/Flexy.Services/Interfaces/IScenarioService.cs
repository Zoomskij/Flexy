using Flexy.Entities;
using Flexy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Services.Interfaces
{
    public interface IScenarioService
    {
        IEnumerable<Scenario> Get();
        IEnumerable<ScenarioDto> GetTree();
        Task AddAsync(string text, string? command, byte? type, Guid parrentGuid);
        Task UpdateAsync(Scenario scenario);
        Task DeleteAsync(Guid guid);
    }
}
