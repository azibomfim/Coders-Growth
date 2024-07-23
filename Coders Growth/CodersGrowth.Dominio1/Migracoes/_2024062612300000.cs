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
			.WithColumn("NomePersonagem").AsInt32().NotNullable()
			.WithColumn("Elemento").AsInt32().NotNullable()
			.WithColumn("Arma").AsInt32().NotNullable()
			.WithColumn("ConstelacaoLv").AsInt32().Nullable()
			.WithColumn("Vida").AsInt32().Nullable()
			.WithColumn("Ataque").AsInt32().Nullable()
			.WithColumn("Defesa").AsInt32().Nullable()
			.WithColumn("RecargaDeEnergia").AsInt32().Nullable()
			.WithColumn("ProficienciaElemental").AsInt32().Nullable()
			.WithColumn("TaxaCrit").AsDecimal().Nullable()
			.WithColumn("DanoCrit").AsDecimal().Nullable()
			.WithColumn("BonusCura").AsDecimal().Nullable()
			.WithColumn("Escudo").AsDecimal().Nullable()
			.WithColumn("BonusElemental").AsDecimal().Nullable()
			.WithColumn("CriadoPorUsuario").AsBoolean().NotNullable()
			.WithColumn("NomeUsuario").AsString().Nullable()
            .WithColumn("IdUsuario").AsInt32().ForeignKey().Nullable()
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
