
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace JokenPoNerd.API.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
