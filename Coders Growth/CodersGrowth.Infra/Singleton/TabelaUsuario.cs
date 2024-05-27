using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Infra.Singleton
{
    public sealed class TabelaUsuario
    {
        private static List<Usuario> InstanciaUsuario = new();
        private static readonly List<Usuario> Usuarios = new List<Usuario>();

        private TabelaUsuario() { }
        public static List<Usuario> Instancia
        {
            get
            {
                if (InstanciaUsuario == null)
                {
                    InstanciaUsuario = Usuarios;
                }

                return InstanciaUsuario;
            }
        }

    }
}
