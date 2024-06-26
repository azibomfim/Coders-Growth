using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Testes.Singleton
{
    public sealed class TabelaSingletonUsuario
    {
        public static List<Usuario> InstanciaUsuario = new();
        public static readonly List<Usuario> Usuarios = new List<Usuario>()
        {
            new Usuario()
            {
                NomeDeUsuario = "rato smites",
                Senha = 160623,
                Id = 1,
                AdventureRank = 55,
            },

            new Usuario()
            {
                NomeDeUsuario = "furao insecs",
                Senha = 080623,
                Id = 2,
                AdventureRank = 56,
            },

            new Usuario()
            {
                NomeDeUsuario = "foca fofocas",
                Senha = 240702,
                Id = 3,
                AdventureRank = 48,
            },

            new Usuario()
            {
                NomeDeUsuario = "toninha bipede",
                Senha = 123456,
                Id = 4,
                AdventureRank = 50,
            },

            new Usuario()
            {
                NomeDeUsuario = "abelhinha triste",
                Senha = 847659,
                Id = 5,
                AdventureRank = 42,
            }
        };

        private TabelaSingletonUsuario() { }
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
