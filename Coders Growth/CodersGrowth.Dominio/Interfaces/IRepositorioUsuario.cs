using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio;
using CodersGrowth.Dominio.Models;
using FluentValidation.Results;

namespace CodersGrowth.Dominio.Interfaces
{
    public interface IRepositorioUsuario
    {
        public List<Usuario> ObterTodos();
        public Usuario ObterPorId(int Uid);
        public Usuario Criar(Usuario usuario);
        public void Atualizar(Usuario usuario);
        public void Remover();
    }
}
