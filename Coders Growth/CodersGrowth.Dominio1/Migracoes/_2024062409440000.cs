using FluentMigrator;

namespace CodersGrowth.Dominio.Migracoes
{
    [Migration(2024062409440000)]

    public class _2024062409440000 : Migration
    {
        public override void Up()
        {
            
            Create.Table("Personagem")
            .WithColumn("Id").AsInt64().PrimaryKey().Identity()
            .WithColumn("IdUsuario").AsInt64().ForeignKey()
			.WithColumn("NomePersonagem").AsString().Nullable()
			.WithColumn("Elemento").AsString().Nullable()
			.WithColumn("Arma").AsString().Nullable()
			.WithColumn("ConstelacaoLv").AsInt64().NotNullable()
			.WithColumn("Vida").AsInt64().NotNullable()
			.WithColumn("Ataque").AsInt64().NotNullable()
			.WithColumn("Defesa").AsInt64().NotNullable()
			.WithColumn("ProficienciaElemental").AsInt64().NotNullable()
			.WithColumn("TaxaCrit").AsDecimal().NotNullable()
			.WithColumn("DanoCrit").AsDecimal().NotNullable()
			.WithColumn("BonusCura").AsDecimal().NotNullable()
			.WithColumn("Escudo").AsDecimal().NotNullable()
			.WithColumn("BonusElemental").AsDecimal().NotNullable()
			.WithColumn("CriadoPorUsuario").AsBoolean().Nullable()
			.WithColumn("DataDeAquisicao").AsDateTime().NotNullable();

			Create.ForeignKey("fk_Usuario")
				.FromTable("Personagem").ForeignColumn("IdUsuario")
				.ToTable("Usuario").PrimaryColumn("Id");
        }
        public override void Down()
        {
            Delete.Table("Personagem");
        }
    }
}
