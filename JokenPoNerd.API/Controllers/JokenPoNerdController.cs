using JokenPoNerd.API.Interfaces;
using JokenPoNerd.API.Notificacoes;
using JokenPoNerd.API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokenPoNerd.API.Controllers
{
    public class JokenPoNerdController : Controller
    {


        private readonly Notificador _notificador;
        private readonly IJokenPoNerdService _jokenPoNerdService;

        public JokenPoNerdController(Notificador notificador, IJokenPoNerdService jokenPoNerdService)
        {
            _notificador = notificador;
            _jokenPoNerdService = jokenPoNerdService;
        }

        [HttpPost]
        [Route("v1/JokenPoNerd")]
        [ProducesResponseType(typeof(ResultViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResultViewModel), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResultViewModel), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ResultViewModel>> JokenPoNerdAsync([FromBody] JokenPoViewModel jokenPo)
        {
            try
            {

                if (jokenPo == null)
                {
                    _notificador.Add("Parametros de entrada inválidos");
                    return BadRequest(new ResultViewModel(_notificador.ObterNotificacoes()));
                }

                bool campos = jokenPo.ValidarCampos();


                if (campos == false)
                {
                    _notificador.Add("Parametros de entrada inválidos");
                    return BadRequest(new ResultViewModel(_notificador.ObterNotificacoes()));
                }

                var result = await _jokenPoNerdService.JokenPoNerdAsync(jokenPo);

                if (result == null)
                    return BadRequest(new ResultViewModel(_notificador.ObterNotificacoes()));

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro interno no servidor: " + ex.Message);
            }
        }
    }
}
