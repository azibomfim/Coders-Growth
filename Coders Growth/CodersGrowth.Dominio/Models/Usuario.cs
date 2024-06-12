using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodersGrowth.Dominio.Models
{
    public class Usuario
    {
        public string? NomeDeUsuario {  get; set; }
        public int? Senha { get; set; }
        public int Uid { get; set; }
        public int? AdventureRank { get; set; }
    }
}
