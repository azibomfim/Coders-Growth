using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Migracoes;
using CodersGrowth.Infra.Repositorios;
using CodersGrowth.Servicos.Servicos;
using CodersGrowth.Servicos.Validacoes;
using FluentMigrator.Runner;
using FluentValidation;
using LinqToDB.AspNet.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using LinqToDB;
using CodersGrowth.Infra;
using LinqToDB.AspNet;
using System.Configuration;
using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Forms1;

class Program
{
    private static string _stringDeConexao = "GenshinLibraryDB";
    [STAThread]
    static void Main(string[] args)
    {
        using (var serviceProvider = CriarServicos())
        using (var scope = serviceProvider.CreateScope())
        {
            AtualizarBancoDeDados(scope.ServiceProvider);
        }

        var host = CriarHostBuilder().Build();
        var ServiceProvider = host.Services;
        ApplicationConfiguration.Initialize();

        Application.Run(ServiceProvider.GetRequiredService<FormsTelaLogin>());
    }
    static IHostBuilder CriarHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddScoped<ServicoPersonagem>()
               .AddScoped<ServicoUsuario>()
               .AddScoped<IRepositorioPersonagem, RepositorioPersonagem>()
               .AddScoped<IRepositorioUsuario, RepositorioUsuario>()
               .AddScoped<IValidator<Personagem>, ValidacaoPersonagem>()
               .AddScoped<IValidator<Usuario>, ValidacaoUsuario>()
               .AddScoped<FormsTelaLogin>()
               .AddLinqToDBContext<ConexaoDados>((provider, options)
                        => options
                        .UseSqlServer(ConfigurationManager
                        .ConnectionStrings[_stringDeConexao].ConnectionString)
                        .UseDefaultLogging(provider));
            });
    }

    private static ServiceProvider CriarServicos()
    {
        var stringDeConexao = ConfigurationManager.ConnectionStrings[_stringDeConexao].ConnectionString;
        var colecao = new ServiceCollection();

        colecao.AddLinqToDBContext<ConexaoDados>((provider, options)
                        => options
                        .UseSqlServer(ConfigurationManager
                        .ConnectionStrings[_stringDeConexao].ConnectionString)
                        .UseDefaultLogging(provider));
        colecao.AddScoped<ServicoPersonagem>()
               .AddScoped<ServicoUsuario>();
        colecao.AddFluentMigratorCore()
            .ConfigureRunner(rb => rb
                .AddSqlServer()
                .WithGlobalConnectionString(stringDeConexao)
                .ScanIn(typeof(_2024062612290000).Assembly).For.Migrations())
            .AddLogging(lb => lb.AddFluentMigratorConsole());
         
        return colecao.BuildServiceProvider(false); 
    } 
    

    private static void AtualizarBancoDeDados(IServiceProvider serviceProvider)
    {
        var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
        runner.MigrateUp();
    }

}
