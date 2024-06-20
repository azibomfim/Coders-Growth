using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Models;
using System.Collections.Generic;

namespace CodersGrowth.Dominio.Interfaces
{
    public interface IRepositorioPersonagem
    {
        List<Personagem> ObterTodos(FiltroPersonagem? filtroPersonagem);
        Personagem ObterPorId(int Id);
        Personagem Criar(Personagem personagem);
        Personagem Editar(Personagem personagem);
        void Remover(int Id);
    }
}
