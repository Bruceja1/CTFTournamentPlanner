using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangedSeedingAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "56e556ef-c1a0-46d2-8b95-899663536bf7", 0, "e103e209-aa44-4775-af1c-b78fc46801a7", "bruce@example.com", true, true, false, null, null, null, "AQAAAAIAAYagAAAAENxsp4f7rdOj0XMuKWF9ORD7Q1wfRl/RH3T8Br/QKG514Hu9M4AYh8Ov4yR782F+2w==", null, false, "284e80bc-e95f-4cd4-bcf5-e05644da0928", 1, false, "Bruce" },
                    { "67db9434-b342-4fd5-9dde-befa2da1f4d1", 0, "f64a142c-f04c-43ba-952d-7f26b0f7ac34", "octane@example.com", true, true, false, null, null, null, "AQAAAAIAAYagAAAAEDgqK8GeXTUvBk0b2zDXompUPNmaOlx3Ems1GryhfK3mDrvKtvxP0812rhA04AfvRg==", null, false, "23e702d7-dcfd-4752-8cb1-b06264ce35a1", 2, false, "Octane" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56e556ef-c1a0-46d2-8b95-899663536bf7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67db9434-b342-4fd5-9dde-befa2da1f4d1");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05835837-b6a7-448e-862c-fc388c00fbb8", 0, "9de7fff7-2ac1-402b-8e99-9f5b6744bc78", "bruce@example.com", true, true, false, null, null, null, "AQAAAAIAAYagAAAAEHtneuNHtsMzUz5q203IagikIvYnkam3CNHAr0wmIZZNEIeJ7oC+joYA6V/fSwGZxQ==", null, false, "e6245882-40da-4b39-a179-6de184106070", 1, false, "Bruce" },
                    { "93a6b25f-eef3-45d2-84b0-16758046abea", 0, "a2a6b72a-8233-4320-ad76-e4ba899cd6f9", "octane@example.com", true, true, false, null, null, null, "AQAAAAIAAYagAAAAELPYfu2I2abcUkMUcUutat77Qsxt+I1vgev4J/N7ARJmMbl/+/+VjUjuX5K4yFIiIA==", null, false, "75f4ae5b-bead-4108-90e1-46a20a966fdc", 2, false, "Octane" }
                });
        }
    }
}
