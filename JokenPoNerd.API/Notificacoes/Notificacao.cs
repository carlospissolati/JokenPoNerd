using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokenPoNerd.API.Notificacoes
{
    public class Notificacao
    {

        public Notificacao(string mensagem)
        {
            Mensagem = mensagem;
        }

        public string Mensagem { get; private set; }
    }
}
