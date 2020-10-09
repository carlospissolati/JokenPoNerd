using JokenPoNerd.API.Enums;

namespace JokenPoNerd.API.Models
{
    public abstract class JokenPoAbstract 
    {

        protected ETipo Jogador2 { get; set; }
        public abstract string VerificarGanhador();

    }
}
