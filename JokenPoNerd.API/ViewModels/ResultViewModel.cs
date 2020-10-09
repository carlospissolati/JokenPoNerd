using JokenPoNerd.API.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokenPoNerd.API.ViewModels
{
    public class ResultViewModel
    {
        public ResultViewModel(object data)
        {
            Success = true;
            Data = data;
        }

        public ResultViewModel(List<Notificacao> notificacaos)
        {
            Success = false;
            ErroList = notificacaos;
        }

        public bool Success { get; set; }
        public object Data { get; set; }
        public List<Notificacao> ErroList { get; set; }
    }
}
