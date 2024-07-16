using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using FluentValidation;
using System.Linq;


namespace CodersGrowth.Servicos.Validacoes
{
    public class ValidacaoUsuario : AbstractValidator<Usuario>
    {
        private IRepositorioUsuario _usuariorepositorio;
        public ValidacaoUsuario(IRepositorioUsuario usuariorepositorio)
        {
            _usuariorepositorio = usuariorepositorio;
            RuleSet("Criar", () =>
            {
                RuleFor(usuario => usuario.NomeDeUsuario)
                    .NotEmpty()
                    .WithMessage("Insira um nome válido")
                    .NotNull()
                    .WithMessage("Insira um nome válido")
                    .Must(VerificaSeNomeEstaDisponivel)
                    .WithMessage("O nome inserido já existe, por favor escolha outro");

                RuleFor(usuario => usuario.AdventureRank)
                    .LessThanOrEqualTo(60)
                    .WithMessage("Insira um Adventure Rank entre 1 e 60")
                    .GreaterThan(0)
                    .WithMessage("Insira um Adventure Rank entre 1 e 60")
                    .NotNull()
                    .WithMessage("Insira um Adventure Rank entre 1 e 60")
                    .NotEmpty()
                    .WithMessage("Insira um Adventure Rank entre 1 e 60");
            });
            RuleSet("Editar", () =>
            {

                RuleFor(usuario => usuario.AdventureRank)
                    .LessThanOrEqualTo(60)
                    .WithMessage("Insira um Adventure Rank entre 1 e 60")
                    .GreaterThan(0)
                    .WithMessage("Insira um Adventure Rank entre 1 e 60")
                    .NotNull()
                    .WithMessage("Insira um Adventure Rank entre 1 e 60")
                    .NotEmpty()
                    .WithMessage("Insira um Adventure Rank entre 1 e 60");

                RuleFor(usuario => usuario.NomeDeUsuario)
                    .NotEmpty()
                    .WithMessage("Insira um nome válido")
                    .NotNull()
                    .WithMessage("Insira um nome válido");
            });
        }
        private bool VerificaSeNomeEstaDisponivel(string nomeUsuario)
        {
            FiltroUsuario filtro = new FiltroUsuario();
            filtro.NomeDeUsuario = nomeUsuario;
            var listaDeNomes = _usuariorepositorio.ObterTodos(filtro);
            if (listaDeNomes.FirstOrDefault(usuario => usuario.NomeDeUsuario == nomeUsuario) == null)
                return true;

            return false;
        }
    }
}
