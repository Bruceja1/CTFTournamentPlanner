using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class manytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Brackets_BracketId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_BracketId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "BracketId",
                table: "Teams");

            migrationBuilder.CreateTable(
                name: "BracketTeam",
                columns: table => new
                {
                    BracketsId = table.Column<int>(type: "int", nullable: false),
                    TeamsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BracketTeam", x => new { x.BracketsId, x.TeamsId });
                    table.ForeignKey(
                        name: "FK_BracketTeam_Brackets_BracketsId",
                        column: x => x.BracketsId,
                        principalTable: "Brackets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BracketTeam_Teams_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BracketTeam_TeamsId",
                table: "BracketTeam",
                column: "TeamsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BracketTeam");

            migrationBuilder.AddColumn<int>(
                name: "BracketId",
                table: "Teams",
                type: "int",
                nullable: true);

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
    }
}
