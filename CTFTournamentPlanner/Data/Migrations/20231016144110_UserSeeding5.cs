using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserSeeding5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0f4adb4-8c3d-45ff-a814-62c3c873fba5", null, "Administrators", "ADMINISTRATORS" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "32c518f4-a582-4693-9bb4-ba183fb35970", 0, "19ca5756-cea3-4715-b444-862c19c0153b", "octane@example.com", false, true, false, null, "OCTANE@EXAMPLE.COM", "OCTANE@EXAMPLE.COM", "AQAAAAIAAYagAAAAENwXzuIFvpxe09pyS3L5D8p445i4y5sB9CKxJPuIUcqRcQ6jQnHnTXOnjM8s0OTjSg==", null, false, "be16b465-0601-4bbb-bfbb-a8f36f83d072", 2, false, "octane@example.com" },
                    { "372725a0-0897-4dd1-a77a-0f9cce9ca7ad", 0, "f5fbc722-2cf7-43a9-914c-7690ee88c542", "admin@example.com", false, false, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAED8tcncpaV22l8iE1inu5R/6lr+Wwq2/XivPdQCa0mJ5Y/c3wMYqYlWvZbtuvp1nXQ==", null, false, "de5f0159-a6a4-4643-8b87-29e341dfb3e9", null, false, "admin@example.com" },
                    { "62326871-6356-48f9-a46a-39a5cef2b474", 0, "7f5c511b-8544-4b7e-8783-03f43aab214e", "breakout@example.com", false, false, false, null, "BREAKOUT@EXAMPLE.COM", "BREAKOUT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEInCkdtHxQUqJDcjTsT1TKvuj+ggRe/Qs2b3Tl8IdHtNfv9B3LTfjAaXbZKpb4ox2A==", null, false, "6e58c92e-d61d-47cd-b1aa-3ffa22b54514", 2, false, "breakout@example.com" },
                    { "7fd3d929-a335-4e2f-92f4-734113630c04", 0, "7b0acece-8879-49d6-b8da-a1ebff5c4293", "bruce2@example.com", false, false, false, null, "BRUCE2@EXAMPLE.COM", "BRUCE2@EXAMPLE.COM", "AQAAAAIAAYagAAAAELIllkZO02E/BpEUFj6hBYwBanNV6lR0VBQTLZFOdhKe9FCOD34SG48gses9BeaWpQ==", null, false, "28ee1b0d-765c-465f-8c19-9f3b1761f5c0", 1, false, "bruce2@example.com" },
                    { "9d451b8d-5504-4762-a61f-afb7cc5612e5", 0, "af1cadba-c0f7-4082-bee3-dd0e7d4a89bf", "bruce@example.com", false, true, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIf/zYH9fZ+AieRmV3sWcdwqDemw0l+RZXaOc/mwevI5GY1IqNnT9SpQywHso654+w==", null, false, "c284c517-c4e4-4fe1-b20a-7ae5cb7fe03e", 1, false, "bruce@example.com" },
                    { "bb3b8c4f-dfbf-41a1-883a-008682272e90", 0, "467b6230-cd68-4707-8374-dff68670051b", "dominus@example.com", false, false, false, null, "DOMINUS@EXAMPLE.COM", "DOMINUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEA/OBfD5eRe8Kp6LVM9Gti8B4AsWp3RxpOrIxS4k8KK3DnGNJhme/+eN5DUFWzsS1A==", null, false, "b01b4b67-6cf7-4d63-8994-d08b56668610", 2, false, "dominus@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e0f4adb4-8c3d-45ff-a814-62c3c873fba5", "372725a0-0897-4dd1-a77a-0f9cce9ca7ad" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e0f4adb4-8c3d-45ff-a814-62c3c873fba5", "372725a0-0897-4dd1-a77a-0f9cce9ca7ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32c518f4-a582-4693-9bb4-ba183fb35970");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62326871-6356-48f9-a46a-39a5cef2b474");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fd3d929-a335-4e2f-92f4-734113630c04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d451b8d-5504-4762-a61f-afb7cc5612e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb3b8c4f-dfbf-41a1-883a-008682272e90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0f4adb4-8c3d-45ff-a814-62c3c873fba5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad");
        }
    }
}
