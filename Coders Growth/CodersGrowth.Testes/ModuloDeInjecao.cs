using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Dominio;
using CodersGrowth.Servicos;
using System.Security.Authentication.ExtendedProtection;
using Xunit.Microsoft.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace CodersGrowth.Testes
{
    public class ModuloDeInjecao
    {
        public static ServiceCollection Servicos { get; private set; }
        public ModuloDeInjecao()
        {
            Servicos = new ServiceCollection();
            Servicos.AddScoped<IServicoPersonagem, ServicoPersonagem>();
            Servicos.AddScoped<IServicoUsuario, ServicoUsuario>();
        }

        public static ServiceProvider BuildServiceProvider()
        {
            return Servicos.BuildServiceProvider();
        }
    }
}