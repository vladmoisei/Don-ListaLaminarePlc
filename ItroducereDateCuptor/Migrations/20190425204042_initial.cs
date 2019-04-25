using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ItroducereDateCuptor.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Diametru = table.Column<int>(nullable: false),
                    Sarja = table.Column<string>(maxLength: 8, nullable: true),
                    Furnizor = table.Column<string>(maxLength: 2, nullable: true),
                    Calitate = table.Column<string>(maxLength: 10, nullable: true),
                    IsDatAfara = table.Column<bool>(nullable: false),
                    IsRetur = table.Column<bool>(nullable: false),
                    IsRebut = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blums", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blums");
        }
    }
}
