using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;
using FluentValidation;
using FluentValidation.Results;

namespace CodersGrowth.Servicos.Validacoes
{
    public class ValidacaoPersonagem : AbstractValidator<Personagem>
    {
        public ValidacaoPersonagem()
        {
            RuleFor(personagem => personagem.NomePersonagem)
                .NotEmpty()
                .WithMessage("Insira um nome válido")
                .NotNull()
                .WithMessage("Insira um nome válido");
            RuleFor(personagem => personagem.Arma)
                .IsInEnum()
                .WithMessage("Insira uma arma válida")
                .NotNull()
                .WithMessage("Insira uma arma válida")
                .NotEmpty()
                .WithMessage("Insira uma arma válida");
            RuleFor(personagem => personagem.Elemento)
                .IsInEnum()
                .WithMessage("Insira um elemento válido")
                .NotNull()
                .WithMessage("Insira um elemento válido")
                .NotEmpty()
                .WithMessage("Insira um elemento válido");
            RuleFor(personagem => personagem.IdUsuario)
                .NotNull()
                .When(personagem => personagem.CriadoPorUsuario)
                .WithMessage("Personagem não foi criado por usuário");
            RuleFor(personagem => personagem.IdUsuario)
                .Empty()
                .When(personagem => !personagem.CriadoPorUsuario)
                .WithMessage("Assinale que o personagem foi criado por usuário");
        }
    }
}
