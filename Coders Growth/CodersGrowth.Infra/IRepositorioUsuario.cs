using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio;
using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Infra
{
    public interface IRepositorioUsuario
    {
<<<<<<< Updated upstream:Coders Growth/CodersGrowth.Infra/IRepositorioUsuario.cs
        public List<Usuario> ObterTodos();
        public Usuario ObterPorId(int Uid);
        public void Cadastrar();
        public void Atualizar();
        public void Remover();
=======
        List<Usuario> ObterTodos();
        Usuario ObterPorId(int Uid);
        Usuario Criar(Usuario usuario);
        Usuario Editar(Usuario usuario);
        void Remover(int Uid);
>>>>>>> Stashed changes:Coders Growth/CodersGrowth.Dominio/Interfaces/IRepositorioUsuario.cs
    }
}
