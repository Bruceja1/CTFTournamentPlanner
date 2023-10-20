using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56e556ef-c1a0-46d2-8b95-899663536bf7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67db9434-b342-4fd5-9dde-befa2da1f4d1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "56e556ef-c1a0-46d2-8b95-899663536bf7", 0, "e103e209-aa44-4775-af1c-b78fc46801a7", "bruce@example.com", true, true, false, null, null, null, "AQAAAAIAAYagAAAAENxsp4f7rdOj0XMuKWF9ORD7Q1wfRl/RH3T8Br/QKG514Hu9M4AYh8Ov4yR782F+2w==", null, false, "284e80bc-e95f-4cd4-bcf5-e05644da0928", 1, false, "Bruce" },
                    { "67db9434-b342-4fd5-9dde-befa2da1f4d1", 0, "f64a142c-f04c-43ba-952d-7f26b0f7ac34", "octane@example.com", true, true, false, null, null, null, "AQAAAAIAAYagAAAAEDgqK8GeXTUvBk0b2zDXompUPNmaOlx3Ems1GryhfK3mDrvKtvxP0812rhA04AfvRg==", null, false, "23e702d7-dcfd-4752-8cb1-b06264ce35a1", 2, false, "Octane" }
                });
        }
    }
}
