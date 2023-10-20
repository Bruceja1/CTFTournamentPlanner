using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserSeeding4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e0f4adb4-8c3d-45ff-a814-62c3c873fba5", "372725a0-0897-4dd1-a77a-0f9cce9ca7ad" });

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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0f4adb4-8c3d-45ff-a814-62c3c873fba5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "1fd80bdd-8ffc-42ec-8d88-5bb2fb5ef599", 0, "103ea004-df86-4a97-892e-50ef8f323349", "dominus@example.com", false, false, false, null, null, null, "AQAAAAIAAYagAAAAEFfO+smMkOLeBb6jXaYLxicv0XOkkVMlr9tpPI3S3+3HcrJWwXF69XViiiovzIRrtw==", null, false, "4d35ed7d-86b3-464c-9f7e-b252d98eaaac", 2, false, "Dominus" },
                    { "23ac7e40-815c-4e13-be35-d86aa12b6885", 0, "666a5d74-bedc-40c6-9eda-a8f16c8d3789", "breakout@example.com", false, false, false, null, null, null, "AQAAAAIAAYagAAAAEM2k7+dk/p0PDjvJVTXI+McaLiJ4jK6G7C+U8X+yvyacUfYChCr1we+XnAo3tU6oJQ==", null, false, "e19cd1d8-ce2b-4374-8197-31fda8bcb68b", 2, false, "Breakout" },
                    { "372725a0-0897-4dd1-a77a-0f9cce9ca7ad", 0, "96d7a7a9-4514-4d3b-a7f1-e6ff07315804", "admin@example.com", false, false, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEOIb3H1UBdUWQOQkCz6q+KDy4O9o0j8yPz2KWGYdyrk7pCD1lDoqnEkVrZ2M2JYfgg==", null, false, "29c5b718-a749-4f80-a8b6-1718cf7e841f", null, false, "admin" },
                    { "7ad91e70-ace2-4941-bd40-dc22081d0b0b", 0, "bb9644a2-a440-427e-86ab-45815fb5bb4b", "octane@example.com", false, true, false, null, null, null, "AQAAAAIAAYagAAAAEA/WdNgWZh4ujNZYyky2iJq8Gq/boSCsjj0DewGKVg6ZPvnIz2oQIxu5zAxC2VNiWQ==", null, false, "157046a0-e030-498a-b95a-5038192f30bf", 2, false, "Octane" },
                    { "a247298c-9361-43ae-9c41-f978ad61b9f8", 0, "c54de00f-5ede-4d20-b91b-74a84b7743ee", "bruce2@example.com", false, false, false, null, null, null, "AQAAAAIAAYagAAAAEKGuGeZ6PNl6rAZOJSEOWO+eboiMxcMKX3eFynU1Pv1G+F87ZQthMKbx19HB9LA2cA==", null, false, "f2850062-93ce-446a-b932-dfc3a4c29202", 1, false, "Bruce2" },
                    { "b69991be-85c6-4c5a-a451-27238d2136dd", 0, "a2626ea2-2d02-4945-9e0f-a19c919cdc1f", "bruce@example.com", false, true, false, null, null, null, "AQAAAAIAAYagAAAAEEIILSSNoyrz7KTF3IgGpmSXHThU03Wqx9wDyKiJC/APh59hf7fm56zblYkDDtYWjw==", null, false, "b031b0d9-52b0-45ce-9ad0-7eae551f9ebf", 1, false, "Bruce" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e0f4adb4-8c3d-45ff-a814-62c3c873fba5", "372725a0-0897-4dd1-a77a-0f9cce9ca7ad" });
        }
    }
}
