using JokenPoNerd.API.Enums;
using JokenPoNerd.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokenPoNerd.API.Factory
{
    public static class GanhadorFactory
    {

        public static JokenPoAbstract CriarClasseCorreta(ETipo jogador1, ETipo jogador2)
        {

            switch (jogador1)
            {
                case ETipo.Lagarto:

                    return new Lagarto(jogador2);

                case ETipo.Papel:

                    return new Papel(jogador2);

                case ETipo.Pedra:

                    return new Pedra(jogador2);

                case ETipo.Spock:

                    return new Spock(jogador2);

                case ETipo.Tesoura:
                    return new Tesoura(jogador2);

                default:
                    return null;
            }

        }
    }
}
