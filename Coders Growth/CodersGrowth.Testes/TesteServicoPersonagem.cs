using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Servicos;
using Microsoft.Extensions.DependencyInjection;


namespace CodersGrowth.Testes
{
    public class TesteServicoPersonagem : TesteBase
    {
        private IServicoPersonagem servicoP;
        public TesteServicoPersonagem()
        {
            var servicoP = ServiceProvider.GetService<IServicoPersonagem>();
        }
        [Fact]
        public void aaaa() { }
    }
}