using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Dominio.Migracoes;
using CodersGrowth.Infra;
using CodersGrowth.Infra.Repositorios;
using CodersGrowth.Servicos.Servicos;
using CodersGrowth.Servicos.Validacoes;
using FluentMigrator.Runner;
using FluentValidation;
using LinqToDB;
using LinqToDB.AspNet;
using LinqToDB.AspNet.Logging;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace CodersGrowth.Forms
{
    class Program
    {
        private static string _stringDeConexao = "GenshinLibraryDB";
        static void Main(string[] args)
        {
            using (var serviceProvider = CriarServicos())
            using (var scope = serviceProvider.CreateScope())
            {
                AtualizarBancoDeDados(scope.ServiceProvider);
            }
        }

        private static ServiceProvider CriarServicos()
        {
            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                .AddSqlServer()
                .WithGlobalConnectionString("Data Source=DESKTOP-F7MOBD8\\SQLEXPRESS;Initial Catalog=CodersGrowth;User ID=sa;Password=sap@123;Trust Server Certificate=True")
                .ScanIn(typeof(_2024062115290000).Assembly).For.Migrations())
                .AddScoped<ServicoPersonagem>()
                .AddScoped<ServicoUsuario>()
                .AddScoped<IRepositorioPersonagem, RepositorioPersonagem>()
                .AddScoped<IRepositorioUsuario, RepositorioUsuario>()
                .AddScoped<IValidator, ValidacaoPersonagem>()
                .AddScoped<IValidator, ValidacaoUsuario>()
                .AddLinqToDBContext<ConexaoDados>((provider, options)
                => options
                .UseSqlServer(ConfigurationManager
                .ConnectionStrings[_stringDeConexao].ConnectionString)
                .UseDefaultLogging(provider))
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }

        private static void AtualizarBancoDeDados(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();

            runner.MigrateUp();
        }
    }
}
