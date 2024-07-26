using CodersGrowth.Dominio.Interfaces;
using CodersGrowth.Infra;
using CodersGrowth.Infra.Repositorios;
using CodersGrowth.Servicos;
using CodersGrowth.Servicos.Validacoes;
using LinqToDB.AspNet;
using LinqToDB.AspNet.Logging;
using LinqToDB;
using CodersGrowth.Web;
using CodersGrowth.Servicos.Servicos;
using FluentMigrator.Runner;
using FluentValidation;
using ConfigurationManager = System.Configuration.ConfigurationManager;
using CodersGrowth.Dominio.Migracoes;
using CodersGrowth.Dominio.Models;

var builder = WebApplication.CreateBuilder(args);

var appSettings = ConfigurationManager.AppSettings;
string StringConexao = ConfigurationManager.ConnectionStrings["GenshinLibraryDB"].ConnectionString;

builder.Services.AddFluentMigratorCore()
    .ConfigureRunner(rb => rb
        .AddSqlServer()
        .WithGlobalConnectionString(StringConexao)
        .ScanIn(typeof(_2024062612290000).Assembly).For.Migrations())
    .AddLogging(lb => lb.AddFluentMigratorConsole());


builder.Services.AddLinqToDBContext<ConexaoDados>((provider, options) =>
        options
            .UseSqlServer(StringConexao)
            .UseDefaultLogging(provider))
    .AddScoped<IRepositorioPersonagem, RepositorioPersonagem>()
    .AddScoped<IRepositorioUsuario, RepositorioUsuario>()
    .AddScoped<IValidator<Personagem>, ValidacaoPersonagem>()
    .AddScoped<IValidator<Usuario>, ValidacaoUsuario>()
    .AddScoped<ServicoPersonagem>()
    .AddScoped<ServicoUsuario>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
    runner.MigrateUp();
}
app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();

app.Run();
