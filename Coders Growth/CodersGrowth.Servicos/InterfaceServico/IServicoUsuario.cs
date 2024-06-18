using CodersGrowth.Dominio.Models;
using FluentValidation.Results;
using System.Collections.Generic;

namespace CodersGrowth.Servicos.InterfaceServico
{
    public interface IServicoUsuario
    {
        List<Usuario> ObterTodos();
        Usuario ObterPorId(int Uid);
        Usuario Criar(Usuario usuario);
        Usuario Editar(Usuario usuario);
        void Remover(int Uid);
    }
}
