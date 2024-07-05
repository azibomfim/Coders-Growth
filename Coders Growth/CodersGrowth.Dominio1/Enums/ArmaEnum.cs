using System.ComponentModel;

namespace CodersGrowth.Dominio.Enums
{
    public enum ArmaEnum
    {
        Arma,
        [Description("Espada")]
        Espada,
        [Description("Espadão")]
        Espadao,
        [Description("Catalisador")]
        Catalisador,
        [Description("Arco")]
        Arco,
        [Description("Lança")]
        Lanca
    }
}
