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

            if (filtroPersonagem?.DataDeAquisicao is not null)
            {
                const double MAXIMO_HORAS = 23;
                const double MAXIMO_MINUTOS_SEGUNDOS = 59;
                const double MAXIMO_MILISEGUNDOS = 999;


                var dataFiltroMin = Convert.ToDateTime(filtroPersonagem.DataDeAquisicao);

                var dataFiltroMax = dataFiltroMin.AddHours(MAXIMO_HORAS)
                                 .AddMinutes(MAXIMO_MINUTOS_SEGUNDOS)
                                 .AddSeconds(MAXIMO_MINUTOS_SEGUNDOS)
                                 .AddMilliseconds(MAXIMO_MILISEGUNDOS);

                query = from q in query
                        where q.DataDeAquisicao >= dataFiltroMin
                        where q.DataDeAquisicao <= dataFiltroMax
                        select q;
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
