using CodersGrowth.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace CodersGrowth.Testes
{
    public class TesteServicoUsuario : TesteBase
    {
        private IServicoUsuario usuario;
        public TesteServicoUsuario()
        {
            var usuario = ServiceProvider.GetService<IServicoUsuario>();
        }

        [Fact]
        public void aaa() { }
    }
}