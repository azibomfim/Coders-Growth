using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodersGrowth.Dominio.Models
{
    public class Usuario
    {
        public string userName {  get; set; }
        public int password { get; set; }
        public int uid { get; set; }
        public int adventureRank { get; set; }
    }
}
