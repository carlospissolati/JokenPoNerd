using JokenPoNerd.API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokenPoNerd.API.Interfaces
{
    public interface IJokenPoNerdService
    {
        Task<ResultViewModel> JokenPoNerdAsync(JokenPoViewModel jokenPo);
    }
}
