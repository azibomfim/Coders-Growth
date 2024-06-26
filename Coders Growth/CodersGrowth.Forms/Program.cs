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

namespace CodersGrowth.Forms;

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
        ApplicationConfiguration.Initialize();
        var host = CriarHostBuilder().Build();
        var ServiceProvider = host.Services;
        Application.Run(ServiceProvider.GetRequiredService<Form1>());
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
               .AddScoped<IValidator, ValidacaoPersonagem>()
               .AddScoped<IValidator, ValidacaoUsuario>()
               .AddScoped<Form1>();
            });
    }

    private static ServiceProvider CriarServicos()
    {
        return new ServiceCollection()
        .AddFluentMigratorCore()
        .ConfigureRunner(rb => rb
            .AddSqlServer()
            .WithGlobalConnectionString("Data Source=DESKTOP-F7MOBD8\\SQLEXPRESS;Initial Catalog=CodersGrowth;User ID=sa;Password=sap@123;Trust Server Certificate=True")
            .ScanIn(typeof(_2024062612290000).Assembly).For.Migrations()
            .ScanIn(typeof(_2024062612300000).Assembly).For.Migrations())
         .AddLinqToDBContext<ConexaoDados>((provider, options)
                => options
                .UseSqlServer(ConfigurationManager
                .ConnectionStrings[_stringDeConexao].ConnectionString)
                .UseDefaultLogging(provider))
                .AddLogging(lb => lb.AddFluentMigratorConsole())
         .BuildServiceProvider(false); } 
    

    private static void AtualizarBancoDeDados(IServiceProvider serviceProvider)
    {
        var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
        runner.MigrateUp();
    }

}
