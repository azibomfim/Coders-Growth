using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Testes
{
    public class TesteBase : IDisposable
    {
        protected ServiceProvider ProviderService;

        public TesteBase() {
        
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}