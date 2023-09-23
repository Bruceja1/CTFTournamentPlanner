using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTFTournamentPlanner.Migrations
{
    /// <inheritdoc />
    public partial class AddedBoolValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BracketName",
                table: "Teams");

            migrationBuilder.AddColumn<bool>(
                name: "IsWinner",
                table: "Teams",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsModerator",
                table: "Player",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsTeamLeader",
                table: "Player",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsWinner",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "IsModerator",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "IsTeamLeader",
                table: "Player");

            migrationBuilder.AddColumn<string>(
                name: "BracketName",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
