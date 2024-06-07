using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.InterfaceServico;

namespace CodersGrowth.Servicos.Servicos
{
    public class ServicoUsuario: IServicoUsuario
    {
        public ServicoUsuario(IRepositorioUsuario UsuarioRepositorioMock)
        {
            _usuariorepositorio = UsuarioRepositorioMock;
        }
        private IRepositorioUsuario _usuariorepositorio;
        public List<Usuario> ObterTodos()
        {
            return _usuariorepositorio.ObterTodos();
        }
        public Usuario ObterPorId(int Uid)
        {
            return _usuariorepositorio.ObterPorId(Uid) ?? throw new Exception("usuario nao encontrado");
        }
    }
}
