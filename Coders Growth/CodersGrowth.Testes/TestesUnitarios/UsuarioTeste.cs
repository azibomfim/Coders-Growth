using CodersGrowth.Servicos.InterfaceServico;
using CodersGrowth.Servicos.Servicos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodersGrowth.Testes.TestesUnitarios
{
    public class UsuarioTeste : TesteBase
    {
        private IServicoUsuario servicoU;
        public UsuarioTeste()
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
    }
}
