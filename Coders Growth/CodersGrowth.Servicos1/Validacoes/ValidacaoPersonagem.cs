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
                .IsInEnum()
                .WithMessage("Insira um nome válido");

            RuleFor(personagem => personagem.Arma)
                .IsInEnum()
                .WithMessage("Insira uma arma válida");

            RuleFor(personagem => personagem.Elemento)
                .IsInEnum()
                .WithMessage("Insira um elemento válido");

            RuleFor(personagem => personagem.NomeUsuario)
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
