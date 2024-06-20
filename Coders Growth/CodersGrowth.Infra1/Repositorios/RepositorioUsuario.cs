using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodersGrowth.Dominio;
using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using LinqToDB;

namespace CodersGrowth.Infra.Repositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private ConexaoDados conexaoDados = new ConexaoDados();
        public Usuario Criar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario Editar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario ObterPorId(int Uid)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ObterTodos(FiltroUsuario? filtroUsuario)
        {
            if (filtroUsuario == null) return conexaoDados.TabelaUsuario.ToList();

            IQueryable<Usuario> query = conexaoDados.TabelaUsuario.AsQueryable();

            if (filtroUsuario.NomeDeUsuario != null)
            {
                query = from c in query
                        where c.NomeDeUsuario == filtroUsuario.NomeDeUsuario
                        select c;
            }

            if (filtroUsuario.AdventureRank != null)
            {
                query = from c in query
                        where c.AdventureRank == filtroUsuario.AdventureRank
                        select c;
            }

            return query.ToList();
        }

        public void Remover(int Uid)
        {
            throw new NotImplementedException();
        }
    }
}
