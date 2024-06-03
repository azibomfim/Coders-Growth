using CodersGrowth.Dominio.Enums;
using CodersGrowth.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodersGrowth.Testes.Singleton
{
    public sealed class TabelaPersonagem
    {
        private static List<Personagem> InstanciaPersonagem = new();
        private static readonly List<Personagem> Personagens = new List<Personagem>()
        {
            new Personagem()
            {
                Id = 1,
                NomePersonagem = "Xiao",
                Vida = 18778,
                Ataque = 2011,
                Defesa = 873,
                ProficienciaElemental = 131,
                TaxaCrit = 81.6m,
                DanoCrit = 203.9m,
                BonusCura = 0.0m,
                RecargaDeEnergia = 131.1m,
                Escudo = 0.0m,
                BonusElemental = 61.6m,
                Posse = true,
                ImgPersonagem = null,
                ConstelacaoLv = 1,
                DataDeAquisicao = DateTime.Now,
                Elemento = ElementoEnum.Anemo,
                Arma = ArmaEnum.Lanca,
            },
            new Personagem()
            {
                Id = 2,
                NomePersonagem = "Hutao",
                Vida = 32752,
                Ataque = 1458,
                Defesa = 1119,
                ProficienciaElemental = 84,
                TaxaCrit =53.2m,
                DanoCrit = 200.4m,
                BonusCura = 0.0m,
                RecargaDeEnergia = 111.7m,
                Escudo = 0.0m,
                BonusElemental = 61.6m,
                Posse = true,
                ImgPersonagem = null,
                ConstelacaoLv = 0,
                DataDeAquisicao = DateTime.Now,
                Elemento = ElementoEnum.Pyro,
                Arma = ArmaEnum.Lanca,
            },
            new Personagem()
            {
                 Id = 3,
                 NomePersonagem = "Xingqiu",
                 Vida = 14790,
                 Ataque = 1622,
                 Defesa = 815,
                 ProficienciaElemental = 140,
                 TaxaCrit = 55.2m,
                 DanoCrit = 120.7m,
                 BonusCura = 0.0m,
                 RecargaDeEnergia = 191.1m,
                 Escudo = 0.0m,
                 BonusElemental = 66.6m,
                 Posse = false,
                 ImgPersonagem = null,
                 ConstelacaoLv = 0,
                 DataDeAquisicao = null,
                 Elemento = ElementoEnum.Hydro,
                 Arma = ArmaEnum.Espada,
            },
            new Personagem()
            {
                 Id = 4,
                 NomePersonagem = "Rosaria",
                 Vida = 17355,
                 Ataque = 1585,
                 Defesa = 767,
                 ProficienciaElemental = 68,
                 TaxaCrit = 48.9m,
                 DanoCrit = 151.1m,
                 BonusCura = 0.0m,
                 RecargaDeEnergia = 155.5m,
                 Escudo = 0.0m,
                 BonusElemental = 61.6m,
                 Posse = false,
                 ImgPersonagem = null,
                 ConstelacaoLv = 0,
                 DataDeAquisicao = null,
                 Elemento = ElementoEnum.Cryo,
                 Arma = ArmaEnum.Lanca,
            },
            new Personagem()
            {
                 Id = 5,
                 NomePersonagem = "Zhongli",
                 Vida = 21858,
                 Ataque = 1320,
                 Defesa = 791,
                 ProficienciaElemental = 23,
                 TaxaCrit = 77.4m,
                 DanoCrit = 164.3m,
                 BonusCura = 0.0m,
                 RecargaDeEnergia = 100.0m,
                 Escudo = 0.0m,
                 BonusElemental = 83.2m,
                 Posse = true,
                 ImgPersonagem = null,
                 ConstelacaoLv = 6,
                 DataDeAquisicao = DateTime.Now,
                 Elemento = ElementoEnum.Geo,
                 Arma = ArmaEnum.l,
            }
        };

        private TabelaPersonagem() { }
        public static List<Personagem> Instancia
        {
            get
            {
                if (InstanciaPersonagem == null)
                {
                    InstanciaPersonagem = Personagens;
                }

                return InstanciaPersonagem;
            }
        }
    }
}
