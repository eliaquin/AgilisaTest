using Microsoft.EntityFrameworkCore.Migrations;

namespace AgilisaTest.Data.Migrations
{
    public partial class addon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ListItem",
                table: "DetailsTests",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListItem",
                table: "DetailsTests");
        }
    }
}
