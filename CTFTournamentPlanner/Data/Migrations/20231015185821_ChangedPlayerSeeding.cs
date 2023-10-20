using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangedPlayerSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21936976-6a82-4854-9380-9fec015fd04e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba689e1a-d781-4467-97a7-e4579d8ac5b6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05835837-b6a7-448e-862c-fc388c00fbb8", 0, "9de7fff7-2ac1-402b-8e99-9f5b6744bc78", "bruce@example.com", true, true, false, null, null, null, "AQAAAAIAAYagAAAAEHtneuNHtsMzUz5q203IagikIvYnkam3CNHAr0wmIZZNEIeJ7oC+joYA6V/fSwGZxQ==", null, false, "e6245882-40da-4b39-a179-6de184106070", 1, false, "Bruce" },
                    { "93a6b25f-eef3-45d2-84b0-16758046abea", 0, "a2a6b72a-8233-4320-ad76-e4ba899cd6f9", "octane@example.com", true, true, false, null, null, null, "AQAAAAIAAYagAAAAELPYfu2I2abcUkMUcUutat77Qsxt+I1vgev4J/N7ARJmMbl/+/+VjUjuX5K4yFIiIA==", null, false, "75f4ae5b-bead-4108-90e1-46a20a966fdc", 2, false, "Octane" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05835837-b6a7-448e-862c-fc388c00fbb8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93a6b25f-eef3-45d2-84b0-16758046abea");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "21936976-6a82-4854-9380-9fec015fd04e", 0, "1cec83f0-3915-4ef9-95ea-2acd9e2701af", "octane@example.com", false, true, false, null, null, null, null, null, false, "72d3b52e-f56d-4b2b-8476-f26c45442321", 2, false, "Octane" },
                    { "ba689e1a-d781-4467-97a7-e4579d8ac5b6", 0, "c20e8ff3-01a9-4ba0-800f-13bdf0d66c26", "bruce@example.com", false, true, false, null, null, null, null, null, false, "e332e21f-b922-4090-af44-560a5a93448f", 1, false, "Bruce" }
                });
        }
    }
}
