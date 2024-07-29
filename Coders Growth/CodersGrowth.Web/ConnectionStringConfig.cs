namespace CodersGrowth.Web
{
    public class ConnectionStringConfig
    {

        public static string RetornaStringConexao()
        {
            return System.Configuration.ConfigurationManager
                .ConnectionStrings["GenshinLibraryDB"]
                .ConnectionString;
        }
    }
}
