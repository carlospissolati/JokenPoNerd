using JokenPoNerd.API.Enums;

namespace JokenPoNerd.API.Models
{
    public class Spock : JokenPoAbstract 
    {
        public Spock(ETipo jogador2)
        {
            this.Jogador2 = jogador2;
        }

        public override string VerificarGanhador()
        {
            if (this.Jogador2 == ETipo.Tesoura || this.Jogador2 == ETipo.Pedra)
                return "Jogador 1 ganhou";

            else if (this.Jogador2 == ETipo.Spock)
                return "Empate";

            return "Jogador 2 ganhou";
        }
    }
}
