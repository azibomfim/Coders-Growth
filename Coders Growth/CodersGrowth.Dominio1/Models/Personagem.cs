using CodersGrowth.Dominio.Enums;
using System;
using LinqToDB.Mapping;

namespace CodersGrowth.Dominio.Models
{
    [Table("Personagem")]
    public class Personagem
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }
        [Column("NomePersonagem")]
        public NomeEnum? NomePersonagem { get; set; }
        [Column("Vida")]
        public int Vida { get; set; }
        [Column("Ataque")]
        public int Ataque { get; set; }
        [Column("Defesa")]
        public int Defesa { get; set; }
        [Column("ProficienciaElemental")]
        public int ProficienciaElemental { get; set; }
        [Column("TaxaCrit")]
        public decimal TaxaCrit { get; set; }
        [Column("DanoCrit")]
        public decimal DanoCrit { get; set; }
        [Column("BonusCura")]
        public decimal BonusCura { get; set; }
        [Column("RecargaDeEnergia")]
        public decimal RecargaDeEnergia { get; set; }
        [Column("Escudo")]
        public decimal Escudo { get; set; }
        [Column("BonusElemental")]
        public decimal BonusElemental { get; set; }
        [Column("CriadoPorUsuario")]
        public bool? CriadoPorUsuario { get; set; }
        [Column("ConstelacaoLv")]
        public int ConstelacaoLv { get; set; }
        [Column("DataDeAquisicao")]
        public DateTime? DataDeAquisicao { get; set; }
        [Column("Elemento")]
        public ElementoEnum? Elemento { get; set; }
        [Column("Arma")]
        public ArmaEnum? Arma { get; set; }
        [Column("IdUsuario")]
        public int? IdUsuario { get; set; }
    }
}
