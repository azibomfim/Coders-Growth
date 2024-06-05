using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Servicos.InterfaceServico
{
    public interface IServicoUsuario
    {
        public List<Usuario> ObterTodos();
        public List<Usuario> ObterPorId(int Uid);
    }
}
