using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Infra;
using Microsoft.Extensions.DependencyInjection;
using Xunit.Microsoft.DependencyInjection;

namespace CodersGrowth.Testes
{
    public class TesteBase : IDisposable
    {
        protected ServiceProvider ServiceProvider;

        protected TesteBase() {
            var servicos = new ServiceCollection();
            ModuloDeInjecao.BindServices(servicos);

            ServiceProvider = servicos.BuildServiceProvider();
        }
        public void Dispose()
        {
            ServiceProvider.Dispose();
        }
    }
}