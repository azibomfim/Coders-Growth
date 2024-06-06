using CodersGrowth.Servicos.InterfaceServico;
using CodersGrowth.Servicos.Servicos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Testes.TestesUnitarios
{
    public class TesteServicoUsuario : TesteBase
    {
        private IServicoUsuario servicoU;
        public TesteServicoUsuario()
        {
            servicoU = ServiceProvider.GetService<IServicoUsuario>();
        }

        [Fact]
        public void ObterTodos() 
        {
            var listaDeUsuarios = servicoU.ObterTodos();

            Assert.NotNull(listaDeUsuarios);
            Assert.Equal(5, listaDeUsuarios.Count);
        }
        [Fact]
        public void ObterPorId()
        {
            int Uid = 1;
            var usuariosPorId = servicoU.ObterPorId(Uid);

            Assert.NotNull(usuariosPorId);
            Assert.(1, usuariosPorId.Count);
        }
    }
}
