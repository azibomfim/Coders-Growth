using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Dominio;
using CodersGrowth.Dominio.Interfaces;
using System.Security.Authentication.ExtendedProtection;
using Xunit.Microsoft.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using CodersGrowth.Servicos.InterfaceServico;
using CodersGrowth.Servicos.Servicos;
using CodersGrowth.Testes.RepositoriosMock;

namespace CodersGrowth.Testes
{
    public class ModuloDeInjecao
    {
        public static void BindServices(IServiceCollection Servicos)
        {
            Servicos.AddScoped<IServicoPersonagem, ServicoPersonagem>();
            Servicos.AddScoped<IServicoUsuario, ServicoUsuario>();
            Servicos.AddScoped<IRepositorioPersonagem, PersonagemRepositorioMock>();
            Servicos.AddScoped<IRepositorioUsuario, UsuarioRepositorioMock>();
        }
    }
}