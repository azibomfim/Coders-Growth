using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Testes.Singleton;

namespace CodersGrowth.Testes.RepositoriosMock
{
    public class PersonagemRepositorioMock : IRepositorioPersonagem
    {
        public Personagem Editar(Personagem personagem)
        {
            Personagem personagemAlterado = ObterPorId(personagem.Id);

            personagemAlterado.TaxaCrit = personagem.TaxaCrit;
            personagemAlterado.DanoCrit = personagem.DanoCrit;
            personagemAlterado.BonusCura = personagem.BonusCura;
            personagemAlterado.Ataque = personagem.Ataque;
            personagemAlterado.Escudo = personagem.Escudo;
            personagemAlterado.DataDeAquisicao = personagem.DataDeAquisicao;
            personagemAlterado.BonusElemental = personagem.BonusElemental;
            personagemAlterado.ConstelacaoLv = personagem.ConstelacaoLv;
            personagemAlterado.Defesa = personagem.Defesa;
            personagemAlterado.ProficienciaElemental = personagem.ProficienciaElemental;
            personagemAlterado.RecargaDeEnergia = personagem.RecargaDeEnergia;
            personagemAlterado.Vida = personagem.Vida;

            return personagem;
        }

        public Personagem Criar(Personagem personagem)
        {
            TabelaSingletonPersonagem.Personagens.Add(personagem);
            return personagem;
        }

        public Personagem ObterPorId(int Id)
        {
            List<Personagem> Personagens = TabelaSingletonPersonagem.Instancia;
            var personagensPorId = Personagens.FirstOrDefault(Personagem => Personagem.Id == Id);
            {
                return personagensPorId;
            }
        }

        public List<Personagem> ObterTodos(FiltroPersonagem? filtroPersonagem)
        {
            List<Personagem> _repository = TabelaSingletonPersonagem.Instancia;
            return _repository;
        }

        public void Remover(int Id)
        {
            Personagem personagem = ObterPorId(Id);
            TabelaSingletonPersonagem.Personagens.Remove(personagem);
        }
    }
}
