using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserSeeding2 : Migration
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
                    { "1fdd3f83-83d6-4609-b6b6-2fe306c0c4aa", 0, "0cd2ffe2-7e7d-4fce-818d-c6f61d070969", "dominus@example.com", false, false, false, null, null, null, "AQAAAAIAAYagAAAAEGbVUpMEIWVvjA+HwmEVsCa7rx/Gq1dOfdTDVUMH0+83FsPpOzbYG1Q/61YU8A8SxQ==", null, false, "e337d4cd-1c68-45af-a1e9-51319075f82a", 2, false, "Dominus" },
                    { "372725a0-0897-4dd1-a77a-0f9cce9ca7ad", 0, "aaa70f3d-a02b-4767-acc1-09aae25ea094", "admin@example.com", false, false, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEBDC8iWP48pF+Q9as1ZmYTE/89VM9Q92hiIfeDntnkPPiWsEEXMkruvwGEJZb5L3sw==", null, false, "af0ccd03-30a5-4e7d-bae9-524e7505c1b2", null, false, "Admin" },
                    { "98e00c95-6d93-4044-a059-fe0310ce2801", 0, "68af7b5c-beab-4bee-b48f-d3df6014e248", "octane@example.com", false, true, false, null, null, null, "AQAAAAIAAYagAAAAELxGlSzXH/mh5Y3g8vwnxR7+3KU0ocwdM8u4dteF4TeDhGJdewe58FqVCZxnPvjAVg==", null, false, "f5193299-f18e-4f13-a39f-f1a6f62e3a46", 2, false, "Octane" },
                    { "a22c5f22-9946-4dda-a681-5464f99205c2", 0, "2e519543-4e4a-4cd9-90fb-4988b230a0f8", "bruce@example.com", false, true, false, null, null, null, "AQAAAAIAAYagAAAAEI4ICFBQbstoHhqew9vHGDJTLJ87VrgTgpeZSh/neb1vozMgAHRlbjyNDdf8MAxR7Q==", null, false, "5e7fcf5b-f595-4a8a-b5d6-50eaf4d2aa08", 1, false, "Bruce" },
                    { "c7758829-ae69-44cd-85fc-1f9f5d385828", 0, "d0be7c73-c7ee-4768-890d-34b0e37f899f", "breakout@example.com", false, false, false, null, null, null, "AQAAAAIAAYagAAAAEL4Qo/6eo6gKaL7mFHdzWte0/wMScGTDpAUDchJDzZ4qT69ErEAWvAjsUwY6Z7brww==", null, false, "0310ae28-6ff8-404b-bdd6-d645165236e0", 2, false, "Breakout" },
                    { "e658b545-8663-48cd-a626-90415c2be47e", 0, "6cd620ea-1dc3-439b-a5e7-50f74282fb9c", "bruce2@example.com", false, false, false, null, null, null, "AQAAAAIAAYagAAAAEKzp5GP34lITwPDogltcMFx9JHvx3wDG7k5PTzfutY9NDoOjltfEn+jP0qViXyLG3Q==", null, false, "30f2116e-ebfd-40b6-9de7-9ef2e093a70d", 1, false, "Bruce2" }
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
                keyValue: "1fdd3f83-83d6-4609-b6b6-2fe306c0c4aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98e00c95-6d93-4044-a059-fe0310ce2801");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a22c5f22-9946-4dda-a681-5464f99205c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7758829-ae69-44cd-85fc-1f9f5d385828");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e658b545-8663-48cd-a626-90415c2be47e");

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
