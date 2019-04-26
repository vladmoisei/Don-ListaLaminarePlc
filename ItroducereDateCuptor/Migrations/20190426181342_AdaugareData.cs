using Microsoft.EntityFrameworkCore.Migrations;

namespace ItroducereDateCuptor.Migrations
{
    public partial class AdaugareData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DataOraLaminare",
                table: "Blums",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataOraLaminare",
                table: "Blums");
        }
    }
}
