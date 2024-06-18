using CodersGrowth.Dominio.Models;
using System.Collections.Generic;

namespace CodersGrowth.Servicos.InterfaceServico
{
    public interface IServicoPersonagem
    {
        List<Personagem> ObterTodos();
        Personagem ObterPorId(int Id);
        Personagem Criar(Personagem personagem);
        Personagem Editar(Personagem personagem);
        void Remover(int Id);
    }
}
