using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Servicos.InterfaceServico
{
    public interface IServicoPersonagem
    {
        public List<Personagem> ObterTodos();
        public Personagem ObterPorId(int Id);
    }
}
