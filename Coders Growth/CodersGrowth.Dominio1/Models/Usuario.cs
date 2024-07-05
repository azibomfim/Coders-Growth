using LinqToDB.Mapping;

namespace CodersGrowth.Dominio.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("NomeDeUsuario")]
        public string NomeDeUsuario { get; set; }
        [Column("Senha")]
        public int Senha { get; set; }
        [PrimaryKey, Identity]
        public int Id { get; set; }
        [Column("AdventureRank")]
        public int? AdventureRank { get; set; }
    }
}
