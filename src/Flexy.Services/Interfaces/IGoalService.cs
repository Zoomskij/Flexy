﻿using Flexy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexy.Services.Interfaces
{
    public interface IGoalService
    {
        IEnumerable<Goal> Get();
        Task AddAsync(string text);
        Task UpdateAsync(Goal goal);
        Task DeleteAsync(Guid goalGuid);
    }
}
