using CodersGrowth.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodersGrowth.Infra
{
    public interface IPersonagemMock
    {
        public List<Personagem> ObterTodos();
        Personagem ObterPorId(int Id);
        string Cadastrar(Personagem personagem);
        string Atualizar(Personagem personagem);
        string Remover(Personagem personagem);
    }
}
