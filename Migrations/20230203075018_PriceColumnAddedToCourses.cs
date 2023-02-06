using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrontToBack2.Migrations
{
    public partial class PriceColumnAddedToCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "courses");
        }
    }
}
