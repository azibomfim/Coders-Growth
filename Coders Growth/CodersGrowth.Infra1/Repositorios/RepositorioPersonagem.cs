using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodersGrowth.Infra.Repositorios
{
    public class RepositorioPersonagem : IRepositorioPersonagem
    {
        private readonly ConexaoDados _conexaoDados;
        public RepositorioPersonagem(ConexaoDados conexaoDados)
        {
            _conexaoDados = conexaoDados;
        }
        public void Criar(Personagem personagem)
        {
            _conexaoDados.Insert(personagem);
        }

        public void Editar(Personagem personagem)
        {
            _conexaoDados.Update(personagem);
        }

        public Personagem ObterPorId(int Id)
        {
            return _conexaoDados.GetTable<Personagem>().FirstOrDefault(personagem => personagem.Id == Id) ?? throw new Exception($"Personagem {Id} Nao Encontrado");
        }

        public List<Personagem> ObterTodos(FiltroPersonagem? filtroPersonagem)
        {
            IQueryable<Personagem> query = _conexaoDados.TabelaPersonagem.AsQueryable();
            const int idUsuarioZero = 0;

            if (filtroPersonagem?.NomePersonagem != null && filtroPersonagem?.NomePersonagem != idUsuarioZero)
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

            if (filtroPersonagem?.Elemento != null && filtroPersonagem?.Elemento != idUsuarioZero)
            {
                query = from c in query
                        where c.Elemento == filtroPersonagem.Elemento
                        select c;
            }

            if (filtroPersonagem?.Arma != null && filtroPersonagem?.Arma != idUsuarioZero)
            {
                query = from c in query
                        where c.Arma == filtroPersonagem.Arma
                        select c;
            }
            if (filtroPersonagem?.DataDeAquisicao != null)
            {
                query = from c in query
                        where c.DataDeAquisicao == filtroPersonagem.DataDeAquisicao
                        select c;
            }
            if (filtroPersonagem?.NomeUsuario != null)
            {
                query = from c in query
                        where c.NomeUsuario.Contains(filtroPersonagem.NomeUsuario)
                        select c;
            }
            return query.ToList();
        }

        public void Remover(int Id)
        {
            var personagemExcluir = ObterPorId(Id);
            _conexaoDados.Delete(personagemExcluir);
        }
    }
}
