using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class BracketHasRoundsICollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BracketId",
                table: "Rounds",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rounds_BracketId",
                table: "Rounds",
                column: "BracketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rounds_Brackets_BracketId",
                table: "Rounds",
                column: "BracketId",
                principalTable: "Brackets",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rounds_Brackets_BracketId",
                table: "Rounds");

            migrationBuilder.DropIndex(
                name: "IX_Rounds_BracketId",
                table: "Rounds");

            migrationBuilder.DropColumn(
                name: "BracketId",
                table: "Rounds");
        }
    }
}
