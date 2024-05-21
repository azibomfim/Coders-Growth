using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Infra;
using CodersGrowth.Dominio;
using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Testes
{
    public class PersonagemRepositorioMock : IPersonagem
    {
        public PersonagemRepositorioMock()
        {
            throw new NotImplementedException();
        }

        public string Atualizar(Personagem personagem)
        {
            throw new NotImplementedException();
        }

        public string Cadastrar(Personagem personagem)
        {
            throw new NotImplementedException();
        }

        public Personagem ObterPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Personagem> ObterTodos()
        {
            List<Personagem> personagem = new List<Personagem>();
            return personagem;
        }

        public string Remover(Personagem personagem)
        {
            throw new NotImplementedException();
        }
    }
}
