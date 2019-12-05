using Microsoft.EntityFrameworkCore.Migrations;

namespace ItroducereDateCuptor.Migrations
{
    public partial class AddNewDataToModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Lungime",
                table: "Blums",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Normalizare",
                table: "Blums",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sectiune",
                table: "Blums",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lungime",
                table: "Blums");

            migrationBuilder.DropColumn(
                name: "Normalizare",
                table: "Blums");

            migrationBuilder.DropColumn(
                name: "Sectiune",
                table: "Blums");
        }
    }
}
