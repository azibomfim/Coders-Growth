using CodersGrowth.Dominio.Enums;
using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Testes.Singleton
{
    public sealed class TabelaSingletonPersonagem
    {
        public static List<Personagem> InstanciaPersonagem = new();
        public static readonly List<Personagem> Personagens = new List<Personagem>()
        {
            new Personagem()
            {
                Id = 1,
                NomePersonagem = NomeEnum.Xiao,
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
                CriadoPorUsuario = true,
                ConstelacaoLv = 1,
                DataDeAquisicao = new DateTime(2021, 02, 17),
                Elemento = ElementoEnum.Anemo,
                Arma = ArmaEnum.Lanca,
                IdUsuario = 5,
                NomeUsuario = "abelhinha triste"
            },

            new Personagem()
            {
                Id = 2,
                NomePersonagem = NomeEnum.HuTao,
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
                CriadoPorUsuario = true,
                ConstelacaoLv = 0,
                DataDeAquisicao = DateTime.Now,
                Elemento = ElementoEnum.Pyro,
                Arma = ArmaEnum.Lanca,
                IdUsuario = 2,
                NomeUsuario = "furao insecs"
            },

            new Personagem()
            {
                 Id = 3,
                 NomePersonagem = NomeEnum.Xingqiu,
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
                 CriadoPorUsuario = false,
                 ConstelacaoLv = 0,
                 DataDeAquisicao = new DateTime(2020, 12, 20),
                 Elemento = ElementoEnum.Hydro,
                 Arma = ArmaEnum.Espada,
                 IdUsuario = null,
                 NomeUsuario = null
            },

            new Personagem()
            {
                 Id = 4,
                 NomePersonagem = NomeEnum.Rosaria,
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
                 CriadoPorUsuario = false,
                 ConstelacaoLv = 0,
                 DataDeAquisicao = DateTime.Now,
                 Elemento = ElementoEnum.Cryo,
                 Arma = ArmaEnum.Lanca,
                 IdUsuario = null,
                 NomeUsuario = null
            },

            new Personagem()
            {
                 Id = 5,
                 NomePersonagem = NomeEnum.Zhongli,
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
                 CriadoPorUsuario = true,
                 ConstelacaoLv = 6,
                 DataDeAquisicao = DateTime.Now,
                 Elemento = ElementoEnum.Geo,
                 Arma = ArmaEnum.Lanca,
                 IdUsuario = 4,
                 NomeUsuario = "toninha bipede"
            }
        };

        private TabelaSingletonPersonagem() { }
        public static List<Personagem> Instancia
        {
            get
            {
                if (!InstanciaPersonagem.Any())
                {
                    InstanciaPersonagem = Personagens;
                }

                return InstanciaPersonagem;
            }
        }
    }
}
