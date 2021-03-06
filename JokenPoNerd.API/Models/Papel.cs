﻿using JokenPoNerd.API.Enums;

namespace JokenPoNerd.API.Models
{
    public class Papel : JokenPoAbstract
    {
        public Papel(ETipo jogador2)
        {
            this.Jogador2 = jogador2;
        }

        public override string VerificarGanhador()
        {
            if (this.Jogador2 == ETipo.Pedra || this.Jogador2 == ETipo.Spock)
                return "Jogador 1 ganhou";

            else if (this.Jogador2 == ETipo.Papel)
                return "Empate";

            return "Jogador 2 ganhou";
        }
    }
}
