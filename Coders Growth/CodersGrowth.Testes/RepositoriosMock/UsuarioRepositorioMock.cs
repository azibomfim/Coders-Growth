using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Testes.Singleton;

namespace CodersGrowth.Testes.RepositoriosMock
{
    public class UsuarioRepositorioMock : IRepositorioUsuario
    {
        public Usuario Editar(Usuario usuario)
        {
            Usuario usuarioAlterado = ObterPorId(usuario.Id);
            usuarioAlterado.NomeDeUsuario = usuario.NomeDeUsuario;
            usuarioAlterado.AdventureRank = usuario.AdventureRank;
            usuarioAlterado.Senha = usuario.Senha;

            return ObterPorId(usuarioAlterado.Id);
        }

        public Usuario Criar(Usuario usuario)
        {
            TabelaSingletonUsuario.Usuarios.Add(usuario);
            return usuario;
        }

        public Usuario ObterPorId(int Id)
        {
            List<Usuario> Usuarios = TabelaSingletonUsuario.Instancia;
            var usuariosPorId = Usuarios.FirstOrDefault(Usuario => Usuario.Id == Id);
            {
                return usuariosPorId;
            }
        }

        public List<Usuario> ObterTodos(FiltroUsuario? filtroUsuario)
        {
            List<Usuario> _repository = TabelaSingletonUsuario.Instancia;
            return _repository;
        }

        public void Remover(int Id)
        {
            Usuario usuario = ObterPorId(Id);
            TabelaSingletonUsuario.Usuarios.Remove(usuario);
        }
    }
}
