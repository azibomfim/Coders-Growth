using CodersGrowth.Dominio.Filtros;
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

        public ServicoUsuario(IRepositorioUsuario UsuarioRepositorio, IValidator<Usuario> validacao)
        {
            _usuariorepositorio = UsuarioRepositorio;
            _validacao = validacao;
        }

        public List<Usuario> ObterTodos(FiltroUsuario? filtroUsuario)
        {
            return _usuariorepositorio.ObterTodos(filtroUsuario);
        }

        public Usuario ObterPorId(int Id)
        {
            return _usuariorepositorio.ObterPorId(Id) ?? throw new Exception("Usuário não encontrado.");
        }

        public void Criar(Usuario usuario)
        {
            _validacao.ValidateAndThrow(usuario);
            _usuariorepositorio.Criar(usuario);
        }

        public void Editar(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new Exception("UOcorreu um erro na aplicação: Usuario não retornado");
            }

            _validacao.ValidateAndThrow(usuario);
            _usuariorepositorio.Editar(usuario);
        }

        public void Remover(int Id)
        {
            _usuariorepositorio.Remover(Id);
        }
    }
}
