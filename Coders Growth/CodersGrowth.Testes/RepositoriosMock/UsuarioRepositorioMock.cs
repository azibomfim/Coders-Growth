using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Infra;
using CodersGrowth.Testes.Singleton;

namespace CodersGrowth.Testes.RepositoriosMock
{
    public class UsuarioRepositorioMock : IRepositorioUsuario
    {
        public void Editar(Usuario usuario)
        {
            Usuario usuarioAlterado = ObterPorId(usuario.Id);
            usuarioAlterado.AdventureRank = usuario.AdventureRank;
        }

        public void Criar(Usuario usuario)
        {
            TabelaSingletonUsuario.Usuarios.Add(usuario);
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
            IQueryable<Usuario> query = TabelaSingletonUsuario.Instancia.AsQueryable();

            if (filtroUsuario?.NomeDeUsuario != null)
            {
                query = from c in query
                        where c.NomeDeUsuario.Contains(filtroUsuario.NomeDeUsuario)
                        select c;
            }
            return query.ToList();
        }


        public void Remover(int Id)
        {
            Usuario usuario = ObterPorId(Id);
            TabelaSingletonUsuario.Usuarios.Remove(usuario);
        }
    }
}
