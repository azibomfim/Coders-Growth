using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio;
using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Infra
{
    public interface IUsuarioMock
    {
        public List<Usuario> ObterTodos();
        Usuario ObterPorId(int Uid);
        string Cadastrar(Usuario usuario);
        string Atualizar(Usuario usuario);
        string Remover(Usuario usuario);
    }
}
