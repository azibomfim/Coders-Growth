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
        private IServicoUsuario servicoU;
        public TesteServicoUsuario()
        {
            var servicoU = ServiceProvider.GetService<IServicoUsuario>();
        }

        [Fact]
        public void aaa() { }
    }
}