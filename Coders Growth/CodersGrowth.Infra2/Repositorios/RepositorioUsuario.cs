using System;
using System.Collections.Generic;
using System.Text;
using CodersGrowth.Dominio;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using LinqToDB;

namespace CodersGrowth.Infra.Repositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        public Usuario Criar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario Editar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario ObterPorId(int Uid)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(int Uid)
        {
            throw new NotImplementedException();
        }
    }
}
