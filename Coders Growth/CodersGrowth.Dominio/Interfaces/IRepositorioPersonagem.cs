using CodersGrowth.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace CodersGrowth.Dominio.Interfaces
{
    public interface IRepositorioPersonagem
    {
        public List<Personagem> ObterTodos();
        public Personagem ObterPorId(int Id);
        public Personagem Criar(Personagem personagem);
        public Personagem Atualizar(Personagem personagem);
        public void Remover(int Id);
    }
}
