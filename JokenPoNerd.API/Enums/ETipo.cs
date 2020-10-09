using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace JokenPoNerd.API.Enums
{
    public enum ETipo
    {
        [Description("Pedra")]
        Pedra = 1,

        [Description("Lagarto")]
        Lagarto = 2,

        [Description("Spock")]
        Spock = 3,

        [Description("Tesoura")]
        Tesoura = 4,

        [Description("Papel")]
        Papel = 5,
    }

}
