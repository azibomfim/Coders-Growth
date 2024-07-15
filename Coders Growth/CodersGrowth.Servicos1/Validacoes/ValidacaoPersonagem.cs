using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using FluentValidation;
using System.Linq;

namespace CodersGrowth.Servicos.Validacoes
{
    public class ValidacaoPersonagem : AbstractValidator<Personagem>
    {
        private const bool resultado = false;
        private IRepositorioUsuario _usuariorepositorio;
        private Personagem personagem = new();
        private string nomeUsuario;
        public ValidacaoPersonagem(IRepositorioUsuario usuariorepositorio)
        {
            _usuariorepositorio = usuariorepositorio;
            personagem.NomeUsuario = nomeUsuario;

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
                .When(personagem => (bool)personagem.CriadoPorUsuario)
                .WithMessage("Personagem não foi criado por usuário");

            RuleFor(personagem => personagem.IdUsuario)
                .Empty()
                .When(personagem => (bool)!personagem.CriadoPorUsuario)
                .WithMessage("Assinale que o personagem foi criado por usuário");

            RuleFor(personagem => personagem.ConstelacaoLv)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Insira um nível de constelação de 0 a 6")
                .LessThanOrEqualTo(6)
                .WithMessage("Insira um nível de constelação de 0 a 6")
                .NotNull()
                .WithMessage("Preencha o campo Constelação")
                .NotEmpty()
                .WithMessage("Preencha o campo Constelação");

            RuleFor(personagem => personagem.ProficienciaElemental)
                .NotNull()
                .WithMessage("Preencha o campo Proficiência")
                .NotEmpty()
                .WithMessage("Preencha o campo Proficiência")
                .GreaterThanOrEqualTo(0)
                .WithMessage("Proficiência deve ter um valor positivo");

            RuleFor(personagem => personagem.Vida)
                .NotNull()
                .WithMessage("Preencha o campo Vida")
                .NotEmpty()
                .WithMessage("Preencha o campo Vida")
                .GreaterThanOrEqualTo(0)
                .WithMessage("Vida deve ter um valor positivo");

            RuleFor(personagem => personagem.Ataque)
                .NotNull()
                .WithMessage("Preencha o campo Ataque")
                .NotEmpty()
                .WithMessage("Preencha o campo Ataque")
                .GreaterThanOrEqualTo(0)
                .WithMessage("Ataque deve ter um valor positivo");

            RuleFor(personagem => personagem.Defesa)
                .NotNull()
                .WithMessage("Preencha o campo Defesa")
                .NotEmpty()
                .WithMessage("Preencha o campo Defesa")
                .GreaterThanOrEqualTo(0)
                .WithMessage("Defesa deve ter um valor positivo");

            RuleFor(personagem => personagem.TaxaCrit)
               .NotNull()
               .WithMessage("Preencha o campo Taxa Crítica")
               .NotEmpty()
               .WithMessage("Preencha o campo Taxa Crítica");

            RuleFor(personagem => personagem.DanoCrit)
               .NotNull()
               .WithMessage("Preencha o campo Dano Crítico")
               .NotEmpty()
               .WithMessage("Preencha o campo Dano Crítico");

            RuleFor(personagem => personagem.BonusCura)
               .NotNull()
               .WithMessage("Preencha o campo Bônus de Cura")
               .NotEmpty()
               .WithMessage("Preencha o campo Bônus de Cura");

            RuleFor(personagem => personagem.RecargaDeEnergia)
               .NotNull()
               .WithMessage("Preencha o campo Recarga de Energia")
               .NotEmpty()
               .WithMessage("Preencha o campo Recarga de Energia");

            RuleFor(personagem => personagem.Escudo)
               .NotNull()
               .WithMessage("Preencha o campo Força de Escudo")
               .NotEmpty()
               .WithMessage("Preencha o campo Força de Escudo");

            RuleFor(personagem => personagem.BonusElemental)
               .NotNull()
               .WithMessage("Preencha o campo Bônus Elemental")
               .NotEmpty()
               .WithMessage("Preencha o campo Bônus Elemental");

            RuleFor(personagem => personagem.NomeUsuario)
                .NotNull()
                .When(personagem => (bool)personagem.CriadoPorUsuario)
                .WithMessage("Insira nome de usuário")
                .NotEmpty()
                .When(personagem => (bool)personagem.CriadoPorUsuario)
                .WithMessage("Insira nome de usuário")
                .Must(VerificaSeNomeDeUsuarioExiste)
                .WithMessage("Nome de usuário não existe, por favor, verifique a escrita ou cadastre-se!");
        }
        private bool VerificaSeNomeDeUsuarioExiste(string nomeUsuario)
        {
            FiltroUsuario filtro = new FiltroUsuario();
            filtro.NomeDeUsuario = nomeUsuario;
            var listaDeNomes = _usuariorepositorio.ObterTodos(filtro);
            if (listaDeNomes.FirstOrDefault(usuario => usuario.NomeDeUsuario == nomeUsuario) == null)
                return false;

            return true;
        }
    }
}
