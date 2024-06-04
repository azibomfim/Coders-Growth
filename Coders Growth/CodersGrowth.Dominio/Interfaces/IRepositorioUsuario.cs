using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio;
using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Dominio.Interfaces
{
    public interface IRepositorioUsuario
    {
        public List<Usuario> ObterTodos();
        public Usuario ObterPorId(int Uid);
        public void Cadastrar();
        public void Atualizar();
        public void Remover();
    }
}
