using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using FluentValidation;
using LinqToDB.Common;
using Microsoft.Extensions.Options;
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
            _validacao.Validate(usuario, options =>
            {
                options.ThrowOnFailures();
                options.IncludeRuleSets("Criar");
                });
            
            _usuariorepositorio.Criar(usuario);
        }

        public void Editar(Usuario usuario)
        {
            usuario = usuario ?? throw new NullReferenceException("Ocorreu um erro na aplicação: Usuario não retornado");

            _validacao.Validate(usuario, options =>
            {
                options.ThrowOnFailures();
                options.IncludeRuleSets("Editar");
            });

            _usuariorepositorio.Editar(usuario);
        }

        public void Remover(int Id)
        {
            _usuariorepositorio.Remover(Id);
        }
    }
}

