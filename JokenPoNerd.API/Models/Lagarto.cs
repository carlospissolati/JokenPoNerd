using JokenPoNerd.API.Enums;

namespace JokenPoNerd.API.Models
{
    public class Lagarto : JokenPoAbstract 
    {

        public Lagarto(ETipo jogador2)
        {
            this.Jogador2 = jogador2;
        }
        public override string VerificarGanhador()
        {
            if (this.Jogador2 == ETipo.Spock || this.Jogador2 == ETipo.Papel)
                return "Jogador 1 ganhou";

            else if (this.Jogador2 == ETipo.Lagarto)
                return "Empate";

            return "Jogador 2 ganhou";
        }

    }
}
