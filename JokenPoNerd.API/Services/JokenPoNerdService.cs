using JokenPoNerd.API.Factory;
using JokenPoNerd.API.Interfaces;
using JokenPoNerd.API.Models;
using JokenPoNerd.API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokenPoNerd.API.Services
{
    public class JokenPoNerdService  : IJokenPoNerdService
    {

        public async Task<ResultViewModel> JokenPoNerdAsync(JokenPoViewModel jokenPoViewModel)
        {

            var jokenPo = GanhadorFactory.CriarClasseCorreta(jokenPoViewModel.Jogador1, jokenPoViewModel.Jogador2);

            string resultadoGanhador = jokenPo.VerificarGanhador();

            ResultViewModel result = new ResultViewModel(resultadoGanhador);

            return result;
        }
    }
}
