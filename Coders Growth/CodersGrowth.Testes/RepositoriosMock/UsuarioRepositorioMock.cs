using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Testes.Singleton;

namespace CodersGrowth.Testes.RepositoriosMock
{
    public class UsuarioRepositorioMock : IRepositorioUsuario
    {
        public Usuario Editar(Usuario usuario)
        {
            Usuario usuarioAlterado = ObterPorId(usuario.Uid);
            usuarioAlterado.NomeDeUsuario = usuario.NomeDeUsuario;
            usuarioAlterado.AdventureRank = usuario.AdventureRank;
            usuarioAlterado.Senha = usuario.Senha;

            return ObterPorId(usuarioAlterado.Uid);
        }

        public Usuario Criar(Usuario usuario) 
        {
            TabelaUsuario.Usuarios.Add(usuario);
            return usuario;
        }

        public Usuario ObterPorId(int Uid)
        {
            List<Usuario> Usuarios = TabelaUsuario.Instancia;
            var usuariosPorId = Usuarios.FirstOrDefault(Usuario => Usuario.Uid == Uid);
            {
                return usuariosPorId;
            }
        }

        public List<Usuario> ObterTodos() 
        {
            List<Usuario> _repository = TabelaUsuario.Instancia;
            return _repository;
        }

        public void Remover(int Uid)
        {
            Usuario usuario = ObterPorId(Uid);
            TabelaUsuario.Usuarios.Remove(usuario);
        }
    }
}
