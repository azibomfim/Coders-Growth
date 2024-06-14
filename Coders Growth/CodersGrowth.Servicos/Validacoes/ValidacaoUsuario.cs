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
                .WithMessage("Insira um nome válido")
                .NotNull()
                .WithMessage("Insira um nome válido");

            RuleFor(usuario => usuario.AdventureRank)
                .LessThanOrEqualTo(60)
                .WithMessage("Insira um Adventure Rank entre 1 e 60")
                .GreaterThan(0)
                .WithMessage("Insira um Adventure Rank entre 1 e 60")
                .NotNull()
                .WithMessage("Insira um Adventure Rank entre 1 e 60")
                .NotEmpty()
                .WithMessage("Insira um Adventure Rank entre 1 e 60");

            RuleFor(usuario => usuario.Senha)
                .NotEmpty()
                .WithMessage("Sua senha precisa ter de 4 a 9 caracteres")
                .NotNull()
                .WithMessage("Sua senha precisa ter de 4 a 9 caracteres")
                .Must(usuario => usuario.ToString().Length < 10)
                .WithMessage("Sua senha precisa ter de 4 a 9 caracteres")
                .Must(usuario => usuario.ToString().Length > 3)
                .WithMessage("Sua senha precisa ter de 4 a 9 caracteres");
        }
    }
}
