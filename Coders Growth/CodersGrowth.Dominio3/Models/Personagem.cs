using CodersGrowth.Dominio.Enums;
using System;

namespace CodersGrowth.Dominio.Models
{
    public class Personagem
    {
        public int Id { get; set; }
<<<<<<< HEAD:Coders Growth/CodersGrowth.Dominio3/Models/Personagem.cs
        public string NomePersonagem { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }
        public int ProficienciaElemental { get; set; }
        public decimal TaxaCrit { get; set; }
        public decimal DanoCrit { get; set; }
        public decimal BonusCura { get; set; }
        public decimal RecargaDeEnergia { get; set; }
        public decimal Escudo { get; set; }
        public decimal BonusElemental { get; set; }
        public bool CriadoPorUsuario { get; set; }
        public byte[] ImgPersonagem { get; set; }
        public int ConstelacaoLv { get; set; }
        public DateTime DataDeAquisicao { get; set; }
        public ElementoEnum Elemento { get; set; }
        public ArmaEnum Arma { get; set; }
        public int IdUsuario { get; set; }
=======
        public string? NomePersonagem { get; set; }
        public int? Vida { get; set; }
        public int? Ataque { get; set; }
        public int? Defesa { get; set; }
        public int? ProficienciaElemental { get; set; }
        public decimal? TaxaCrit { get; set; }
        public decimal? DanoCrit { get; set; }
        public decimal? BonusCura { get; set; }
        public decimal? RecargaDeEnergia { get; set; }
        public decimal? Escudo { get; set; }
        public decimal? BonusElemental { get; set; }
        public bool CriadoPorUsuario { get; set; }
        public byte[]? ImgPersonagem { get; set; }
        public int? ConstelacaoLv { get; set; }
        public DateTime? DataDeAquisicao { get; set; }
        public ElementoEnum? Elemento { get; set; }
        public ArmaEnum? Arma { get; set; }
        public int? IdUsuario { get; set; }
>>>>>>> 8c6a9040d8b90c3deb152a27cbdf5640e20182b6:Coders Growth/CodersGrowth.Dominio/Models/Personagem.cs
    }
}
