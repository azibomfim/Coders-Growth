using CodersGrowth.Dominio.Models;
using LinqToDB;
using LinqToDB.Data;

namespace CodersGrowth.Infra
{
    public class ConexaoDados : DataConnection
    {
        public ConexaoDados(DataOptions <ConexaoDados> options) : base(options.Options) { }
        public ITable<Personagem> TabelaPersonagem => this.GetTable<Personagem>();
        public ITable<Usuario> TabelaUsuario => this.GetTable<Usuario>();
    }
}
