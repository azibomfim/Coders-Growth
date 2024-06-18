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

<<<<<<< HEAD
        public Usuario Criar(Usuario usuario)
=======
        public Usuario Criar(Usuario usuario) 
>>>>>>> 8c6a9040d8b90c3deb152a27cbdf5640e20182b6
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

<<<<<<< HEAD
        public List<Usuario> ObterTodos()
=======
        public List<Usuario> ObterTodos() 
>>>>>>> 8c6a9040d8b90c3deb152a27cbdf5640e20182b6
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
