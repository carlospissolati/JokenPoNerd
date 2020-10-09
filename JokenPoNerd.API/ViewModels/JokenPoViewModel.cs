using JokenPoNerd.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace JokenPoNerd.API.ViewModels
{
    public class JokenPoViewModel
    {
        public ETipo Jogador1 { get; set; }
        public ETipo Jogador2 { get; set; }


        public bool ValidarCampos()
        {

            if (!Enum.IsDefined(typeof(ETipo), Jogador1))
                return false;

            if (!Enum.IsDefined(typeof(ETipo), Jogador2))
                return false;

            return true;
        }
    }
}
