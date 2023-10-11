using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedBracketModel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BracketId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Brackets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brackets", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_BracketId",
                table: "Teams",
                column: "BracketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Brackets_BracketId",
                table: "Teams",
                column: "BracketId",
                principalTable: "Brackets",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Brackets_BracketId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "Brackets");

            migrationBuilder.DropIndex(
                name: "IX_Teams_BracketId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "BracketId",
                table: "Teams");
        }
    }
}
