using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Infra;
using CodersGrowth.Dominio;
using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Testes
{
    public class UsuarioRepositorioMock : IUsuario
    {
        public UsuarioRepositorioMock() 
        {
            throw new NotImplementedException();
        }

        public string Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public string Cadastrar(Usuario usuario) 
        {  
            throw new NotImplementedException();
        }

        public Usuario ObterPorId(int Uid)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ObterTodos() 
        {
            List<Usuario> usuario = new List<Usuario>();
            return usuario;
        }

        public string Remover(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
