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
                Id = 1,
                AdventureRank = 55,
            },

            new Usuario()
            {
                NomeDeUsuario = "furao insecs",
                Id = 2,
                AdventureRank = 56,
            },

            new Usuario()
            {
                NomeDeUsuario = "foca fofocas",
                Id = 3,
                AdventureRank = 48,
            },

            new Usuario()
            {
                NomeDeUsuario = "toninha bipede",
                Id = 4,
                AdventureRank = 50,
            },

            new Usuario()
            {
                NomeDeUsuario = "abelhinha triste",
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
