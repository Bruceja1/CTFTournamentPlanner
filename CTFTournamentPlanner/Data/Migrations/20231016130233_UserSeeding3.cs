using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserSeeding3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "96d7a7a9-4514-4d3b-a7f1-e6ff07315804", "AQAAAAIAAYagAAAAEOIb3H1UBdUWQOQkCz6q+KDy4O9o0j8yPz2KWGYdyrk7pCD1lDoqnEkVrZ2M2JYfgg==", "29c5b718-a749-4f80-a8b6-1718cf7e841f", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1fd80bdd-8ffc-42ec-8d88-5bb2fb5ef599", 0, "103ea004-df86-4a97-892e-50ef8f323349", "dominus@example.com", false, false, false, null, null, null, "AQAAAAIAAYagAAAAEFfO+smMkOLeBb6jXaYLxicv0XOkkVMlr9tpPI3S3+3HcrJWwXF69XViiiovzIRrtw==", null, false, "4d35ed7d-86b3-464c-9f7e-b252d98eaaac", 2, false, "Dominus" },
                    { "23ac7e40-815c-4e13-be35-d86aa12b6885", 0, "666a5d74-bedc-40c6-9eda-a8f16c8d3789", "breakout@example.com", false, false, false, null, null, null, "AQAAAAIAAYagAAAAEM2k7+dk/p0PDjvJVTXI+McaLiJ4jK6G7C+U8X+yvyacUfYChCr1we+XnAo3tU6oJQ==", null, false, "e19cd1d8-ce2b-4374-8197-31fda8bcb68b", 2, false, "Breakout" },
                    { "7ad91e70-ace2-4941-bd40-dc22081d0b0b", 0, "bb9644a2-a440-427e-86ab-45815fb5bb4b", "octane@example.com", false, true, false, null, null, null, "AQAAAAIAAYagAAAAEA/WdNgWZh4ujNZYyky2iJq8Gq/boSCsjj0DewGKVg6ZPvnIz2oQIxu5zAxC2VNiWQ==", null, false, "157046a0-e030-498a-b95a-5038192f30bf", 2, false, "Octane" },
                    { "a247298c-9361-43ae-9c41-f978ad61b9f8", 0, "c54de00f-5ede-4d20-b91b-74a84b7743ee", "bruce2@example.com", false, false, false, null, null, null, "AQAAAAIAAYagAAAAEKGuGeZ6PNl6rAZOJSEOWO+eboiMxcMKX3eFynU1Pv1G+F87ZQthMKbx19HB9LA2cA==", null, false, "f2850062-93ce-446a-b932-dfc3a4c29202", 1, false, "Bruce2" },
                    { "b69991be-85c6-4c5a-a451-27238d2136dd", 0, "a2626ea2-2d02-4945-9e0f-a19c919cdc1f", "bruce@example.com", false, true, false, null, null, null, "AQAAAAIAAYagAAAAEEIILSSNoyrz7KTF3IgGpmSXHThU03Wqx9wDyKiJC/APh59hf7fm56zblYkDDtYWjw==", null, false, "b031b0d9-52b0-45ce-9ad0-7eae551f9ebf", 1, false, "Bruce" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1fd80bdd-8ffc-42ec-8d88-5bb2fb5ef599");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23ac7e40-815c-4e13-be35-d86aa12b6885");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ad91e70-ace2-4941-bd40-dc22081d0b0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a247298c-9361-43ae-9c41-f978ad61b9f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b69991be-85c6-4c5a-a451-27238d2136dd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "aaa70f3d-a02b-4767-acc1-09aae25ea094", "AQAAAAIAAYagAAAAEBDC8iWP48pF+Q9as1ZmYTE/89VM9Q92hiIfeDntnkPPiWsEEXMkruvwGEJZb5L3sw==", "af0ccd03-30a5-4e7d-bae9-524e7505c1b2", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1fdd3f83-83d6-4609-b6b6-2fe306c0c4aa", 0, "0cd2ffe2-7e7d-4fce-818d-c6f61d070969", "dominus@example.com", false, false, false, null, null, null, "AQAAAAIAAYagAAAAEGbVUpMEIWVvjA+HwmEVsCa7rx/Gq1dOfdTDVUMH0+83FsPpOzbYG1Q/61YU8A8SxQ==", null, false, "e337d4cd-1c68-45af-a1e9-51319075f82a", 2, false, "Dominus" },
                    { "98e00c95-6d93-4044-a059-fe0310ce2801", 0, "68af7b5c-beab-4bee-b48f-d3df6014e248", "octane@example.com", false, true, false, null, null, null, "AQAAAAIAAYagAAAAELxGlSzXH/mh5Y3g8vwnxR7+3KU0ocwdM8u4dteF4TeDhGJdewe58FqVCZxnPvjAVg==", null, false, "f5193299-f18e-4f13-a39f-f1a6f62e3a46", 2, false, "Octane" },
                    { "a22c5f22-9946-4dda-a681-5464f99205c2", 0, "2e519543-4e4a-4cd9-90fb-4988b230a0f8", "bruce@example.com", false, true, false, null, null, null, "AQAAAAIAAYagAAAAEI4ICFBQbstoHhqew9vHGDJTLJ87VrgTgpeZSh/neb1vozMgAHRlbjyNDdf8MAxR7Q==", null, false, "5e7fcf5b-f595-4a8a-b5d6-50eaf4d2aa08", 1, false, "Bruce" },
                    { "c7758829-ae69-44cd-85fc-1f9f5d385828", 0, "d0be7c73-c7ee-4768-890d-34b0e37f899f", "breakout@example.com", false, false, false, null, null, null, "AQAAAAIAAYagAAAAEL4Qo/6eo6gKaL7mFHdzWte0/wMScGTDpAUDchJDzZ4qT69ErEAWvAjsUwY6Z7brww==", null, false, "0310ae28-6ff8-404b-bdd6-d645165236e0", 2, false, "Breakout" },
                    { "e658b545-8663-48cd-a626-90415c2be47e", 0, "6cd620ea-1dc3-439b-a5e7-50f74282fb9c", "bruce2@example.com", false, false, false, null, null, null, "AQAAAAIAAYagAAAAEKzp5GP34lITwPDogltcMFx9JHvx3wDG7k5PTzfutY9NDoOjltfEn+jP0qViXyLG3Q==", null, false, "30f2116e-ebfd-40b6-9de7-9ef2e093a70d", 1, false, "Bruce2" }
                });
        }
    }
}
