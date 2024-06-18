using CodersGrowth.Dominio.Models;
using FluentValidation.Results;

namespace CodersGrowth.Servicos.InterfaceServico
{
    public interface IServicoUsuario
    {
        public List<Usuario> ObterTodos();
        public Usuario ObterPorId(int Uid);
        public Usuario Criar(Usuario usuario);
        public Usuario Editar(Usuario usuario);
        public void Remover(int Uid);
    }
}
