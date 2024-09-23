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

            if (filtroPersonagem?.DataDeAquisicao is not null)
            {
                const double MAXIMO_HORAS = 23;
        const double MAXIMO_MINUTOS_SEGUNDOS = 59;
        const double MAXIMO_MILISEGUNDOS = 999;


        var dataFiltroMin = Convert.ToDateTime(filtroPersonagem.DataDeAquisicao);

        var dataFiltroMax = dataFiltroMin.AddHours(MAXIMO_HORAS)
                         .AddMinutes(MAXIMO_MINUTOS_SEGUNDOS)
                         .AddSeconds(MAXIMO_MINUTOS_SEGUNDOS)
                         .AddMilliseconds(MAXIMO_MILISEGUNDOS);

        query = from q in query
                where q.DataDeAquisicao >= dataFiltroMin
                where q.DataDeAquisicao <= dataFiltroMax
                select q;
            }

            if (filtroPersonagem?.NomeUsuario != null)
            {
                query = from c in query
                        where c.NomeUsuario.Contains(filtroPersonagem.NomeUsuario)
                        select c;
            }
            return query.ToList();

            return query.ToList();
        }

        public void Remover(int Id)
        {
            Personagem personagem = ObterPorId(Id);
            TabelaSingletonPersonagem.Personagens.Remove(personagem);
        }
    }
}
