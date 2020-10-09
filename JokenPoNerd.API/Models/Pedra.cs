using JokenPoNerd.API.Enums;

namespace JokenPoNerd.API.Models
{
    public class Pedra : JokenPoAbstract
    {
        public Pedra(ETipo jogador2)
        {
            this.Jogador2 = jogador2;
        }

        public override string VerificarGanhador()
        {
            if (this.Jogador2 == ETipo.Lagarto || this.Jogador2 == ETipo.Tesoura)
                return "Jogador 1 ganhou";

            else if (this.Jogador2 == ETipo.Pedra)
                return "Empate";
                    
            return "Jogador 2 ganhou";
        }
    }
}
