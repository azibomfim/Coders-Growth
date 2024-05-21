using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio;
using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Infra
{
    public interface IUsuario
    {
        public List<Usuario> ObterTodos();
        public Usuario ObterPorId(int Uid);
        public string Cadastrar();
        public string Atualizar();
        public string Remover();
    }
}
