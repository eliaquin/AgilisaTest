using Microsoft.EntityFrameworkCore.Migrations;

namespace AgilisaTest.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterTests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterTests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetailsTests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterTestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailsTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailsTests_MasterTests_MasterTestId",
                        column: x => x.MasterTestId,
                        principalTable: "MasterTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailsTests_MasterTestId",
                table: "DetailsTests",
                column: "MasterTestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailsTests");

            migrationBuilder.DropTable(
                name: "MasterTests");
        }
    }
}
