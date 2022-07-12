using AutoMapper;
using Flexy.Entities;
using Flexy.Models;
using Flexy.Repositories.Interfaces;
using Flexy.Services.Helpers;
using Flexy.Services.Interfaces;
using Flexy.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Services
{
    public class ScenarioService : IScenarioService
    {
        private readonly IScenarioRepository _scenarioRepository;
        public readonly IMapper _mapper;
        public ScenarioService(IScenarioRepository scenarioRepository, IMapper mapper)
        {
            _scenarioRepository = scenarioRepository;
            _mapper = mapper;
        }

        public IEnumerable<Scenario> Get()
        {
            return _scenarioRepository.Get();
        }

        public IEnumerable<ScenarioDto> GetTree()
        {
            var scenarios = _scenarioRepository.Get().ToList();
            var dto = _mapper.Map<List<ScenarioDto>>(scenarios);
            var tree = dto.GenerateScenarioTree(c => c.Guid, c => c.ParrentGuid);
            return tree;
        }
        public async Task AddAsync(string text, string? command, byte? type, Guid parrentGuid)
        {
            var scenario = new Scenario
            {
                ParrentGuid = !string.IsNullOrWhiteSpace(command) ? null : parrentGuid,
                Text = text,
                Command = command,
                Type = type,
            };
            await _scenarioRepository.AddAsync(scenario);
        }
        public async Task UpdateAsync(Scenario scenario)
        {
            await _scenarioRepository.UpdateAsync(scenario);
        }
        public async Task DeleteAsync(Guid guid)
        {
            await _scenarioRepository.DeleteAsync(guid);
        }
    }
}
