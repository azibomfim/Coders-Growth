using System.Collections.Generic;

namespace CodersGrowth.Dominio.Models
{
    public class Usuario
    {
        public string NomeDeUsuario { get; set; }
        public int Senha { get; set; }
        public int Id { get; set; }
        public int? AdventureRank { get; set; }
        public List<Personagem> PersonagensDoUsuario { get; set; }
    }
}
