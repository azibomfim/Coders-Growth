using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Testes.Singleton
{
    public sealed class TabelaUsuario
    {
        private static List<Usuario> InstanciaUsuario = new();
        public static readonly List<Usuario> Usuarios = new List<Usuario>()
        {
            new Usuario()
            {
                NomeDeUsuario = "rato smites",
                Senha = 160623,
                Uid = 1,
                AdventureRank = 55,
            },

            new Usuario()
            {
                NomeDeUsuario = "furao insecs",
                Senha = 080623,
                Uid = 2,
                AdventureRank = 56,
            },

            new Usuario()
            {
                NomeDeUsuario = "foca fofocas",
                Senha = 240702,
                Uid = 3,
                AdventureRank = 48,
            },

            new Usuario()
            {
                NomeDeUsuario = "toninha bipede",
                Senha = 123456,
                Uid = 4,
                AdventureRank = 50,
            },

            new Usuario()
            {
                NomeDeUsuario = "abelhinha triste",
                Senha = 847659,
                Uid = 5,
                AdventureRank = 42,
            }
        };

        private TabelaUsuario() { }
        public static List<Usuario> Instancia
        {
            get
            {
                if (!InstanciaUsuario.Any())
                {
                    InstanciaUsuario = Usuarios;
                }

                return InstanciaUsuario;
            }
        }

    }
}
