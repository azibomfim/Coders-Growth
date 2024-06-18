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
using FluentValidation;
using CodersGrowth.Servicos.Validacoes;

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
            Servicos.AddScoped<IValidator<Personagem>, ValidacaoPersonagem>();
            Servicos.AddScoped<IValidator<Usuario>, ValidacaoUsuario>();
        }
    }
}