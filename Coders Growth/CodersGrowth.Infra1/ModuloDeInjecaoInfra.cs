using LinqToDB.AspNet;
using Microsoft.Extensions.DependencyInjection;
using LinqToDB;
using LinqToDB.AspNet.Logging;
using System.Configuration;


namespace CodersGrowth.Infra
{
    public static class ModuloDeInjecaoInfra
    {
        private static string _stringDeConexao = "GenshinLibraryDB";
        public static void ModuloDeInjecaoTeste(ServiceCollection Servicos)
        {
            Servicos.AddLinqToDBContext<ConexaoDados>((provider, options)
                => options
                .UseSqlServer(ConfigurationManager
                .ConnectionStrings[_stringDeConexao].ConnectionString)
                .UseDefaultLogging(provider));
        }
    }
}