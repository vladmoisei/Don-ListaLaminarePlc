using Microsoft.EntityFrameworkCore.Migrations;

namespace ItroducereDateCuptor.Migrations
{
    public partial class ChangeModelNormalizareToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Normalizare",
                table: "Blums",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Normalizare",
                table: "Blums",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}
