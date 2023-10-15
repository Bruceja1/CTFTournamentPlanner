using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedRoundAndMatchupModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Rounds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ScoreA",
                table: "Matchups",
                type: "int",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScoreB",
                table: "Matchups",
                type: "int",
                maxLength: 100,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Rounds");

            migrationBuilder.DropColumn(
                name: "ScoreA",
                table: "Matchups");

            migrationBuilder.DropColumn(
                name: "ScoreB",
                table: "Matchups");
        }
    }
}
