using CodersGrowth.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodersGrowth.Testes.Singleton
{
    public sealed class TabelaPersonagem
    {
        private static List<Personagem> InstanciaPersonagem = new();
        private static readonly List<Personagem> Personagens = new List<Personagem>();

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
