using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDatabaseSeeding5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "21936976-6a82-4854-9380-9fec015fd04e", 0, "1cec83f0-3915-4ef9-95ea-2acd9e2701af", "octane@example.com", false, true, false, null, null, null, null, null, false, "72d3b52e-f56d-4b2b-8476-f26c45442321", 2, false, "Octane" },
                    { "ba689e1a-d781-4467-97a7-e4579d8ac5b6", 0, "c20e8ff3-01a9-4ba0-800f-13bdf0d66c26", "bruce@example.com", false, true, false, null, null, null, null, null, false, "e332e21f-b922-4090-af44-560a5a93448f", 1, false, "Bruce" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21936976-6a82-4854-9380-9fec015fd04e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba689e1a-d781-4467-97a7-e4579d8ac5b6");
        }
    }
}
