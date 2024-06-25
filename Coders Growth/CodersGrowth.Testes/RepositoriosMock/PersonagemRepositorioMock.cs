using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Infra;
using CodersGrowth.Testes.Singleton;
using LinqToDB;

namespace CodersGrowth.Testes.RepositoriosMock
{
    public class PersonagemRepositorioMock : IRepositorioPersonagem
    {
        public void Editar(Personagem personagem)
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
        }

        public void Criar(Personagem personagem)
        {
            TabelaSingletonPersonagem.Personagens.Add(personagem);
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
            IQueryable<Personagem> query = TabelaSingletonPersonagem.Instancia.AsQueryable();

            if (filtroPersonagem?.NomePersonagem != null)
            {
                query = from c in query
                        where c.NomePersonagem == filtroPersonagem.NomePersonagem
                        select c;
            }

            if (filtroPersonagem?.CriadoPorUsuario != null)
            {
                query = from c in query
                        where c.CriadoPorUsuario == filtroPersonagem.CriadoPorUsuario
                        select c;
            }

            if (filtroPersonagem?.Elemento != null)
            {
                query = from c in query
                        where c.Elemento == filtroPersonagem.Elemento
                        select c;
            }

            if (filtroPersonagem?.Arma != null)
            {
                query = from c in query
                        where c.Arma == filtroPersonagem.Arma
                        select c;
            }
            if (filtroPersonagem?.DataDeAquisicao != null)
            {
                query = from c in query
                        where c.DataDeAquisicao == filtroPersonagem.DataDeAquisicao
                        select c;
            }

            return query.ToList();
        }

        public void Remover(int Id)
        {
            Personagem personagem = ObterPorId(Id);
            TabelaSingletonPersonagem.Personagens.Remove(personagem);
        }
    }
}
