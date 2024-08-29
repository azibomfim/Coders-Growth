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
using Microsoft.Extensions.FileProviders;

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
builder.Services.AddDirectoryBrowser();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
    runner.MigrateUp();
}
app.UseHttpsRedirection();
app.UseStaticFiles(new StaticFileOptions { ServeUnknownFileTypes = true });

app.Use(async (context, next) =>
{
    if (context.Request.Path.StartsWithSegments("/i18n"))
    {
        var filePath = Path.Combine(builder.Environment.ContentRootPath, "wwwroot/app/i18n", context.Request.Path.Value.Substring(6));
        if (File.Exists(filePath))
        {
            await context.Response.SendFileAsync(filePath);
            return;
        }
    }
    await next();
});

app.UseFileServer(new FileServerOptions
{
    FileProvider = new PhysicalFileProvider(
            Path.Combine(builder.Environment.ContentRootPath, "wwwroot"))
});
app.UseRouting();
app.MapControllers();

app.Run();
