using CodersGrowth.Dominio.Models;
using System.Collections.Generic;

namespace CodersGrowth.Dominio.Interfaces
{
    public interface IRepositorioUsuario
    {
        List<Usuario> ObterTodos();
        Usuario ObterPorId(int Uid);
        Usuario Criar(Usuario usuario);
        Usuario Editar(Usuario usuario);
        void Remover(int Uid);
    }
}
