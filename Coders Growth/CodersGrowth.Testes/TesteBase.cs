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
        protected ServiceProvider ProviderService { get; private set; }

        public TesteBase() {
            var servicos = new ServiceCollection();
            servicos.AddSingleton<IPersonagemMock, PersonagemRepositorioMock>();
            servicos.AddSingleton<IUsuarioMock, UsuarioRepositorioMock>();

            ProviderService = servicos.BuildServiceProvider();
        }
        public void Dispose()
        {
            ProviderService.Dispose();
        }
    }
}