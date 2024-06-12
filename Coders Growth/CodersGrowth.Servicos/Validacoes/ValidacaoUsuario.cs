using CodersGrowth.Dominio.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;


namespace CodersGrowth.Servicos.Validacoes
{
    public class ValidacaoUsuario : AbstractValidator<Usuario>
    {
        public ValidacaoUsuario()
        {
            RuleFor(usuario => usuario.NomeDeUsuario)
                .NotEmpty()
                .NotNull()
                .WithMessage("Insira um nome válido");
            RuleFor(usuario => usuario.AdventureRank)
                .LessThanOrEqualTo(60)
                .GreaterThan(0)
                .NotNull()
                .NotEmpty()
                .WithMessage("Insira um Adventure Rank válido");
            RuleFor(usuario => usuario.Senha)
                .NotEmpty()
                .NotNull()
                .Must(usuario => usuario.ToString().Length < 10)
                .Must(usuario => usuario.ToString().Length > 4)
                .WithMessage("Insira uma senha válida");
        }
    }
}
