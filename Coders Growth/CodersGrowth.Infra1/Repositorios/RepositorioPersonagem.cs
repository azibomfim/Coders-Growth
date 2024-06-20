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
    public class RepositorioPersonagem : IRepositorioPersonagem
    {
        private ConexaoDados conexaoDados = new ConexaoDados();
        public Personagem Criar(Personagem personagem)
        {
            throw new NotImplementedException();
        }

        public Personagem Editar(Personagem personagem)
        {
            throw new NotImplementedException();
        }

        public Personagem ObterPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Personagem> ObterTodos(FiltroPersonagem? filtroPersonagem)
        {
            IQueryable<Personagem> query = conexaoDados.TabelaPersonagem.AsQueryable();

            if (filtroPersonagem?.NomePersonagem != null) 
            {
                query = from c in query
                        where c.NomePersonagem == filtroPersonagem.NomePersonagem
                        select c;
            }

            if (filtroPersonagem?.CriadoPorUsuario != null)
            {
                query = from c in query
                        where c.CriadoPorUsuario == filtroPersonagem.CriadoPorUsuario
                        select c;
            }

            if (filtroPersonagem?.Elemento != null)
            {
                query = from c in query
                        where c.Elemento == filtroPersonagem.Elemento
                        select c;
            }

            if (filtroPersonagem?.Arma != null)
            {
                query = from c in query
                        where c.Arma == filtroPersonagem.Arma
                        select c;
            }

            return query.ToList();
        }

        public void Remover(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
