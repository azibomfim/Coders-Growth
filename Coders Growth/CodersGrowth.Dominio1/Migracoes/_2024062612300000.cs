using FluentMigrator;

namespace CodersGrowth.Dominio.Migracoes
{
    [Migration(2024062612300000)]

    public class _2024062612300000 : Migration
    {
        public override void Up()
        {
            
            Create.Table("Personagem")
            .WithColumn("Id").AsInt64().PrimaryKey().Identity()
            .WithColumn("IdUsuario").AsInt64().ForeignKey().Nullable()
			.WithColumn("NomePersonagem").AsInt64().NotNullable()
			.WithColumn("Elemento").AsInt64().NotNullable()
			.WithColumn("Arma").AsInt64().NotNullable()
			.WithColumn("ConstelacaoLv").AsInt64().Nullable()
			.WithColumn("Vida").AsInt64().Nullable()
			.WithColumn("Ataque").AsInt64().Nullable()
			.WithColumn("Defesa").AsInt64().Nullable()
			.WithColumn("RecargaDeEnergia").AsInt64().Nullable()
			.WithColumn("ProficienciaElemental").AsInt64().Nullable()
			.WithColumn("TaxaCrit").AsDecimal().Nullable()
			.WithColumn("DanoCrit").AsDecimal().Nullable()
			.WithColumn("BonusCura").AsDecimal().Nullable()
			.WithColumn("Escudo").AsDecimal().Nullable()
			.WithColumn("BonusElemental").AsDecimal().Nullable()
			.WithColumn("CriadoPorUsuario").AsBoolean().NotNullable()
			.WithColumn("DataDeAquisicao").AsDateTime().Nullable();

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
