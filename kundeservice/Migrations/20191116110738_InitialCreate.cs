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
                    ask = table.Column<string>(nullable: true),
                    ans = table.Column<string>(nullable: true),
                    kat = table.Column<string>(nullable: true),
                    pRat = table.Column<int>(nullable: false),
                    nRat = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbsporsmal", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "innsendt",
                columns: table => new
                {
                    IID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    epost = table.Column<string>(nullable: true),
                    ask = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_innsendt", x => x.IID);
                });

            migrationBuilder.InsertData(
                table: "dbsporsmal",
                columns: new[] { "ID", "ans", "ask", "kat", "nRat", "pRat" },
                values: new object[,]
                {
                    { 1, "For å endre billetten din, må du først avbestille den og så kjøpe ny billett til avgangen du skal reise med.", "Hvordan kan jeg endre eller avbestille billetten?", "Billett", 0, 0 },
                    { 2, "Du kan ikke kreve refusjon av billettprisen dersom du ble varslet om forsinkelser på 30 minutter/én time før billetten ble kjøpt.", "Toget mitt var forsinket – hvilken erstatning har jeg krav på og hvordan søker jeg om dette?", "Refundering", 0, 0 },
                    { 3, "I situasjoner der du må ta i bruk alternativ transport eller får andre utgifter i forbindelse med forsinkelse eller kansellering av tog, kan du få refundert hele eller deler av utleggene. Dette må gjøres skriftlig med vedlagt dokumentasjon innen tre måneder etter hendelsen.", "Kan jeg få erstatning for merkostnader ved forsinkelse?", "Refundering", 0, 0 },
                    { 4, "Ta kontakt med oss dersom du mener at du urettmessig har fått et kontrollgebyr, eller om du vil utsette betalingen av et gebyr. Du har 14 dagers klagerett fra utstedelsesdato.", "Jeg har fått kontrollgebyr på toget– hvordan klager jeg på denne?", "Refundering", 0, 0 },
                    { 5, "Alle billetter må refunderes før avgang, du vil ikke ha krav på refusjon etter togavgangen dersom du ikke rekker toget ditt.", "Jeg rakk ikke toget. Kan jeg få refundert billetten?", "Refundering", 0, 0 },
                    { 6, "Du kan slette og legge til betalingskort ved å logge inn på vy.no og gå til «Min profil». I appen går du til «Profil», så velger du «Betaling».", "Hvordan endrer jeg betalingskortet tilknyttet Vy-profilen min?", "Billett", 0, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbsporsmal");

            migrationBuilder.DropTable(
                name: "innsendt");
        }
    }
}
