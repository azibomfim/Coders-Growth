using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Models;
using System.Collections.Generic;

namespace CodersGrowth.Dominio.Interfaces
{
    public interface IRepositorioPersonagem
    {
        List<Personagem> ObterTodos(FiltroPersonagem? filtroPersonagem);
        Personagem ObterPorId(int Id);
        void Criar(Personagem personagem);
        void Editar(Personagem personagem);
        void Remover(int Id);
    }
}
