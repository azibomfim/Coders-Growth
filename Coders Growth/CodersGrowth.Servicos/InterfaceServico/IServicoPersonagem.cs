using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Servicos.InterfaceServico
{
    public interface IServicoPersonagem
    {
        public List<Personagem> ObterTodos();
        public Personagem ObterPorId(int Id);
        public Personagem Criar(Personagem personagem);
        public Personagem Editar(Personagem personagem);
    }
}
