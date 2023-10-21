using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class TroubleShootingMatchupEdit3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00249f70-799e-4dfa-8d15-9485d25d6cc6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0565e62b-8063-4d9d-ac83-39b7502d74ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09d6e204-011f-46ca-b685-72ad59b79b1b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17f5480e-17c2-4810-9983-c065148bd8f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a9922ec-f85c-4453-a445-cca91076641e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3302e424-3acc-4f1e-9db9-0d387cc31077");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e88e74e-1ab2-42e4-8e7d-b8575fef78a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ee4afef-2e4e-410a-b2d9-ffdd4ce95103");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "463bf195-204b-4c91-a160-46d5ae67970d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ec8d2e-16a7-4f69-9ec6-4d065fc99f03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f7f23a9-5542-4485-9a1e-d273a865af84");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71afefaf-e0a7-4f68-815c-8749ca6d2eec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "750d68fe-0e88-41c4-bdb8-45e3f32d8b0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "793972d6-548a-450a-b5b2-e04e7582f2c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b912671-be09-4859-b8de-7cdadeb28243");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c7c6203-51ae-419b-8690-438d2bcab662");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a804a448-64db-4229-a436-eaa16f537250");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a915374f-721f-4be1-95f6-fc0e5d3b799f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac024914-fa00-4dae-bb6d-ec7db00910a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac0ea0b3-e6b1-44a6-b279-7ac0573a0601");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae609a81-db19-4453-aa8b-16a85b4bf26d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b70841f6-3c30-4210-aedc-f7582171657c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bbd0301a-b0fa-453d-88df-eaa3b9a871c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd0b4020-1939-474d-aad8-97a350037e96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be3a08d1-c300-4625-82c3-cd211abf13c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c03ab19c-619c-41ac-ac13-b25515b6fe20");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c78d4929-c4c9-48d3-8940-3319f6f2f212");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5e7bd31-3a98-4da3-b2e9-bf119687a561");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ded386b5-7d81-40cf-9102-2e08a97e427c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2de1305-221a-44b9-a1dd-baecec678de4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e48f2aa9-947b-4108-bc72-4ef06aa3925b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5e257e1-7aa7-45af-98cc-60fbad7949d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8f7ca46-e8ea-4081-8f0b-129358bf8c3e");

            migrationBuilder.AddColumn<int>(
                name: "SelectedTeamAId",
                table: "Matchups",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SelectedTeamBId",
                table: "Matchups",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ee2fb87-11a6-470c-807a-c53e1fb0b2ea", "AQAAAAIAAYagAAAAEF2HOr0ygC/F0WiBmXtE35mLcgKRbtZ1CwotobQpFI0n6PbC/kDztJtwZvuHSX3CpQ==", "a6f5dde3-ad51-48d2-b1f0-c3200dc93962" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "03f82277-7b46-4b41-97b3-a19648e8b4a9", 0, "81c12042-150d-4843-a9d5-a7bbba871438", "venus@example.com", false, false, false, null, "VENUS@EXAMPLE.COM", "VENUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHFCYAOTVxmEskbpu5uMNb2pP9WglMxkYpG31q/1TFL0Yjh8Pivgwwfh98JBrhCvkA==", null, false, "68ff7f29-7090-48c2-8c76-12d590980daf", 1, false, "venus@example.com" },
                    { "0b35554d-add0-4139-ac33-dc6c2b7457a3", 0, "46878207-14b5-4507-818a-d66b3acd26f6", "bruce@example.com", false, true, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAN91ZRFSS7cnNoAhojEFT7yC0n/9AuomMeB2TBQYhul1V0SeeMUZOTMf8BQE4ynwA==", null, false, "ce182ffc-514d-4612-83b6-efed9e597e46", 4, false, "bruce@example.com" },
                    { "0b6ccf3f-fd14-4167-a127-4083f3fc7d60", 0, "e883fd22-6283-4f0b-9018-419dfd175bc1", "peer@example.com", false, false, false, null, "PEER@EXAMPLE.COM", "PEER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB9C1+9GvIiqaMcEoaGM/kx0G0ebgVI1B+d+XhyrsX7UGu8I4Jxsw3JQOL11HVQJPQ==", null, false, "9489a9e6-2058-4729-a677-03dd99347320", 6, false, "peer@example.com" },
                    { "189da35c-07ca-49ba-b334-9da8a210b6e7", 0, "afd191c9-ff71-43a3-a219-00ea438019af", "sinaasappel@example.com", false, false, false, null, "SINAASAPPEL@EXAMPLE.COM", "SINAASAPPEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMifrDifwiuoRKZyL8FKW9p6p5XD3xnatP+mNGxv4uIECuZPjn/2RS5IubY0MZahQA==", null, false, "a021269b-8cea-45bd-960b-73a50545c50e", 6, false, "sinaasappel@example.com" },
                    { "19c7d8cc-f6d6-4f87-ac79-84d5d9e5752e", 0, "6d2b7f0b-2bc6-4e4a-b356-c51b3e219b04", "waterzwijn@example.com", false, true, false, null, "WATERZWIJN@EXAMPLE.COM", "WATERZWIJN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGRLCIznMkYYqu8RvSHBrkjHq0/WquSLYM4UBF0UDY1/JsytWqqnk84r+fKfGfgZxA==", null, false, "384232f5-bd26-4fb6-a30b-a6abff149d4d", 7, false, "waterzwijn@example.com" },
                    { "20532cb1-7383-42ab-b846-5e82bf4bc4cf", 0, "4980aff4-5176-4b39-a9f4-c63f1280ba4b", "huiskat@example.com", false, false, false, null, "HUISKAT@EXAMPLE.COM", "HUISKAT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKD29DsE4Oq4EgeSww2JfAHrDcq94LSvOVPMVRmAJt02ce1zBOOsOCBQMPig+mZRSQ==", null, false, "03483a10-89be-4b0f-b837-e810ad94afd2", 7, false, "huiskat@example.com" },
                    { "28b9693a-fc09-4c80-ab6e-c414f7c801f6", 0, "fe3085ea-5810-4cbf-8b74-c7bf1178bdb7", "aarde@example.com", false, true, false, null, "AARDE@EXAMPLE.COM", "AARDE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI6VwiP+/q4rk8+DxfSGqvj19DpC8Mkpe76HiAnl55eh8fR3yyV52ZXLX9zTqs9Peg==", null, false, "04701579-f9f9-4867-a356-acec88a02dbe", 1, false, "aarde@example.com" },
                    { "2997e423-568c-4da8-b664-501fb008799a", 0, "d57bb1c4-e03b-4965-8944-38693c5dfa36", "mcqueen@example.com", false, true, false, null, "MCQUEEN@EXAMPLE.COM", "MCQUEEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO67cqvWHlqW/K6//jFKoDjcV/UDh6uGwhCOAC6guVTjx44nZazL6YZlu8Q2BCrxag==", null, false, "8ddea585-07ed-44ba-8c7f-cab92e1d068a", 5, false, "mcqueen@example.com" },
                    { "3d6990f5-e8f2-460a-8951-c09dae102ee7", 0, "adac8a88-b872-4b7a-8165-f39621d66bdf", "kiwi@example.com", false, false, false, null, "KIWI@EXAMPLE.COM", "KIWI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMHE6Eb6EuW3VdPkSzMAGcW7tBQoaWzGDQ/pbPnapr6kKMy+4mZa1gacx4Rj3R3tNw==", null, false, "307a0779-28ef-459c-99cf-43c10359fb20", 6, false, "kiwi@example.com" },
                    { "47b38808-9b1c-41be-9930-9054b96d7af7", 0, "73925466-36f5-4eca-936a-b207fb678948", "fennec@example.com", false, false, false, null, "FENNEC@EXAMPLE.COM", "FENNEC@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMqPBeiGFPNltNlo40UvFlTYbaeFojdX6SLmxmlgb8DZlE9R/zYEzdggIEP8hnf5Sw==", null, false, "46d0cc82-a794-4a34-ad56-e81d273c077a", 2, false, "fennec@example.com" },
                    { "4d34100e-f703-4ea3-a2d9-019b6f3f36cc", 0, "d6ca97f0-0d65-4c91-8ca1-bb091be20b0c", "appel@example.com", false, false, false, null, "APPEL@EXAMPLE.COM", "APPEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGCilxzufoh5Ak9qMjOjq3XDgwfYYYPxd5iG3Pi+dTkju35hnq4EkYSsRtaE3N866Q==", null, false, "629974da-a634-4262-b42f-2bcba8d61fe0", 6, false, "appel@example.com" },
                    { "5751199c-6f4a-47d1-a485-05750d3ee739", 0, "2413e175-8bab-4fa2-bd72-a296afb2e666", "watermeloen@example.com", false, false, false, null, "WATERMELOEN@EXAMPLE.COM", "WATERMELOEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEpkkpk/eL39uDTvERiOebMZ4Pa5H19CceIp/6B+V7fGeMdHbW89zOziigbZTwG/Nw==", null, false, "10591a01-5a3b-4310-a4c7-0603a0b5f8ac", 6, false, "watermeloen@example.com" },
                    { "5845d038-1baf-4eb0-a825-45ee7d7e6aab", 0, "9c012efc-be5b-41f7-8f81-fdd6ae309d05", "mars@example.com", false, false, false, null, "MARS@EXAMPLE.COM", "MARS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAHxjLkfZSpupTWCshVwYEdJuK1ryuf5EdiZS98BRXa/kgi+vJ5legaOEpXeWEeEdQ==", null, false, "137cb173-7b3a-4007-85f8-6da61afffb6d", 1, false, "mars@example.com" },
                    { "5a8cb72f-fc51-4d90-89f5-99f4bfc346d5", 0, "dae7f9f2-29f8-45df-aa5c-28ca977dcdb1", "octane@example.com", false, true, false, null, "OCTANE@EXAMPLE.COM", "OCTANE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIAZXT3YIZcQsXaxUFAf1mrbZxJxoDK+50jsvs861Gdn8uvaXcHCPpzXo/6b6BtaTw==", null, false, "4436734f-fd82-4919-935f-cafa77857fa5", 2, false, "octane@example.com" },
                    { "5bbc77dd-8ea1-457f-b9ef-9193a8acc170", 0, "03675d12-5699-4e12-b9a0-be8c64933ba8", "citroen@example.com", false, false, false, null, "CITROEN@EXAMPLE.COM", "CITROEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAktunxvs3YK8CioIyOeTxUtuiy8Sr/54vDnXqBk8tvVACcSgjyJRiMW4Fm/mS19UA==", null, false, "024234e7-edbc-4e83-83ef-03a851272e01", 6, false, "citroen@example.com" },
                    { "5d3cc181-834a-48bd-a638-0b589a8a10f6", 0, "d0326133-5158-43cc-965b-dbd131f30a6a", "dominus@example.com", false, false, false, null, "DOMINUS@EXAMPLE.COM", "DOMINUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIAs0CzjLkRXSLWCLB9wr7a05qinQ6O2hEMfSGGpEhVY6O5YGiP/TxLsQBFnwjPnLA==", null, false, "3e31bd8b-a2cf-4253-bbfe-0ab63d3ba61f", 2, false, "dominus@example.com" },
                    { "64beef19-451e-4da6-bbbc-7428284df483", 0, "77275ca2-583a-44f2-a21b-0c9ecdc91754", "toyota@example.com", false, false, false, null, "TOYOTA@EXAMPLE.COM", "TOYOTA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKmzbDZgUi2OCp1vdgVYGowFFmzArKqoS1IJlrqU+OQVrie/F3rbq15xJvGI0awhaQ==", null, false, "3692c3e3-fee8-4e15-96f7-7b913aa44563", 3, false, "toyota@example.com" },
                    { "6524c312-d500-48c1-97ed-b72c0a207da5", 0, "44ebb5d8-a3d6-4077-8a9c-11fcbd690b4e", "uranus@example.com", false, false, false, null, "URANUS@EXAMPLE.COM", "URANUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDICmmRlyW9vCIe/Wsa0dZNf7CjMKmX+4kKp9wiafvjSoM4vJWXTTXAJj1GNV5U4sQ==", null, false, "6352a3c1-305a-4251-82d4-5c45277b3cde", 1, false, "uranus@example.com" },
                    { "698102e5-1bd2-41f7-988a-04d51c8cd1cc", 0, "1c0c66ab-85c5-4279-9b5c-e54c55ebc37c", "neptunes@example.com", false, false, false, null, "NEPTUNES@EXAMPLE.COM", "NEPTUNES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAYfZdCj+KCPB0h3yYyZ37gP47sIXqwG2WguQG187el1KP3uWYU7EFunTv6CYw9P0Q==", null, false, "c3d94050-6c09-45f5-b067-eb3d530f6423", 1, false, "neptunes@example.com" },
                    { "6e31a654-7892-4f7a-ab0a-296c4110211d", 0, "160f6f52-ce1c-4ef3-a1ec-b7931534f591", "saturnus@example.com", false, false, false, null, "SATURNUS@EXAMPLE.COM", "SATURNUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHBAHdw/mlkMp3xBIosE7ZixjaKgjcczl1JtbnkKTeFaECGr7JzH+LQBFI1sX6XzcQ==", null, false, "e4edfeaa-9a0a-4f7f-b3e4-96fe9cd3fd39", 1, false, "saturnus@example.com" },
                    { "82979166-b60c-41d6-8d9f-534bccc15f28", 0, "d73bd875-b3f2-46f9-9e5c-b5e20d0a36e8", "rusty@example.com", false, false, false, null, "RUSTY@EXAMPLE.COM", "RUSTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHe2HRYi165e6fcp4d0HaCxTHhGvMZv4ttoTDUSb63JtlLtM6laxl0plbpdFdhO5DQ==", null, false, "8c48f636-7f74-4a4f-a8cf-9d08aac2a02f", 5, false, "rusty@example.com" },
                    { "8a691660-ed75-4837-a7b9-9b772f774cd5", 0, "37cfbd94-fccb-4906-a348-3de4cc26f67b", "volkswagen@example.com", false, false, false, null, "VOLKSWAGEN@EXAMPLE.COM", "VOLKSWAGEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMNAO0pNtMqnNx8zeGU3GFlYjuIwYe/E2AD7pU6gZvslf3dOqA55PoAWOTu1DwjAQg==", null, false, "1bdd84d9-b87d-49ca-a24b-74fe331fa862", 3, false, "volkswagen@example.com" },
                    { "8ad109ab-0b17-453f-a1c8-33873ad18b08", 0, "42e8bb56-1393-4334-93c2-34437e483a48", "mercurius@example.com", false, false, false, null, "MERCURIUS@EXAMPLE.COM", "MERCURIUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPFr3AuPf7BtGmuwoqwMAvW+sH5g18LhaBzYz4egH2n9z75QTCwyLjnWwWHX3D/j8w==", null, false, "1a12a32d-f553-444b-bcc3-6e4e96c2b599", 1, false, "mercurius@example.com" },
                    { "8ae65576-2651-4025-a66e-96e5e5a842f1", 0, "a537acf0-69f3-4646-9ed4-b5ced284b322", "mercedes@example.com", false, false, false, null, "MERCEDES@EXAMPLE.COM", "MERCEDES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDBktLJx6UGEtKiIRo5YI5qNnWTo+s2uJxcwhF3mxSxizwVKs4Nyr5ARWl8G411wHw==", null, false, "14270037-04cf-43be-b416-a7e22a48026c", 3, false, "mercedes@example.com" },
                    { "8f3d77e7-3570-41a7-9f50-962ac816908e", 0, "0063a7c0-bf52-4fbc-93da-d2751cd47c5f", "banaan@example.com", false, true, false, null, "BANAAN@EXAMPLE.COM", "BANAAN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFD8CsY+qQDo3x8G+oXIYHpC90/WT4kj8lI7mrZCSTE49CILhsocLmM10sMLPW16hQ==", null, false, "5959bc4f-8836-4bdb-83bc-13d49c3a5cf8", 6, false, "banaan@example.com" },
                    { "8f7b415e-65e7-412b-9333-0c8b3c86095c", 0, "5884871e-4ea6-4d7a-b870-720095dd05bb", "breakout@example.com", false, false, false, null, "BREAKOUT@EXAMPLE.COM", "BREAKOUT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIQkftvAuQIEyHeIU6rrcvVDjY4fpp7Q9H+76DQ7mxWTzqwrkZNIHMR4nxn1rC2u+w==", null, false, "fa800a8b-dbc2-47f6-982d-7ac1c5c1ed4f", 2, false, "breakout@example.com" },
                    { "981993a3-fd7a-4630-985b-bde584485cf5", 0, "99bf5ded-0735-4c1e-850f-d196ae72f694", "jupiter@example.com", false, false, false, null, "JUPITER@EXAMPLE.COM", "JUPITER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO/+LktX3gzoPVdnWMWFAqGHCksBZ0wi0A2oCv31FVWqPQpm2zFeRlNaAaw0sekNtA==", null, false, "71822140-1eb3-4148-b1e3-87ee4b5006ed", 1, false, "jupiter@example.com" },
                    { "b19e4af6-f6c0-4244-8bc7-7ad7ffd8846b", 0, "7856ace4-c4df-4061-8033-30d986521ad4", "avocado@example.com", false, false, false, null, "AVOCADO@EXAMPLE.COM", "AVOCADO@EXAMPLE.COM", "AQAAAAIAAYagAAAAELsDOQi3xXYVClqRwfxX/tWpWM8RBww3M8Lb/kzUjBEKdGdS65sarnSALPgo6Qn3Ww==", null, false, "0572db9a-7d63-4653-827e-869048df1797", 6, false, "avocado@example.com" },
                    { "b498a0bc-07a5-48c2-bceb-2ba9c31991e2", 0, "c5353d88-dda1-4b07-a76f-e614ee644c90", "hyena@example.com", false, false, false, null, "HYENA@EXAMPLE.COM", "HYENA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBcVv3/0ZdOMxVnSyWaFNfgHA8GBG8x35ft5PgjWFA0Z/lN+8gTr1XmmwbiRLNKi0g==", null, false, "efc58bcc-a9f6-4278-9cb6-07bb558b3848", 7, false, "hyena@example.com" },
                    { "d689d0d4-cc9e-4469-a286-81337a085dba", 0, "2e6ae9a9-c4c5-466f-b640-baf40b4cd738", "dusty@example.com", false, false, false, null, "DUSTY@EXAMPLE.COM", "DUSTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPbkXyQWrN3/vbg/nB0eFF/mTefl/gxaP4iWhulF494ppVb2HxTIArnTfEcJrxUdIQ==", null, false, "f4c1738e-ff90-4749-bc69-660a0a39e59a", 5, false, "dusty@example.com" },
                    { "f15336e0-c646-4b6a-8b9c-37730222ac3e", 0, "d4be4b13-3840-42ba-a81e-646eef745eae", "mack@example.com", false, false, false, null, "MACK@EXAMPLE.COM", "MACK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP13RwGF2IEfGO8J5kGp8tb78HZ0imHtWpaLmq2TqlpayMdOHY/sp1RsI4LU7H65xg==", null, false, "ad89ece9-d4a2-4a27-8d90-88bebe085883", 5, false, "mack@example.com" },
                    { "f226411e-b877-472f-b44a-9500791719c3", 0, "ae7d9fc0-834b-46b1-acc2-4a4dfeaaca40", "volvo@example.com", false, true, false, null, "VOLVO@EXAMPLE.COM", "VOLVO@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAZ8FI3k1pjQL9THH1jrVBJ6xVUIIB0dWHI7OZ43DdieAhcRJFG0kFmhBJJlKEkLMQ==", null, false, "ca0b7903-b46a-47f8-9424-82f430c1b7db", 3, false, "volvo@example.com" },
                    { "fcdec7bd-6df1-4e13-9e3d-3ac62bb49928", 0, "1676c3af-7f89-4179-a3c2-f394ee8e8f86", "ferrari@example.com", false, false, false, null, "FERRARI@EXAMPLE.COM", "FERRARI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFz65semUvUcdQVGhIvYN9cOC7zRKJIs//Ny5ckLtXx9yD0K74gViBK4X9u2CATeKw==", null, false, "2a163730-3b97-4dca-8cd5-3f9ee9a06c47", 3, false, "ferrari@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03f82277-7b46-4b41-97b3-a19648e8b4a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b35554d-add0-4139-ac33-dc6c2b7457a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b6ccf3f-fd14-4167-a127-4083f3fc7d60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "189da35c-07ca-49ba-b334-9da8a210b6e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19c7d8cc-f6d6-4f87-ac79-84d5d9e5752e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20532cb1-7383-42ab-b846-5e82bf4bc4cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28b9693a-fc09-4c80-ab6e-c414f7c801f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2997e423-568c-4da8-b664-501fb008799a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d6990f5-e8f2-460a-8951-c09dae102ee7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47b38808-9b1c-41be-9930-9054b96d7af7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d34100e-f703-4ea3-a2d9-019b6f3f36cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5751199c-6f4a-47d1-a485-05750d3ee739");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5845d038-1baf-4eb0-a825-45ee7d7e6aab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a8cb72f-fc51-4d90-89f5-99f4bfc346d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bbc77dd-8ea1-457f-b9ef-9193a8acc170");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d3cc181-834a-48bd-a638-0b589a8a10f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64beef19-451e-4da6-bbbc-7428284df483");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6524c312-d500-48c1-97ed-b72c0a207da5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "698102e5-1bd2-41f7-988a-04d51c8cd1cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e31a654-7892-4f7a-ab0a-296c4110211d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82979166-b60c-41d6-8d9f-534bccc15f28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a691660-ed75-4837-a7b9-9b772f774cd5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ad109ab-0b17-453f-a1c8-33873ad18b08");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ae65576-2651-4025-a66e-96e5e5a842f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f3d77e7-3570-41a7-9f50-962ac816908e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f7b415e-65e7-412b-9333-0c8b3c86095c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "981993a3-fd7a-4630-985b-bde584485cf5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b19e4af6-f6c0-4244-8bc7-7ad7ffd8846b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b498a0bc-07a5-48c2-bceb-2ba9c31991e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d689d0d4-cc9e-4469-a286-81337a085dba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f15336e0-c646-4b6a-8b9c-37730222ac3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f226411e-b877-472f-b44a-9500791719c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcdec7bd-6df1-4e13-9e3d-3ac62bb49928");

            migrationBuilder.DropColumn(
                name: "SelectedTeamAId",
                table: "Matchups");

            migrationBuilder.DropColumn(
                name: "SelectedTeamBId",
                table: "Matchups");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae8b504c-8165-4598-8061-f60a2034ea23", "AQAAAAIAAYagAAAAEK1I1wC4aMlpvEJZecqHW8Oc3RSmMGuFnfkuv7L9iljONcCNb47FjGCFt7RYQgdIiQ==", "817949b9-65c6-438f-b91f-c1361c8366fc" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00249f70-799e-4dfa-8d15-9485d25d6cc6", 0, "e6c26860-5fe7-43a0-9221-f5be45604a1e", "hyena@example.com", false, false, false, null, "HYENA@EXAMPLE.COM", "HYENA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGuDz0deMSc0/Lo0ObE+r1KTCaFjswByBqOFkCFK7sDr4G/qUphGl/pM+JVQrILW+g==", null, false, "277cfea3-ae12-411f-94fa-97934713337d", 7, false, "hyena@example.com" },
                    { "0565e62b-8063-4d9d-ac83-39b7502d74ed", 0, "5165d5e3-4d51-4b58-8ece-55eccb5b492c", "bruce@example.com", false, true, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEVUeq8RSyYE8ZUNtHM0ASwE3cuWZO+BYNg8uj282wmUJyKHcjC40x+gXcRq7A5rrg==", null, false, "5ee504c5-a666-470c-a936-46c83f79b8be", 4, false, "bruce@example.com" },
                    { "09d6e204-011f-46ca-b685-72ad59b79b1b", 0, "e4322a68-a5e1-4bec-ae42-6cf13e9e4278", "volkswagen@example.com", false, false, false, null, "VOLKSWAGEN@EXAMPLE.COM", "VOLKSWAGEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE+GnpODX1LwQeJjfWqtmsTQoH80jcAqkeTsAd1hhe0buBNRGZzv4yPLe/4D+E2vKg==", null, false, "bb13de09-bd8c-46b5-bff4-9496707a88c8", 3, false, "volkswagen@example.com" },
                    { "17f5480e-17c2-4810-9983-c065148bd8f9", 0, "20451d79-b1e3-446f-9335-da3601131b6b", "huiskat@example.com", false, false, false, null, "HUISKAT@EXAMPLE.COM", "HUISKAT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGb92lvAIRQVuOOxt8MhvlbDxg3hQC038T3PmUE8ilr5/aS32EovDpF1AQ1sTtVIkg==", null, false, "c6b04f51-0d76-44d1-b9ba-341ffd94a1b9", 7, false, "huiskat@example.com" },
                    { "1a9922ec-f85c-4453-a445-cca91076641e", 0, "e3443186-8bc3-47b0-a314-128656372ff3", "waterzwijn@example.com", false, true, false, null, "WATERZWIJN@EXAMPLE.COM", "WATERZWIJN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEFKUMACdFwAKKAPiGUIVqthJtb8IwQUSXlvvQMi+Fwuiqwmu5zCO+EpbnRLnSjThA==", null, false, "1fede5db-9cfe-476d-8faf-2125fe5a278b", 7, false, "waterzwijn@example.com" },
                    { "3302e424-3acc-4f1e-9db9-0d387cc31077", 0, "27f89f03-c6ee-4148-b879-c7a9aed4dfcf", "mercedes@example.com", false, false, false, null, "MERCEDES@EXAMPLE.COM", "MERCEDES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHQQQsKEXCo1Ca+DXGKST89M+9SDfzbckv4qio8X+B0Y7pzASFlL38YTAgM5ozyClw==", null, false, "9ca13263-6238-434b-b50f-9253b86a84f5", 3, false, "mercedes@example.com" },
                    { "3e88e74e-1ab2-42e4-8e7d-b8575fef78a8", 0, "fbd1e151-aa26-438a-aebb-f253b12ea33e", "mercurius@example.com", false, false, false, null, "MERCURIUS@EXAMPLE.COM", "MERCURIUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAENRI3UBLEn7uozQtfq8hce7y/N3v1p0+EzGZcOgck3C4EDE90siOUJDHRKeLs2x02w==", null, false, "574fa834-8273-462f-ae90-b4bacb72e7fd", 1, false, "mercurius@example.com" },
                    { "3ee4afef-2e4e-410a-b2d9-ffdd4ce95103", 0, "225a519e-8d2a-423b-b3ef-61a11778e041", "appel@example.com", false, false, false, null, "APPEL@EXAMPLE.COM", "APPEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDKsOO/dATuA5bgDU0mva6Qzd4oGzdW9gP9HrwiseG5uzKCQUVfessvw2cgNyG/xeA==", null, false, "01957118-4918-489f-8546-99b1e7186c91", 6, false, "appel@example.com" },
                    { "463bf195-204b-4c91-a160-46d5ae67970d", 0, "9a917351-5609-449b-a0e7-1d8c806a4761", "peer@example.com", false, false, false, null, "PEER@EXAMPLE.COM", "PEER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPxRc9n03IwAskO9VU+WD8w8Q+2K55cRxfOrXdbylhl5D5k8rfGxJ6h9T8fw5oPTEw==", null, false, "fe992055-24ab-4f27-9a2c-3102a81c6008", 6, false, "peer@example.com" },
                    { "47ec8d2e-16a7-4f69-9ec6-4d065fc99f03", 0, "c69bbb0c-7a7e-42ad-99fc-046e48e36832", "banaan@example.com", false, true, false, null, "BANAAN@EXAMPLE.COM", "BANAAN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEEacAEcaFuBMdQrmyRoQiAVshPNjlwemwho2ViLERE+/Oqus9JAirgLWdNvK66AvA==", null, false, "b6715c4a-9fdc-43d5-9b61-536364fe27f1", 6, false, "banaan@example.com" },
                    { "5f7f23a9-5542-4485-9a1e-d273a865af84", 0, "830e96db-c919-4e00-bac4-3e57ad49e33d", "mack@example.com", false, false, false, null, "MACK@EXAMPLE.COM", "MACK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEG3/pldMFfO3dN7bpAKZfUJd7583VEJ+WTHLEZHdh8bfWLQdoIhzfs8RfDmi3HDYnA==", null, false, "6351395d-4334-4148-ad30-55a2bc818a47", 5, false, "mack@example.com" },
                    { "71afefaf-e0a7-4f68-815c-8749ca6d2eec", 0, "43f5a63a-0604-45e8-8938-12be2df16e8c", "citroen@example.com", false, false, false, null, "CITROEN@EXAMPLE.COM", "CITROEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPHMPI0npWykrtGy0fxxdVvhdsavCrrWjeIvhtpQn5+iQfjYv7dLI8HJw/eKhuxgSg==", null, false, "9fc695db-f528-4933-9c2a-7154fb45759a", 6, false, "citroen@example.com" },
                    { "750d68fe-0e88-41c4-bdb8-45e3f32d8b0b", 0, "9a329aac-c27b-4f38-b49b-e3b122615c35", "dusty@example.com", false, false, false, null, "DUSTY@EXAMPLE.COM", "DUSTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAEpMh65qnYQ3SK4BV/CpabhFsNqA+8BFLPHTNphbbKkaLZPsOY4u+jfOa2meR0hXw==", null, false, "45e79172-ec51-49bf-8aa9-a99a854aa283", 5, false, "dusty@example.com" },
                    { "793972d6-548a-450a-b5b2-e04e7582f2c0", 0, "c78f76ff-d490-46ee-ae64-e8cc1f15b0a6", "dominus@example.com", false, false, false, null, "DOMINUS@EXAMPLE.COM", "DOMINUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIQ2aSHo08k+kXS63NnXWImpwE3drWyg4N4zRt+3pUGkicNj0FyGB1ZMWDXoATLuKg==", null, false, "018ef6bd-545c-45ae-9333-5a1e1fc591a3", 2, false, "dominus@example.com" },
                    { "7b912671-be09-4859-b8de-7cdadeb28243", 0, "d55e8340-2694-4034-af1a-8a5f3eb03468", "mars@example.com", false, false, false, null, "MARS@EXAMPLE.COM", "MARS@EXAMPLE.COM", "AQAAAAIAAYagAAAAED82deZoBKrKxZEtX7GEpHSs5hxsdAOvZQwHKupzQBkm3aN7KVv4PIeRctubqn5ItQ==", null, false, "7a70cf14-ce16-471f-ad45-9870e28dc74b", 1, false, "mars@example.com" },
                    { "8c7c6203-51ae-419b-8690-438d2bcab662", 0, "14a69618-c571-4018-8be7-0a451a87bf2f", "aarde@example.com", false, true, false, null, "AARDE@EXAMPLE.COM", "AARDE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEG/biFJ/kJe+vLK5Jt2Mt9rovcc+u1B5ruTrQSzIUNOe9mOKf2AU1ygR9C4x54i+DA==", null, false, "22c506f4-994f-4ba3-8f52-ba3f91b0085d", 1, false, "aarde@example.com" },
                    { "a804a448-64db-4229-a436-eaa16f537250", 0, "8b5a8c3c-fb1a-49c2-b727-5c77ba1cc0df", "sinaasappel@example.com", false, false, false, null, "SINAASAPPEL@EXAMPLE.COM", "SINAASAPPEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMlso90bAlozBb+hizIBDiMSoUNbZp5gHAIFL3fXRYIvA3rZSgIomO5vuEgs87Aurw==", null, false, "476c9736-0f68-4145-a066-b67cc17584f7", 6, false, "sinaasappel@example.com" },
                    { "a915374f-721f-4be1-95f6-fc0e5d3b799f", 0, "110d128e-7435-4257-8b02-930f189b0f8f", "octane@example.com", false, true, false, null, "OCTANE@EXAMPLE.COM", "OCTANE@EXAMPLE.COM", "AQAAAAIAAYagAAAAECjr1WMUNxBJtouWKrsElsYBXa6WX0u7vGXN+gpAkXhnrCQ7wKhhNWyrkDtz4/xVyA==", null, false, "7bbf297b-fc01-4e26-8ac3-47a192c35247", 2, false, "octane@example.com" },
                    { "ac024914-fa00-4dae-bb6d-ec7db00910a7", 0, "2c621400-fc31-4deb-9a0e-b2f14a9b3291", "breakout@example.com", false, false, false, null, "BREAKOUT@EXAMPLE.COM", "BREAKOUT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP8o1nAykPMWZV5aFG2XMKKE/UaP1xR+6s7xEaO9i1ILz96R7lpRhyvw5ZWb65Y0aA==", null, false, "57bd36f0-c220-450f-8c32-ca91f28c83e3", 2, false, "breakout@example.com" },
                    { "ac0ea0b3-e6b1-44a6-b279-7ac0573a0601", 0, "639fc921-3af2-4659-9219-099212f0902d", "neptunes@example.com", false, false, false, null, "NEPTUNES@EXAMPLE.COM", "NEPTUNES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFVL/p4lH3Ln+GVBdu6NNd/YCY5pLYSChCNU/Y9QT0rrvl7Vvjle1lWsUdo8jIdWgA==", null, false, "83c06252-50cc-40c0-848a-c1ad55aad3bc", 1, false, "neptunes@example.com" },
                    { "ae609a81-db19-4453-aa8b-16a85b4bf26d", 0, "211bfe81-70a7-4c30-b230-539fd836f7d9", "uranus@example.com", false, false, false, null, "URANUS@EXAMPLE.COM", "URANUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFzn0wMtFvczwuexELgYYS9a4TdOI9e0sdF5EUQNQj9Lu75HMpGf4Kgd6LLGh6Xi/w==", null, false, "897704a5-a2b4-44e2-8f1a-540d4e8da3f6", 1, false, "uranus@example.com" },
                    { "b70841f6-3c30-4210-aedc-f7582171657c", 0, "9cde9a56-f560-45e0-99ca-c53a61ac998d", "kiwi@example.com", false, false, false, null, "KIWI@EXAMPLE.COM", "KIWI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJavguMNL0jSr2VZyzjYtIwQ+DMPhXasCu8GKb/wcB6kRYlQRrqmjASWpP9G36qIZA==", null, false, "579472e6-49f9-43da-b49d-8d7f7d6dc818", 6, false, "kiwi@example.com" },
                    { "bbd0301a-b0fa-453d-88df-eaa3b9a871c3", 0, "7e1725da-493a-427c-a279-be647cedefd0", "watermeloen@example.com", false, false, false, null, "WATERMELOEN@EXAMPLE.COM", "WATERMELOEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE2R7p4EhUga7aesIf6lD3/3dngdS+PUQ2u7KJWKQUd2sXhRWjpr0+tvH8dK4yWa/g==", null, false, "2b3ef6c1-bab2-4032-99c4-09df11f2f596", 6, false, "watermeloen@example.com" },
                    { "bd0b4020-1939-474d-aad8-97a350037e96", 0, "1d6e9962-eb25-4a32-8f14-01dc5c11c226", "venus@example.com", false, false, false, null, "VENUS@EXAMPLE.COM", "VENUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI3QCyiU0Kq/OYa6EQY0c0qhK9Yyi8mpJ0iY3jue+UuiHouwA89bHibKWu2uFq2c2w==", null, false, "f9e93810-8576-435d-8fea-ff777e8a57ce", 1, false, "venus@example.com" },
                    { "be3a08d1-c300-4625-82c3-cd211abf13c8", 0, "5043ea1d-29e4-445d-8f04-85ee5103d3e8", "saturnus@example.com", false, false, false, null, "SATURNUS@EXAMPLE.COM", "SATURNUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF9hEuBCP66BHQuMO5PvKN0LvXd/fqFLzO50Rn08mb/Qc/UTHIU3oUdxzGSTqg7o3w==", null, false, "00eea2e0-49af-4178-a93c-d8e84f07fc2a", 1, false, "saturnus@example.com" },
                    { "c03ab19c-619c-41ac-ac13-b25515b6fe20", 0, "66e89053-8300-40b8-9902-36b1a8f145de", "ferrari@example.com", false, false, false, null, "FERRARI@EXAMPLE.COM", "FERRARI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOVs43YEsIOvKmuUbBcD+b7z9paqJe+piJqTCth+Re7VTK7Tsms2mOT4uxlGlPy4Uw==", null, false, "9de4e4da-478e-45f8-a357-676515ab4a2a", 3, false, "ferrari@example.com" },
                    { "c78d4929-c4c9-48d3-8940-3319f6f2f212", 0, "8a9acf65-76e7-4718-952c-30f95b56d16b", "fennec@example.com", false, false, false, null, "FENNEC@EXAMPLE.COM", "FENNEC@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPDDnNeXLH9CqKOjQbSvrNBNbhZFiYRH8fXzol4VukKwUW3+jPZSu1e2A0qUV4gQBA==", null, false, "a0f800ee-2124-46cd-86a5-8a5d63d3d46b", 2, false, "fennec@example.com" },
                    { "d5e7bd31-3a98-4da3-b2e9-bf119687a561", 0, "d9dcbba3-8b38-4d20-8666-d36d31f71b54", "volvo@example.com", false, true, false, null, "VOLVO@EXAMPLE.COM", "VOLVO@EXAMPLE.COM", "AQAAAAIAAYagAAAAEC2V5aZ4O28v30RHwsXEIkXUst4+j1AaBu7fcTxomL8t8GwcRpXOmag+eFNWyWo7wQ==", null, false, "86c29e78-3af8-4b72-a123-c777610ea8a4", 3, false, "volvo@example.com" },
                    { "ded386b5-7d81-40cf-9102-2e08a97e427c", 0, "6c31d6ec-22d5-46d6-b836-3158afc2b0dd", "avocado@example.com", false, false, false, null, "AVOCADO@EXAMPLE.COM", "AVOCADO@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM0u6UKxN/AusYaAWaJVtnPgfl/V9pOFimBGZztpBQXGtkqm7gOx2nx8gvjP69bggA==", null, false, "86c32ad0-f3d1-43a9-af72-bef5b87ebbe2", 6, false, "avocado@example.com" },
                    { "e2de1305-221a-44b9-a1dd-baecec678de4", 0, "5b572527-c89a-419b-a600-aa8ec1db8f85", "toyota@example.com", false, false, false, null, "TOYOTA@EXAMPLE.COM", "TOYOTA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKqggQpBQVbyjKWVN3pHuQmul6u7vUtozN6wloi369R2XQrkz86QRnQRH386o1Lg4g==", null, false, "f82ae762-10dc-4ebb-9234-4cc31451743a", 3, false, "toyota@example.com" },
                    { "e48f2aa9-947b-4108-bc72-4ef06aa3925b", 0, "39a8dcf5-3418-4831-8559-3906f2bc3df5", "mcqueen@example.com", false, true, false, null, "MCQUEEN@EXAMPLE.COM", "MCQUEEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBKqkCxE57+4GB9dHs69xgPs5o8o9wAieqCY3v0S4DfO8ocGJ34+Y50wmeerDsZrbg==", null, false, "521c470c-df6b-4397-acbe-a92a1a7d763f", 5, false, "mcqueen@example.com" },
                    { "e5e257e1-7aa7-45af-98cc-60fbad7949d8", 0, "32f3f172-ea3d-4916-9d92-9dc0d0c044fd", "jupiter@example.com", false, false, false, null, "JUPITER@EXAMPLE.COM", "JUPITER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJApbxDBmlGi+tP5toqTt4Z5SoDjjZm2c4e54DKHup+7YnLRwBYd3qaKZB+QH0RqiA==", null, false, "3d74808b-8d41-45c3-a24a-9ccd90972610", 1, false, "jupiter@example.com" },
                    { "f8f7ca46-e8ea-4081-8f0b-129358bf8c3e", 0, "01ca3fa4-0ceb-4882-8fbd-6ff45b2d108c", "rusty@example.com", false, false, false, null, "RUSTY@EXAMPLE.COM", "RUSTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP6N2GSJ6WMFS3n9uRtdRytdC2pN6IZwkRzCvFCAwh4cTcJTuqUd/PccnKhcg6HNlQ==", null, false, "82dedda1-fb71-4634-b159-c946ccdd5527", 5, false, "rusty@example.com" }
                });
        }
    }
}
