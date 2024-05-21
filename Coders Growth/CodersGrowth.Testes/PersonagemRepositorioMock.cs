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
            List<Personagem> personagem = new List<Personagem>();
            return personagem;
        }

        public void Remover()
        {
            throw new NotImplementedException();
        }
    }
}
