﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class SeedFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Features (Name) VALUES('Feature1')");
            migrationBuilder.Sql("insert into Features (Name) VALUES('Feature2')");
            migrationBuilder.Sql("insert into Features (Name) VALUES('Feature3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Features");
        }
    }
}
