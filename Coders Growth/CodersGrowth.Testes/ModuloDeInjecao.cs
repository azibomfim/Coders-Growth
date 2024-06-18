<<<<<<< HEAD
﻿using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Servicos.Servicos;
using CodersGrowth.Testes.RepositoriosMock;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Dominio;
using CodersGrowth.Dominio.Interfaces;
using System.Security.Authentication.ExtendedProtection;
using Xunit.Microsoft.DependencyInjection;
>>>>>>> 8c6a9040d8b90c3deb152a27cbdf5640e20182b6
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
            Servicos.AddScoped<ServicoPersonagem>();
            Servicos.AddScoped<ServicoUsuario>();
            Servicos.AddScoped<IRepositorioPersonagem, PersonagemRepositorioMock>();
            Servicos.AddScoped<IRepositorioUsuario, UsuarioRepositorioMock>();
            Servicos.AddScoped<IValidator<Personagem>, ValidacaoPersonagem>();
            Servicos.AddScoped<IValidator<Usuario>, ValidacaoUsuario>();
        }
    }
}