using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyTeamsMatchups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Matchups_MatchupId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_MatchupId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "MatchupId",
                table: "Teams");

            migrationBuilder.CreateTable(
                name: "MatchupTeam",
                columns: table => new
                {
                    MatchupsId = table.Column<int>(type: "int", nullable: false),
                    TeamsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchupTeam", x => new { x.MatchupsId, x.TeamsId });
                    table.ForeignKey(
                        name: "FK_MatchupTeam_Matchups_MatchupsId",
                        column: x => x.MatchupsId,
                        principalTable: "Matchups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchupTeam_Teams_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchupTeam_TeamsId",
                table: "MatchupTeam",
                column: "TeamsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchupTeam");

            migrationBuilder.AddColumn<int>(
                name: "MatchupId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_MatchupId",
                table: "Teams",
                column: "MatchupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Matchups_MatchupId",
                table: "Teams",
                column: "MatchupId",
                principalTable: "Matchups",
                principalColumn: "Id");
        }
    }
}
