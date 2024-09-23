using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodersGrowth.Dominio.Enums
{
    public class BaseParaEnum<TEnum>
    {
        public TEnum Key { get; set; }
        public string Descricao { get; set; }
    }
}
