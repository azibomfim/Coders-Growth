using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Servicos.Servicos;
using CodersGrowth.Testes.RepositoriosMock;
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
        }
    }
}