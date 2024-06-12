using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Infra;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Testes.Singleton;
using CodersGrowth.Servicos.Validacoes;
using FluentValidation;
using FluentValidation.Results;

namespace CodersGrowth.Testes.RepositoriosMock
{
    public class UsuarioRepositorioMock : IRepositorioUsuario
    {
        public void Atualizar()
        {
            throw new NotImplementedException();
        }

        public Usuario Criar(Usuario usuario) 
        {
            TabelaUsuario.Usuarios.Add(usuario);
            return usuario;
        }

        public Usuario ObterPorId(int Uid)
        {
            List<Usuario> Usuarios = TabelaUsuario.Instancia;
            var usuariosPorId = Usuarios.FirstOrDefault(Usuario => Usuario.Uid == Uid);
            {
                return usuariosPorId;
            }
        }

        public List<Usuario> ObterTodos() 
        {
            List<Usuario> _repository = TabelaUsuario.Instancia;
            return _repository;
        }

        public void Remover()
        {
            throw new NotImplementedException();
        }
    }
}
