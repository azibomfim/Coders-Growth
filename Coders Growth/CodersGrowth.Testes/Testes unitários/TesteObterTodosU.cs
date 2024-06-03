using CodersGrowth.Servicos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodersGrowth.Testes.Testes_unitários
{
    public class TesteObterTodosU : TesteBase
    {
        private IServicoUsuario servicoU;
        public TesteObterTodosU()
        {
            servicoU = ServiceProvider.GetService<IServicoUsuario>();
        }

        [Fact]
        public void ObterTodos() { }
    }
}
