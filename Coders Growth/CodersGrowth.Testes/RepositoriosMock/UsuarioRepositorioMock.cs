using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Infra;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Testes.Singleton;

namespace CodersGrowth.Testes.RepositoriosMock
{
    public class UsuarioRepositorioMock : IRepositorioUsuario
    {
        //private readonly List<Usuario> _repository = TabelaUsuario.Instancia;
        public void Atualizar()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar() 
        {  
            throw new NotImplementedException();
        }

        public Usuario ObterPorId(int Uid)
        {
            throw new NotImplementedException();
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
