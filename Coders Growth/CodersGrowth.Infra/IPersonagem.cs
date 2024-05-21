using CodersGrowth.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodersGrowth.Infra
{
    public interface IPersonagem
    {
        public List<Personagem> ObterTodos();
        public Personagem ObterPorId(int Id);
        public void Cadastrar();
        public void Atualizar();
        public void Remover();
    }
}
