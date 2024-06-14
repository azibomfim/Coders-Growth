using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.InterfaceServico;
using CodersGrowth.Dominio.Interfaces;
using FluentValidation.Results;
using CodersGrowth.Servicos.Validacoes;
using FluentValidation;

namespace CodersGrowth.Servicos.Servicos
{
    public class ServicoPersonagem : IServicoPersonagem
    {
        private IRepositorioPersonagem _personagemrepositorio;
        private IValidator<Personagem> _validacao;

        public ServicoPersonagem(IRepositorioPersonagem PersonagemRepositorioMock, IValidator<Personagem> validacao)
        {
            _personagemrepositorio = PersonagemRepositorioMock;
            _validacao = validacao;
        }

        public List<Personagem> ObterTodos()
        {
            return _personagemrepositorio.ObterTodos();
        }
        public Personagem ObterPorId(int Id)
        {
            return _personagemrepositorio.ObterPorId(Id) ?? throw new Exception("Personagem não encontrado.");
        }
        public Personagem Criar(Personagem personagem)
        {
            _validacao.ValidateAndThrow(personagem);
            return _personagemrepositorio.Criar(personagem);
        }
        public Personagem Editar(Personagem personagem)
        {
            _validacao.ValidateAndThrow(personagem);
            return _personagemrepositorio.Editar(personagem);
        }
    }
}


