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
            RuleFor(personagem => personagem.NomePersonagem).NotEmpty();
            RuleFor(personagem => personagem.Arma).NotEmpty();
            RuleFor(personagem => personagem.Elemento).NotEmpty();

            Personagem personagem = new Personagem();
            ValidacaoPersonagem validacao = new ValidacaoPersonagem();

            ValidationResult result = validacao.Validate(personagem);
        }
    }
}
