using Microsoft.EntityFrameworkCore.Migrations;

namespace BannerArt.Migrations
{
    public partial class NewDisplayStyle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Flag",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Flag");
        }
    }
}
