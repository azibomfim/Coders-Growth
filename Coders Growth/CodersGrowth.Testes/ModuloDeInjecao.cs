using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Dominio;
using CodersGrowth.Servicos;
using CodersGrowth.Infra;
using System.Security.Authentication.ExtendedProtection;
using Xunit.Microsoft.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace CodersGrowth.Testes
{
    public class ModuloDeInjecao
    {
        public static void BindServices(IServiceCollection Servicos)
        {
            Servicos.AddScoped<IServicoPersonagem, ServicoPersonagem>();
            Servicos.AddScoped<IServicoUsuario, ServicoUsuario>();
            Servicos.AddScoped<IPersonagem, PersonagemRepositorioMock>();
            Servicos.AddScoped<IUsuario, UsuarioRepositorioMock>();
        }
    }
}