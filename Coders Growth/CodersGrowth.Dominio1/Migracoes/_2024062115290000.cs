using FluentMigrator;

namespace CodersGrowth.Dominio.Migracoes
{
    [Migration(2024062115290000)]

    public class _2024062115290000 : Migration
    {
        public override void Up()
        {
            Create.Table("Usuario")
                 .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                 .WithColumn("NomeDeUsuario").AsString().NotNullable()
                 .WithColumn("Senha").AsInt64().NotNullable()
                 .WithColumn("AdventureRank").AsInt64().Nullable();
        }

        public override void Down()
        {
            Delete.Table("Usuario");
        }
    }
}
