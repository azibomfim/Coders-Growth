using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Testes.Singleton
{
    public sealed class TabelaUsuario
    {
<<<<<<< HEAD
        public static List<Usuario> InstanciaUsuario = new();
=======
        private static List<Usuario> InstanciaUsuario = new();
>>>>>>> 8c6a9040d8b90c3deb152a27cbdf5640e20182b6
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
