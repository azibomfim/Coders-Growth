﻿using FluentMigrator;

namespace CodersGrowth.Dominio.Migracoes
{
    [Migration(2024062612290000)]

    public class _2024062612290000 : Migration
    {
        public override void Up()
        {
            Create.Table("Usuario")
                 .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                 .WithColumn("NomeDeUsuario").AsString().NotNullable()
                 .WithColumn("AdventureRank").AsInt32().Nullable();
        }

        public override void Down()
        {
            Delete.Table("Usuario");
        }
    }
}
