using CodersGrowth.Dominio.Models;
using LinqToDB;
using LinqToDB.Data;

namespace CodersGrowth.Infra
{
    public class ConexaoDados : DataConnection
    {
        const string stringDeConexao = "GenshinLibraryDB";
        public ConexaoDados() : base(stringDeConexao) { }
        public ITable<Personagem> TabelaPersonagem => this.GetTable<Personagem>();
        public ITable<Usuario> TabelaUsuario => this.GetTable<Usuario>();
    }
}
