using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Models;
using System.Collections.Generic;

namespace CodersGrowth.Dominio.Interfaces
{
    public interface IRepositorioUsuario
    {
        List<Usuario> ObterTodos(FiltroUsuario? filtroUsuario);
        Usuario ObterPorId(int Id);
        void Criar(Usuario usuario);
        void Editar(Usuario usuario);
        void Remover(int Id);
    }
}
