using System;
using System.Collections.Generic;
using System.Text;
using CodersGrowth.Dominio;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using LinqToDB;

namespace CodersGrowth.Infra.Repositorios
{
    public class RepositorioPersonagem : IRepositorioPersonagem
    {
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

        public List<Personagem> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
