using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.Validacoes;
using CodersGrowth.Testes.Singleton;
using FluentValidation;
using FluentValidation.Results;

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

            return ObterPorId(personagemAlterado.Id);
        }

        public Personagem Criar(Personagem personagem)
        {
            TabelaPersonagem.Personagens.Add(personagem);
            return personagem;
        }

        public Personagem ObterPorId(int Id)
        {
            List<Personagem> Personagens = TabelaPersonagem.Instancia;
            var personagensPorId = Personagens.FirstOrDefault(Personagem => Personagem.Id == Id);
            {
                return personagensPorId;
            }
        }
    
        public List<Personagem> ObterTodos()
        {
            List<Personagem> _repository = TabelaPersonagem.Instancia;
            return _repository;
        }

        public void Remover(int Id)
        {
            Personagem personagem = ObterPorId(Id);
            TabelaPersonagem.Personagens.Remove(personagem);
        }
    }
}
