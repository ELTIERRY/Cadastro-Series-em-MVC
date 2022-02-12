using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroSeriesMVC.Migrations
{
    public partial class AtualizaçãoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusSerie",
                table: "Serie");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Serie",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Serie");

            migrationBuilder.AddColumn<bool>(
                name: "StatusSerie",
                table: "Serie",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
