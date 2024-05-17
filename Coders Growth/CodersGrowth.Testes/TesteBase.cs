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
        protected IServiceProvider ServiceProvider;
            this._ServicoPersonagem = serviceProvider.GetService<IServicoPersonagem>();
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
