using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrontToBack2.Migrations
{
    public partial class createAboutTableWithCountAndQuoteColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentsCount = table.Column<int>(type: "int", nullable: false),
                    CoursesCount = table.Column<int>(type: "int", nullable: false),
                    EventsCount = table.Column<int>(type: "int", nullable: false),
                    TrainersCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quotes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "abouts");

            migrationBuilder.DropTable(
                name: "quotes");
        }
    }
}
