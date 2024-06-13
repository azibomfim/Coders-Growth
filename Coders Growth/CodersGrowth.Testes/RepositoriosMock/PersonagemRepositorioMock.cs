using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.Validacoes;
using CodersGrowth.Testes.Singleton;
using FluentValidation;
using FluentValidation.Results;

namespace CodersGrowth.Testes.RepositoriosMock
{
    public class PersonagemRepositorioMock : IRepositorioPersonagem
    {
        public Personagem Atualizar(Personagem personagem)
        {
            throw new NotImplementedException();
        }

        public Personagem Criar(Personagem personagem)
        {
            TabelaPersonagem.Personagens.Add(personagem);
            return personagem;
        }

        public Personagem ObterPorId(int Id)
        {
            List<Personagem> Personagens = TabelaPersonagem.Instancia;
            var personagensPorId = Personagens.FirstOrDefault(Personagem => Personagem.Id == Id);
            {
                return personagensPorId;
            }
        }
    
        public List<Personagem> ObterTodos()
        {
            List<Personagem> _repository = TabelaPersonagem.Instancia;
            return _repository;
        }

        public void Remover(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
