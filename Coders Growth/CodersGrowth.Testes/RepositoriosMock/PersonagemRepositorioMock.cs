using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Testes.Singleton;

namespace CodersGrowth.Testes.RepositoriosMock
{
    public class PersonagemRepositorioMock : IRepositorioPersonagem
    {
        //private readonly List<Personagem> _repository = TabelaPersonagem.Instancia;

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
            throw new NotImplementedException();
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
