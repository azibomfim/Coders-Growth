﻿using System;
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
        private readonly ConexaoDados conexaoDados;
        public RepositorioPersonagem(ConexaoDados _conexaoDados)
        {
            conexaoDados = _conexaoDados;
        }
        public void Criar(Personagem personagem)
        {
            conexaoDados.Insert(personagem);
        }

        public void Editar(Personagem personagem)
        {
            conexaoDados.Update(personagem);
        }

        public Personagem ObterPorId(int Id)
        {
            return conexaoDados.GetTable<Personagem>().FirstOrDefault(personagem => personagem.Id == Id) ?? throw new Exception($"Personagem {Id} Nao Encontrado");
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
            if (filtroPersonagem?.IdUsuario != null)
            {
                query = from c in query
                        where c.IdUsuario == filtroPersonagem.IdUsuario
                        select c;
            }

            return query.ToList();
        }

        public void Remover(int Id)
        {
            var personagemExcluir = ObterPorId(Id);
            conexaoDados.Delete(personagemExcluir);
        }
    }
}