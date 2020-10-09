using JokenPoNerd.API.Enums;

namespace JokenPoNerd.API.Models
{
    public class Tesoura : JokenPoAbstract 
    {
        public Tesoura(ETipo jogador2)
        {
            this.Jogador2 = jogador2;
        }


        public override string VerificarGanhador()
        {
            if (this.Jogador2 == ETipo.Lagarto || this.Jogador2 == ETipo.Papel)
                return "Jogador 1 ganhou";

            else if (this.Jogador2 == ETipo.Tesoura)
                return "Empate";

            return "Jogador 2 ganhou";


        }
    }
}
