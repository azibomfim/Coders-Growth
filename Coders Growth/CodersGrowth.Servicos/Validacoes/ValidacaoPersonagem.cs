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
                .NotNull()
                .WithMessage("Insira um nome válido");
            RuleFor(personagem => personagem.Arma)
                .IsInEnum()
                .NotNull()
                .NotEmpty()
                .WithMessage("Insira uma arma válida");
            RuleFor(personagem => personagem.Elemento)
                .IsInEnum()
                .NotNull()
                .NotEmpty()
                .WithMessage("Insira um elemento válido");
        }
    }
}
