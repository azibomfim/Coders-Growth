using CodersGrowth.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodersGrowth.Infra
{
    public interface IRepositorioPersonagem
    {
<<<<<<< Updated upstream:Coders Growth/CodersGrowth.Infra/IRepositorioPersonagem.cs
        public List<Personagem> ObterTodos();
        public Personagem ObterPorId(int Id);
        public void Cadastrar();
        public void Atualizar();
        public void Remover();
=======
        List<Personagem> ObterTodos();
        Personagem ObterPorId(int Id);
        Personagem Criar(Personagem personagem);
        Personagem Editar(Personagem personagem);
        void Remover(int Id);
>>>>>>> Stashed changes:Coders Growth/CodersGrowth.Dominio/Interfaces/IRepositorioPersonagem.cs
    }
}
