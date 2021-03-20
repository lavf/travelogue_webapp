using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelogueWebApp.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trip",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripArrivalYear = table.Column<int>(nullable: false),
                    TripArrivalMonth = table.Column<int>(nullable: false),
                    TripArrivalDay = table.Column<int>(nullable: false),
                    TripDepartureYear = table.Column<int>(nullable: false),
                    TripDepartureMonth = table.Column<int>(nullable: false),
                    TripDepartureDay = table.Column<int>(nullable: false),
                    TripCountry = table.Column<string>(nullable: true),
                    TripCity = table.Column<string>(nullable: true),
                    TripTransport = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trip", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trip");
        }
    }
}
