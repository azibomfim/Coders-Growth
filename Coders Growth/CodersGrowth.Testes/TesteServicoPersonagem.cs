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
        private IServicoPersonagem personagem;
        public TesteServicoPersonagem()
        {
            var personagem = ServiceProvider.GetService<IServicoPersonagem>();
        }
        [Fact]
        public void aaaa() { }
        
    }
}