using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class SeedDatabas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Makes (Name) VALUES('Make1')");
            migrationBuilder.Sql("insert into Makes (Name) VALUES('Make2')");
            migrationBuilder.Sql("insert into Makes (Name) VALUES('Make3')");
            migrationBuilder.Sql("insert into Makes (Name) VALUES('Make4')");
            migrationBuilder.Sql("insert into Makes (Name) VALUES('Make5')");

            migrationBuilder.Sql("insert into Models (Name, MakeID) VALUES('Make1-ModelA', (SELECT ID FROM Makes WHERE Name='Make1'))");
            migrationBuilder.Sql("insert into Models (Name, MakeID) VALUES('Make1-ModelB', (SELECT ID FROM Makes WHERE Name='Make1'))");
            migrationBuilder.Sql("insert into Models (Name, MakeID) VALUES('Make1-ModelC', (SELECT ID FROM Makes WHERE Name='Make1'))");

            migrationBuilder.Sql("insert into Models (Name, MakeID) VALUES('Make2-ModelA', (SELECT ID FROM Makes WHERE Name='Make2'))");
            migrationBuilder.Sql("insert into Models (Name, MakeID) VALUES('Make2-ModelB', (SELECT ID FROM Makes WHERE Name='Make2'))");
            migrationBuilder.Sql("insert into Models (Name, MakeID) VALUES('Make2-ModelC', (SELECT ID FROM Makes WHERE Name='Make2'))");

            migrationBuilder.Sql("insert into Models (Name, MakeID) VALUES('Make3-ModelA', (SELECT ID FROM Makes WHERE Name='Make3'))");
            migrationBuilder.Sql("insert into Models (Name, MakeID) VALUES('Make3-ModelB', (SELECT ID FROM Makes WHERE Name='Make3'))");
            migrationBuilder.Sql("insert into Models (Name, MakeID) VALUES('Make3-ModelC', (SELECT ID FROM Makes WHERE Name='Make3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes WHERE Name IN('Make', 'Make2', 'MAke3')");
        }
    }
}
