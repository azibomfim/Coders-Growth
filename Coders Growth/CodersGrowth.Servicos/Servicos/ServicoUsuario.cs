using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.InterfaceServico;
using FluentValidation;
using FluentValidation.Results;

namespace CodersGrowth.Servicos.Servicos
{
    public class ServicoUsuario: IServicoUsuario
    {
        private IRepositorioUsuario _usuariorepositorio;
        private IValidator<Usuario> _validacao;

        public ServicoUsuario(IRepositorioUsuario UsuarioRepositorioMock, IValidator<Usuario> validacao)
        {
            _usuariorepositorio = UsuarioRepositorioMock;
            _validacao = validacao;
        }
        public List<Usuario> ObterTodos()
        {
            return _usuariorepositorio.ObterTodos();
        }
        public Usuario ObterPorId(int Uid)
        {
            return _usuariorepositorio.ObterPorId(Uid) ?? throw new Exception("Usuário não encontrado.");
        }
        public Usuario Criar(Usuario usuario)
        {
            _validacao.ValidateAndThrow(usuario);
            return _usuariorepositorio.Criar(usuario);
        }
    }
}
