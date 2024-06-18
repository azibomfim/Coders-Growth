using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace CodersGrowth.Servicos.Servicos
{
    public class ServicoUsuario
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

        public Usuario Editar(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new Exception("UOcorreu um erro na aplicação: Usuario não retornado");
            }

            _validacao.ValidateAndThrow(usuario);
            return _usuariorepositorio.Editar(usuario);
        }

        public void Remover(int Uid)
        {
            _usuariorepositorio.Remover(Uid);
        }
    }
}
