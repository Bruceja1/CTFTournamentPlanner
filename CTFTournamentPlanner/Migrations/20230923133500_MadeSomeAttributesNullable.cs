using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTFTournamentPlanner.Migrations
{
    /// <inheritdoc />
    public partial class MadeSomeAttributesNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Teams");

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Matchups",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Matchups");

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Teams",
                type: "int",
                nullable: true);
        }
    }
}
