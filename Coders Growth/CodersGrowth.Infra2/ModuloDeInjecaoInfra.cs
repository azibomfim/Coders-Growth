using LinqToDB.AspNet;
using Microsoft.Extensions.DependencyInjection;
using LinqToDB;
using LinqToDB.AspNet.Logging;
using System.Configuration;


namespace CodersGrowth.Infra
{
    public static class ModuloDeInjecaoInfra
    {
        public static void ModuloDeInjecaoTeste(ServiceCollection Servicos)
        {
            const string stringDeConexao = "GenshinLibraryDB";

            Servicos.AddLinqToDBContext<ConexaoDados>((provider, options)
                => options
                .UseSqlServer(ConfigurationManager
                .ConnectionStrings[stringDeConexao].ConnectionString)
                .UseDefaultLogging(provider));
        }
    }
}
