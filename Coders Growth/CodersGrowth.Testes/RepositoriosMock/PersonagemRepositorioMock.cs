﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Testes.Singleton;

namespace CodersGrowth.Testes.RepositoriosMock
{
    public class PersonagemRepositorioMock : IRepositorioPersonagem
    {
        public void Atualizar()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar()
        {
            throw new NotImplementedException();
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

        public void Remover()
        {
            throw new NotImplementedException();
        }
    }
}
