using Microsoft.EntityFrameworkCore.Migrations;

namespace kundeservice.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dbsporsmal",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(nullable: true),
                    Spors = table.Column<string>(nullable: true),
                    Svar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbsporsmal", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "dbsporsmal",
                columns: new[] { "ID", "Navn", "Spors", "Svar" },
                values: new object[] { 1, "Einar", "Test", "Svar" });

            migrationBuilder.InsertData(
                table: "dbsporsmal",
                columns: new[] { "ID", "Navn", "Spors", "Svar" },
                values: new object[] { 2, "Einar", "Test", "Svar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbsporsmal");
        }
    }
}
