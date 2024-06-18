using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.Servicos;
using CodersGrowth.Servicos.Validacoes;
using CodersGrowth.Testes.RepositoriosMock;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

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