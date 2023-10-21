using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class TroubleShootingMatchupEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06f0e8e3-b9bb-49de-b1a3-b177496d8bed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "081e576d-9041-4c45-a055-c43e99d8c7e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2139f9bd-ab3a-4eda-9264-b2547f2e5f50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2226c3ac-fbba-4bce-b0ef-b61c013a78fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "266292bf-49f8-44d9-9f72-fc542ad4cfab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ce8137e-7375-43be-aa65-6a8081e974dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "319175ca-193d-4a00-a19a-835b93426f9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34e13bfb-fc7a-4e97-ad72-29a787cd1fce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38c9194b-486c-4922-b2cf-0c1f8465ca99");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bea9ea3-c8a3-4b26-a000-f8fd9aae5ab9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ef39bdc-7ef6-412a-884e-f7b61371a385");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "412bed91-ad5f-47d4-ab99-fd5ad2d348c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43e6421a-808c-44c3-90bc-957305b6671f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "502f931a-a881-4c65-811b-577a9950759b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "536382a4-9dee-46a6-8fc9-851d10b68983");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "583d4fbd-34f3-4fed-96b2-d427916eb442");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "627d77ec-4551-48d0-84b0-fb814108f783");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ba56498-562b-47e3-99f9-a0479b041c09");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6df351d3-0d05-4fd2-9d85-2bfd62e4b533");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79a95c24-b658-423b-91c9-f2a1dd715778");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89293c68-0f63-40c7-9b37-4a0bc88c75cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a18e012-6aa4-4015-9e0b-fe7abc9cadf1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c35f879-044a-47c4-b609-c484104c61fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d6b6bd8-00af-4b4e-a004-38ad4485e78b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9df35493-5eac-429f-85e8-86ad701945fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a761ea6b-6a47-445f-b0d4-1a37f8b41569");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558003-466e-4ff4-91fb-e281cad61f68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9a8c61f-35e0-4299-b56d-6ef0ca4f67cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd407bc3-a6bb-4051-b3a9-a8f0bb66ca41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b8e143-b588-4b95-b74a-8e6ba60d1f60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6b6d6d3-10b2-4bcf-b9fb-17c767fc1ab0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbc02091-1d0a-4f1a-af66-7c282f17c739");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fce44453-b29a-498c-a97c-6f4e56396561");

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
                values: new object[] { "26a9fa54-7260-4559-a7a5-e61dc802488d", "AQAAAAIAAYagAAAAEPDMPTvhL2FmZJsh5lETQDv78ufLkJesWlJ8KHUF8Y3T1DLqoirN+HGJADiZGHhIcw==", "0b58c346-bad1-46a3-8695-2dda0bb0fea9" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0378d250-3a61-4a5e-b0d4-619589674eef", 0, "b3757af8-b8a2-4da1-9982-5009eaca6a07", "citroen@example.com", false, false, false, null, "CITROEN@EXAMPLE.COM", "CITROEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM2K36erT+IMkcgFF6sUqV5SaSNAxaNfQtQUxb9GqQCSK3RHgAcI4nrLCM9FIo/P5A==", null, false, "a4de1177-77b8-40d5-b4fe-47d7eb68d5db", 6, false, "citroen@example.com" },
                    { "06a3572a-4bec-47c7-a38b-579b385dd4de", 0, "3fd93de7-dc72-4f6a-b1ef-0cb463d8f14e", "huiskat@example.com", false, false, false, null, "HUISKAT@EXAMPLE.COM", "HUISKAT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPmPDwFFT80I30TUe39y/12+Upv18atBOASKtp9Y80BxdjBVogHQlW72OpsjmBQM7w==", null, false, "cb171dfa-f817-4447-875f-29ed169c87f4", 7, false, "huiskat@example.com" },
                    { "09273e18-b9c7-47bf-a489-77804bf304f9", 0, "3f201235-5bb9-4aee-a7b0-5dc3f6afdf7c", "kiwi@example.com", false, false, false, null, "KIWI@EXAMPLE.COM", "KIWI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEdK2ia52+X4lhbkC3NBkEVrR6It4GMgsV7FCS8kpJFgz+nLGc1E2/tkiV63VviOKQ==", null, false, "fa1f8b0f-c004-48e7-be77-12e7e3d0513f", 6, false, "kiwi@example.com" },
                    { "149e491c-b736-4f2f-ba4a-2acb0c7528a1", 0, "30f20eea-6992-437e-84f5-c9907e35a5bb", "waterzwijn@example.com", false, true, false, null, "WATERZWIJN@EXAMPLE.COM", "WATERZWIJN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEC93H6lz5UwnoCLtbgPJmb3AaNgW2DT+LONnDE9t/iM6G5pxXi+VdfGFtJndZe9DCw==", null, false, "9245fe04-a8a7-4664-9115-ece0b058d996", 7, false, "waterzwijn@example.com" },
                    { "1f8d80bb-14e2-4175-991b-2f790e85140b", 0, "f726e5f6-e5f5-49fd-bc69-092ef7484edd", "fennec@example.com", false, false, false, null, "FENNEC@EXAMPLE.COM", "FENNEC@EXAMPLE.COM", "AQAAAAIAAYagAAAAELUOiX9HeUf5y2Y2FPqPusXJnefUPGIDQSrX49Yyu23l0/NCVUhGHnr7VUPKDGgoNw==", null, false, "8cfe3dc0-94f1-4d23-84dd-4e9406500523", 2, false, "fennec@example.com" },
                    { "2211aa7a-3c95-418d-94fb-0b7d6b7204f5", 0, "8ee71462-a5bf-4a8e-9479-f98f0f3b496b", "saturnus@example.com", false, false, false, null, "SATURNUS@EXAMPLE.COM", "SATURNUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ7T8a/Tj2io6VtfS/bhndzGoDLzLt7YSPFelCQmkVJccaPdxk2x2jmkZTmqQ4xX2Q==", null, false, "bfeffe35-841e-4d02-be64-18d7db6c8918", 1, false, "saturnus@example.com" },
                    { "34187acc-a14d-49fa-9c5e-3ea3ea5e31ee", 0, "717dcd1f-21d4-4465-ad49-15f2611b232d", "volvo@example.com", false, true, false, null, "VOLVO@EXAMPLE.COM", "VOLVO@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF59hVoZi3Fwar4Z77xHPChH6xaakS7hQaJ1vE9xKaJIMU7zDZZgC8uxk591SqHWBQ==", null, false, "e12fc1a0-7887-4357-8367-8599ea2d5572", 3, false, "volvo@example.com" },
                    { "368da7c4-a8f6-49e7-b00b-2fa01cb4e955", 0, "f18532d1-bf76-434d-ae70-5bcc5c75ecb6", "mercedes@example.com", false, false, false, null, "MERCEDES@EXAMPLE.COM", "MERCEDES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJpoyyOc0Tq+d9/wwqvwcc9/cFBPrx9RugCdNsLdVuPjxtAU021GxQgNWKM5IfM1Qg==", null, false, "8a47d76f-ea52-4c4c-85f6-a8f129eeef3c", 3, false, "mercedes@example.com" },
                    { "401d0804-10c0-4f38-9217-8c2e9d4289de", 0, "c960a90c-a4c9-4094-a06f-495e43f95711", "avocado@example.com", false, false, false, null, "AVOCADO@EXAMPLE.COM", "AVOCADO@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPv8DFrV4RTnbN4qQCIz1zAhadZfEBZ4tUxiOEnklDckAKFZY5zvbkSEGptAkhk4jw==", null, false, "8543c1a0-0e2f-44ac-8340-7160036bb2ff", 6, false, "avocado@example.com" },
                    { "5ddcc3f4-d599-4cbe-b869-8415c1aaecc0", 0, "f04ea787-c824-4369-be6b-447d6b59e784", "mars@example.com", false, false, false, null, "MARS@EXAMPLE.COM", "MARS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDb2yDmlqzRgeNnVJALprItdsosPJKLtopiMxWuxYCbkMkIn2YetKcn2FbVy/zWhZw==", null, false, "4e024aeb-a9f8-4990-b1eb-67b01620fb5b", 1, false, "mars@example.com" },
                    { "6f89177a-70e9-441a-9a4c-a321d47010c3", 0, "9000f3f4-8377-4200-9909-74c29b270328", "mercurius@example.com", false, false, false, null, "MERCURIUS@EXAMPLE.COM", "MERCURIUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKJ4TGU8oq+VuT7aHtS40XgsaaF71JQBdSYCiADCzzf6Bw2pFpVO3HNlKwbtQci2aw==", null, false, "fb8b8f08-d4ad-4acf-bbef-532a48471872", 1, false, "mercurius@example.com" },
                    { "7ac21402-320b-45ce-bfa0-1d76b1f32dbb", 0, "5dfa1c8f-fd17-4413-98e2-78fe5dd6ad76", "jupiter@example.com", false, false, false, null, "JUPITER@EXAMPLE.COM", "JUPITER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPZiCvhUchEuOs1sxwX9aJ+J/HV1hi5l4YIdkumgA1HQssdl67TrmAg5WiSfEIWjEA==", null, false, "259408e9-0c85-4711-a69d-ef146bcd27be", 1, false, "jupiter@example.com" },
                    { "8606f29f-7473-453f-b1bd-5e2dc38ef7a2", 0, "31364130-b4b0-4d8a-963e-e772649163e4", "mcqueen@example.com", false, true, false, null, "MCQUEEN@EXAMPLE.COM", "MCQUEEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGBq//BgnVTJnDdYUAsuO2/GbTsNeh0fbNnsvDgWbpq4dP+2sO/zvOM7Dmi/k82kQg==", null, false, "f835eca4-58b3-4e67-8ca9-7d7e1f6a89f9", 5, false, "mcqueen@example.com" },
                    { "887aa203-cfcb-422a-a2a0-05da9265f3fb", 0, "53bc7bff-5b9e-4060-b1b4-d144c43cbac7", "peer@example.com", false, false, false, null, "PEER@EXAMPLE.COM", "PEER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP2d5YYlCw3QGE1i6I6w4NP4P0EsBjINoEGyBvs5qc3HXLBUQxLEFubQJTx7NKk90A==", null, false, "b8fb918f-55f8-479f-9794-15aee42accb4", 6, false, "peer@example.com" },
                    { "89afa77f-a512-4012-8dd5-1413a9639b36", 0, "828e4b40-dd75-4dca-bb04-4c465de3d532", "appel@example.com", false, false, false, null, "APPEL@EXAMPLE.COM", "APPEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAELB2RPqnBc8qs8amqod1s2LXuPdMiNRP3l44QlFCZORkaqutNMsVpX1z5OsJYnICEg==", null, false, "828063a9-9106-45cc-933a-19be7e8df53a", 6, false, "appel@example.com" },
                    { "8aba06fb-8f8f-4c50-85fb-e36f96f0ec45", 0, "416aa46f-97aa-4239-ad42-920df2d41fa8", "venus@example.com", false, false, false, null, "VENUS@EXAMPLE.COM", "VENUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ0/8dCqTQE3lZpexLpxEOKFttf6ev5McyLq6yu20C01UFvO7/wu3FCuSv/hUAMZEw==", null, false, "9b950078-b016-4836-bdac-55655e0c02b6", 1, false, "venus@example.com" },
                    { "8ae2c649-10a0-465e-841d-0bd4a9d2a1c6", 0, "2e0d7952-3274-4834-936c-09378fd3d107", "uranus@example.com", false, false, false, null, "URANUS@EXAMPLE.COM", "URANUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBRRk9zMm01MmeMWhiOJT5sMl0kvAcJsB4xOYA8HHCTwJqkzmH52OHFEpd54dOnFgw==", null, false, "3b8cce24-dbcf-4c8e-8303-b79ee133e286", 1, false, "uranus@example.com" },
                    { "9ebf2be3-3e33-4bb8-a6fb-40eb5a3ccad9", 0, "59cc05a5-f8ad-42a1-825e-73b26165a74b", "dominus@example.com", false, false, false, null, "DOMINUS@EXAMPLE.COM", "DOMINUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH+bMvVl6GjVPrMk42OMDW2PGCwbeliiIYny+5yJEZu9kVy49eh3DfMbP9FZDRGs2w==", null, false, "1bd82c3f-4dc4-4fc4-92c0-b2d9a987c598", 2, false, "dominus@example.com" },
                    { "a230d934-3c94-46c8-aa89-a7c8b0272555", 0, "dd3da691-fa9c-42ce-9e0c-518fb0986efa", "rusty@example.com", false, false, false, null, "RUSTY@EXAMPLE.COM", "RUSTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIURFzLqSR8fD0yCY4qO+9ETc4hafokInX+++AZHfPSpNxEv3qx1PhWhY0TFP8kr5g==", null, false, "2bda3d6c-600d-4b17-9a5a-f3c1b8e76220", 5, false, "rusty@example.com" },
                    { "a39e6e16-e0f9-4a71-b88e-357d0fb2a32a", 0, "13a9b269-bed7-422b-9df6-e18ea43fcd9e", "watermeloen@example.com", false, false, false, null, "WATERMELOEN@EXAMPLE.COM", "WATERMELOEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAENWplyNgoE3LMOpnpyfj/LjRB5npUxXCfsenSTvGQTT8/raUN3sZc2F20wkwFbu6AQ==", null, false, "c617c79d-a7d7-4066-8b0f-b54afa49edf1", 6, false, "watermeloen@example.com" },
                    { "ac79763b-ae53-4ce5-8f68-203f76af1b7d", 0, "f36a2269-7ab2-4d9f-a378-81f0d8a8d37f", "dusty@example.com", false, false, false, null, "DUSTY@EXAMPLE.COM", "DUSTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFL0TNUWHUE3IE+elHvM/PQSRaW+1d64ASxM65Qzq5fSY2HiVYLQDOLIWcl6UOuuZw==", null, false, "c169aece-6c2d-4631-b4e5-456c86c66c21", 5, false, "dusty@example.com" },
                    { "acb5d9bd-db27-4c08-82ff-f1e9ac445b12", 0, "edaaf3ce-f3a0-4ff2-986b-ea8adcea735f", "bruce@example.com", false, true, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMTbP2d+6tYKjnpap2t964YdGRYp8xfTOUq2clpQmMzagzdClFIu6Ym7Jal6j0+aPg==", null, false, "360ecd24-8712-4dfb-a2b3-a451089e9f11", 4, false, "bruce@example.com" },
                    { "b1c7a6f1-0be4-44b6-9fdf-cb1590a6aff2", 0, "e235e127-bcc6-486e-8ae8-175d3337382c", "volkswagen@example.com", false, false, false, null, "VOLKSWAGEN@EXAMPLE.COM", "VOLKSWAGEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJmd+nDHhf/b6FvvD6eRvWgNvK+PP5u+m6NsYBXv6590Ayip5wfdUnH1kQC9F04ROQ==", null, false, "b901d589-8ea3-4d00-aef1-d3b74eb3966e", 3, false, "volkswagen@example.com" },
                    { "b2792493-756e-419b-966c-a9505fa65a64", 0, "7854d501-d83e-40d5-9d07-64a174c15c4a", "aarde@example.com", false, true, false, null, "AARDE@EXAMPLE.COM", "AARDE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEId36yjCzSVwDWVS+M1pu+5SIgiamahDXWdGU4Ip7AzkYzOCIQOAICWbb5PU6Vff/g==", null, false, "e38396c0-fb0e-4b4a-84c0-43a455ef849c", 1, false, "aarde@example.com" },
                    { "bc8f77ab-a544-4c3c-9ae7-163c15756cb1", 0, "bfa80a73-f92b-4b5e-bbac-d5c75a8f6bf0", "breakout@example.com", false, false, false, null, "BREAKOUT@EXAMPLE.COM", "BREAKOUT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ3V+DM91mM3qdIVnyuR0Q0+X8ZL/hwpnpCrh0693tWEo72RUmu2ogOCGyaTe9wmbg==", null, false, "6ddcb0e7-ff95-4404-84b5-9f0b2386490d", 2, false, "breakout@example.com" },
                    { "bdcb7d13-44c4-4931-ae10-ffa6ab779d5e", 0, "14433ea7-c60f-468b-8fe8-59ed246f80af", "octane@example.com", false, true, false, null, "OCTANE@EXAMPLE.COM", "OCTANE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEJPiIhnswJi6qbUK8eo7EuMT8CQkEYocv3TIFBQMTTadWXvi4JPH/KvkGVme1nijA==", null, false, "1ba297ae-7405-4e9a-ab16-0e1b3031aaad", 2, false, "octane@example.com" },
                    { "cc9626b0-186a-4089-88ce-a73c92297b41", 0, "4aa663da-d463-4362-bc19-dd84dc8b2577", "mack@example.com", false, false, false, null, "MACK@EXAMPLE.COM", "MACK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMGF0CjWYEXgC8swEv51ydbqFQAGClorHKjBT7XTdzz0Rh8qOolsOs8XzVVQQeXwCA==", null, false, "0dd0483d-09b5-424d-8b0b-9819df92408e", 5, false, "mack@example.com" },
                    { "cdaca0e6-93db-49dc-aab3-51927c07127a", 0, "d5b9b056-d5e3-48cc-8ca0-28caec5b966c", "toyota@example.com", false, false, false, null, "TOYOTA@EXAMPLE.COM", "TOYOTA@EXAMPLE.COM", "AQAAAAIAAYagAAAAECXAEcrlCyc+ysB3+UtMjUVRCDi3tsJZAkiPWr/JMJn5A13+1Oe0h1llQYMGGQKXJQ==", null, false, "85aab69c-a176-4472-9711-c477a336b1f3", 3, false, "toyota@example.com" },
                    { "d97cf9b9-96e3-489b-ade4-d500b3e03cbd", 0, "2f5ac3b3-3d75-4296-8970-42545837061e", "neptunes@example.com", false, false, false, null, "NEPTUNES@EXAMPLE.COM", "NEPTUNES@EXAMPLE.COM", "AQAAAAIAAYagAAAAELhz+tgjz0diDsyRHyEagnCUJO2HAD4zZwi1xUQ3sQEwSaRGBPmlwKUff/UBrTlRXg==", null, false, "0423fde5-33b1-4751-b5e3-0ee901e30341", 1, false, "neptunes@example.com" },
                    { "f5ee3cc8-4ad7-4ae0-9860-e9caf907c41f", 0, "1788b240-db2e-43ae-b1ac-58d50d0632ef", "ferrari@example.com", false, false, false, null, "FERRARI@EXAMPLE.COM", "FERRARI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHyX1SbwBVnYWNaYXcM4bL3bJDerAUPqmBIZK6pge1TWntSEk7WRIPXHtSk/1nZhaw==", null, false, "b2071d72-d9fb-4e2f-8d1d-f1548df65235", 3, false, "ferrari@example.com" },
                    { "f7cba7eb-6d61-433b-a10f-2148dcda3412", 0, "20665232-5d64-4b8c-81e8-2b414827da2a", "sinaasappel@example.com", false, false, false, null, "SINAASAPPEL@EXAMPLE.COM", "SINAASAPPEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKsXPfPjFt62Sh/AbO8scoX4luiO3qwEfbvvUa39XNaPGgf1D37IKBIyb4IBTx3pUw==", null, false, "46eaccc8-4d3a-4fe2-8394-505602fff88c", 6, false, "sinaasappel@example.com" },
                    { "fba5cece-9c57-4c66-820e-34a7e0221379", 0, "2fe5381b-ed5f-41aa-a4c5-247b6932a442", "banaan@example.com", false, true, false, null, "BANAAN@EXAMPLE.COM", "BANAAN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIZtAjh/nxmt5DxxBgjlCMR6YkDUH8PImLgjjDsgf9Gyt/dGz0wk5JqqG5CJ1kxLqw==", null, false, "50d8cbd1-a3a8-4eac-b029-33cc2c7563a7", 6, false, "banaan@example.com" },
                    { "febc3155-2082-4777-9b13-2baa557513f1", 0, "d57b5b98-687f-4e9b-afca-d77f04760ab4", "hyena@example.com", false, false, false, null, "HYENA@EXAMPLE.COM", "HYENA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGJuJyPtGJTz5bklK1dX1TgbZNKzwd6vbQLJYwiIP5fHmbwppzuWZsi9v5OLdUWtyg==", null, false, "d41cae1b-29fb-4385-ba6d-74558d561eb9", 7, false, "hyena@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0378d250-3a61-4a5e-b0d4-619589674eef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06a3572a-4bec-47c7-a38b-579b385dd4de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09273e18-b9c7-47bf-a489-77804bf304f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "149e491c-b736-4f2f-ba4a-2acb0c7528a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f8d80bb-14e2-4175-991b-2f790e85140b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2211aa7a-3c95-418d-94fb-0b7d6b7204f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34187acc-a14d-49fa-9c5e-3ea3ea5e31ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "368da7c4-a8f6-49e7-b00b-2fa01cb4e955");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "401d0804-10c0-4f38-9217-8c2e9d4289de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ddcc3f4-d599-4cbe-b869-8415c1aaecc0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f89177a-70e9-441a-9a4c-a321d47010c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ac21402-320b-45ce-bfa0-1d76b1f32dbb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8606f29f-7473-453f-b1bd-5e2dc38ef7a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "887aa203-cfcb-422a-a2a0-05da9265f3fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89afa77f-a512-4012-8dd5-1413a9639b36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aba06fb-8f8f-4c50-85fb-e36f96f0ec45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ae2c649-10a0-465e-841d-0bd4a9d2a1c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ebf2be3-3e33-4bb8-a6fb-40eb5a3ccad9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a230d934-3c94-46c8-aa89-a7c8b0272555");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a39e6e16-e0f9-4a71-b88e-357d0fb2a32a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac79763b-ae53-4ce5-8f68-203f76af1b7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acb5d9bd-db27-4c08-82ff-f1e9ac445b12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1c7a6f1-0be4-44b6-9fdf-cb1590a6aff2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2792493-756e-419b-966c-a9505fa65a64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc8f77ab-a544-4c3c-9ae7-163c15756cb1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdcb7d13-44c4-4931-ae10-ffa6ab779d5e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc9626b0-186a-4089-88ce-a73c92297b41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdaca0e6-93db-49dc-aab3-51927c07127a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d97cf9b9-96e3-489b-ade4-d500b3e03cbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5ee3cc8-4ad7-4ae0-9860-e9caf907c41f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7cba7eb-6d61-433b-a10f-2148dcda3412");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fba5cece-9c57-4c66-820e-34a7e0221379");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "febc3155-2082-4777-9b13-2baa557513f1");

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
                values: new object[] { "5f2a9865-dac2-49ee-9c88-d4a3e791fe15", "AQAAAAIAAYagAAAAEM7SboH96hkktyrnNgzn0oMgqk9kV7vWWohMSNB6+EADDOdTsjdR/Z3Oi700iEL0ng==", "537ae362-92cc-4644-8c3e-984a3e24fd96" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "06f0e8e3-b9bb-49de-b1a3-b177496d8bed", 0, "044fa24a-a7c3-41cc-8f95-6aa267516a2e", "ferrari@example.com", false, false, false, null, "FERRARI@EXAMPLE.COM", "FERRARI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKh68h1Kqf/UxfxfEh0dRQw7Au5dV7QhZKsxHfJzCa0TZxTCFb5Ul1HP5OVqiJR29Q==", null, false, "dbb9938e-be1c-4051-8fb8-04ca6b831f68", 3, false, "ferrari@example.com" },
                    { "081e576d-9041-4c45-a055-c43e99d8c7e6", 0, "02cd7017-05c2-4301-b200-49b402b46ee8", "dusty@example.com", false, false, false, null, "DUSTY@EXAMPLE.COM", "DUSTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAENQaGFShqzorD3K4pws9IxBWAj+MiEBNrAzTJp5rF9LzAh/eiE9LoME9OVUQ+BaWhw==", null, false, "600b376c-2c6e-40bf-8289-9619325d8089", 5, false, "dusty@example.com" },
                    { "2139f9bd-ab3a-4eda-9264-b2547f2e5f50", 0, "ab86497b-88b7-4876-9a0b-dd864639b85d", "jupiter@example.com", false, false, false, null, "JUPITER@EXAMPLE.COM", "JUPITER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMWMEpKHnb0/KTp0PJH9DQid8l721N44RCa7kc32NNhgUOYMlVSpwUl06omo+RLYFw==", null, false, "f5ca5796-c6c4-44e9-9043-8d973ff90287", 1, false, "jupiter@example.com" },
                    { "2226c3ac-fbba-4bce-b0ef-b61c013a78fe", 0, "6bf5213a-9e1d-4fbf-b276-36d60f5f2b01", "avocado@example.com", false, false, false, null, "AVOCADO@EXAMPLE.COM", "AVOCADO@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPNvKZD6rUMa8VOP+f4i3ASZOWGjPAemp8KyTua1WrzTLmlRwNdHdFNGtnghPRaKgg==", null, false, "e99de644-3a65-4e5d-87dc-d440c522fcc8", 6, false, "avocado@example.com" },
                    { "266292bf-49f8-44d9-9f72-fc542ad4cfab", 0, "6b7f715e-8068-49a7-8c29-21ef708bcee7", "rusty@example.com", false, false, false, null, "RUSTY@EXAMPLE.COM", "RUSTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJBy3M1fJ5udHsnZn/PaBjxzrK+BFvEXc2hhy0FMM1tDE9+m+eBm++DLsISl76ZYkg==", null, false, "9e51d895-9448-4b70-b7ed-213f19e8c82f", 5, false, "rusty@example.com" },
                    { "2ce8137e-7375-43be-aa65-6a8081e974dd", 0, "44ab2820-45f5-4f4d-81b9-ba5bc0f825c9", "octane@example.com", false, true, false, null, "OCTANE@EXAMPLE.COM", "OCTANE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPBtuFGyFZSzMxnu06aDp9J+hh5RJuzzXmMKP3ORMANG5E5OrUaK0hxy546YsNeYkQ==", null, false, "b92f9322-b067-48f7-931f-4edf544c857f", 2, false, "octane@example.com" },
                    { "319175ca-193d-4a00-a19a-835b93426f9b", 0, "2d64a8cc-6982-4686-87eb-8ebd9794c5c7", "uranus@example.com", false, false, false, null, "URANUS@EXAMPLE.COM", "URANUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPg7KMvpDNC5f/wW8phoMY1tXwZTXOLoP7O7AazTRP5S8xh9DUVqlYOyHqYhbbaHSw==", null, false, "ce8db92a-381f-4b8c-80f0-e08218b0c48b", 1, false, "uranus@example.com" },
                    { "34e13bfb-fc7a-4e97-ad72-29a787cd1fce", 0, "4ec5baea-7e13-4327-a4db-f54a29da243c", "citroen@example.com", false, false, false, null, "CITROEN@EXAMPLE.COM", "CITROEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAELVIcmscE9GKGgj7loz3ty9venCNDrYCiqZ5tqXCnbauRV1FBt61e7RPMUWoD6Lsyw==", null, false, "e2169845-34c8-4028-8d95-d0c43c38dd85", 6, false, "citroen@example.com" },
                    { "38c9194b-486c-4922-b2cf-0c1f8465ca99", 0, "f4302428-ec4d-4538-8441-50c71c0f42ce", "dominus@example.com", false, false, false, null, "DOMINUS@EXAMPLE.COM", "DOMINUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI2mfP9YWjqao4hnbXGgHFQxLnBnBL9hVDnQHdNH6rz9rAU4Z/WzyGsmEKouA73DRg==", null, false, "7fef654f-cca6-45d5-a581-a682583a6190", 2, false, "dominus@example.com" },
                    { "3bea9ea3-c8a3-4b26-a000-f8fd9aae5ab9", 0, "dffc67c5-53b7-4704-8816-fcc2ceee5c61", "saturnus@example.com", false, false, false, null, "SATURNUS@EXAMPLE.COM", "SATURNUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGkCoZ2a+aDq4Az9BflRO8BdnTyxs4nR0NdOVGdMXyA6yzRwNoB/ZpXZEl+7ToE9lg==", null, false, "3ce02b1a-d347-4a00-9af3-3d352c7e4358", 1, false, "saturnus@example.com" },
                    { "3ef39bdc-7ef6-412a-884e-f7b61371a385", 0, "cf208b1d-7a1e-4742-987f-f7ec9604421f", "neptunes@example.com", false, false, false, null, "NEPTUNES@EXAMPLE.COM", "NEPTUNES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF49t9JpHQGdf6qMPqR8HLtXExCW/kgK8B7a1+24eohtx+KJcW4mWCF56+FWtLveXQ==", null, false, "aeecb8c2-f2ae-46b3-a19c-3cf1f3112230", 1, false, "neptunes@example.com" },
                    { "412bed91-ad5f-47d4-ab99-fd5ad2d348c2", 0, "1d86b93b-90be-47c7-9242-32a5e1bcc361", "waterzwijn@example.com", false, true, false, null, "WATERZWIJN@EXAMPLE.COM", "WATERZWIJN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO3O9g5s4rG5HhSAYzGV7xmAoES9MNfWvTMvJIVK+51Nb2Xpwhd2ZxgVgyE6tfjXqg==", null, false, "c753f4dc-e156-45ce-b2b7-04e1f5d38c83", 7, false, "waterzwijn@example.com" },
                    { "43e6421a-808c-44c3-90bc-957305b6671f", 0, "8b9f8b4b-209e-4525-a109-9cda45fdcdbe", "breakout@example.com", false, false, false, null, "BREAKOUT@EXAMPLE.COM", "BREAKOUT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPLM0fvsSrlvsct65UQUh63V0ljcgG5SXdpW0TlNnUb3BbeIVVAsWQ3Gj2jPEnQ2wA==", null, false, "52463b5a-a8e9-4224-84d4-36a96b468d56", 2, false, "breakout@example.com" },
                    { "502f931a-a881-4c65-811b-577a9950759b", 0, "296bf938-17b5-4e71-807a-da2a9cb968b8", "mercurius@example.com", false, false, false, null, "MERCURIUS@EXAMPLE.COM", "MERCURIUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOKvhSqp9CfZs7br+gBl4Z9dLVJYcBmb2IlFaU/PP9h5mJlsJD9YT4bbKWHapdCDaw==", null, false, "acb518b1-bba5-426f-94cf-000024c8f2b9", 1, false, "mercurius@example.com" },
                    { "536382a4-9dee-46a6-8fc9-851d10b68983", 0, "d4614f9a-f107-4eb3-b067-ce0d40a3104b", "mercedes@example.com", false, false, false, null, "MERCEDES@EXAMPLE.COM", "MERCEDES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEK68CooC9TpI3/UYXLFVubgIGKoue60GppzlY5ImkoU6ILGK/IqgowE8dGBN4yhFPg==", null, false, "6f468373-2e33-4ca9-ab48-e06e6bd2bd29", 3, false, "mercedes@example.com" },
                    { "583d4fbd-34f3-4fed-96b2-d427916eb442", 0, "9ddac693-0f1b-4d35-a640-401064a9e05d", "huiskat@example.com", false, false, false, null, "HUISKAT@EXAMPLE.COM", "HUISKAT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDpsBICg+YeCRvXlbx1DZOQl9cpAtI9yPt5w0AEtc9Y7MQPZJhnooU929jxi7Ard6w==", null, false, "6014f633-6ee4-4701-bc5f-bf8cdbbdf4ce", 7, false, "huiskat@example.com" },
                    { "627d77ec-4551-48d0-84b0-fb814108f783", 0, "c9607b7b-49b8-4bd2-b3ca-59d856f632d9", "toyota@example.com", false, false, false, null, "TOYOTA@EXAMPLE.COM", "TOYOTA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGFem2zIGIJi3ph6k4EYu+Buhcay9KIQ9Sj2SaX1m81GAh5MMCVi8q8iDFXkZ4lwYA==", null, false, "34d1a40a-a8d8-41df-9d54-0fb6e1ddd6fa", 3, false, "toyota@example.com" },
                    { "6ba56498-562b-47e3-99f9-a0479b041c09", 0, "dd54e1b0-090b-412f-a972-5ac2ffd45a36", "appel@example.com", false, false, false, null, "APPEL@EXAMPLE.COM", "APPEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIKzO8m9Iob/Ivk4ZEGwKtNqYlbw4smlOeAKPQ9HcPydVXoLtAR7iT9dv+s3QTQZtw==", null, false, "6a90eb73-b7cf-447b-beb5-e8b09e646aa7", 6, false, "appel@example.com" },
                    { "6df351d3-0d05-4fd2-9d85-2bfd62e4b533", 0, "ec0965e9-a2f5-4045-b4f1-2f4af17a9b2a", "volkswagen@example.com", false, false, false, null, "VOLKSWAGEN@EXAMPLE.COM", "VOLKSWAGEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM16QbDdfD1HmYnA8I3HF5WZ6TAS7iYX0wcaQd4vTbyEI5w1KZYFNi54NFfFbgcGsA==", null, false, "ea96d095-6c32-4844-b624-27478c148c31", 3, false, "volkswagen@example.com" },
                    { "79a95c24-b658-423b-91c9-f2a1dd715778", 0, "37654954-99a4-4a41-839c-04def3f7cdf2", "mcqueen@example.com", false, true, false, null, "MCQUEEN@EXAMPLE.COM", "MCQUEEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDJjjzJ8dqJFpmmMV/kWrEu7Bb+6okj6onqJGZM3awcZ9wyhuwnZdEAP2tDALkPNFA==", null, false, "c83babb5-f32e-488c-afa7-68fc5ec87e30", 5, false, "mcqueen@example.com" },
                    { "89293c68-0f63-40c7-9b37-4a0bc88c75cf", 0, "cccfc633-8680-4253-8e4e-2051072f8629", "mars@example.com", false, false, false, null, "MARS@EXAMPLE.COM", "MARS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOUu6ZxyxeqGWA6fikARTOBU2CNriE7ywGJ1pk4ZkfkTFSOWxFjAPraxHxvQnxUPyA==", null, false, "3f015c4c-c0dd-4c07-9027-bd98e963397c", 1, false, "mars@example.com" },
                    { "8a18e012-6aa4-4015-9e0b-fe7abc9cadf1", 0, "184e1e15-13b9-4554-97d6-274729131857", "hyena@example.com", false, false, false, null, "HYENA@EXAMPLE.COM", "HYENA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHMgzk7bl++HwOTbknHMrjAq9O8kJmPgkHdqrfHN3b6y34lGeS4PKwziKYeJFA/5XA==", null, false, "82a61060-6540-4c47-85c7-ff91ec8c2586", 7, false, "hyena@example.com" },
                    { "9c35f879-044a-47c4-b609-c484104c61fc", 0, "8e6e6ff0-d2ad-4f81-a515-4906ae5d7520", "peer@example.com", false, false, false, null, "PEER@EXAMPLE.COM", "PEER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMiuAPUFM9TPP2HOOIgjPfIZVxrOAK4vfxxFdc6yuxPL+vXAQnaB5La73mvh1zFMEA==", null, false, "b1fc02fc-1fa2-4ee9-a056-9a6c9c524526", 6, false, "peer@example.com" },
                    { "9d6b6bd8-00af-4b4e-a004-38ad4485e78b", 0, "17b79e8f-a5cb-4c3d-a3e3-e3cf83445afb", "sinaasappel@example.com", false, false, false, null, "SINAASAPPEL@EXAMPLE.COM", "SINAASAPPEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPOUn2rLKxrFUu8zkjUzVA9yGx9dsY2nLDl6p4f4+yynjd7rweOdM/TMAYGGDJRFfg==", null, false, "d957cd4e-a9c5-4bc3-a320-e56546118e8d", 6, false, "sinaasappel@example.com" },
                    { "9df35493-5eac-429f-85e8-86ad701945fa", 0, "7bc653bc-0cde-45de-a08f-d4220e25b767", "venus@example.com", false, false, false, null, "VENUS@EXAMPLE.COM", "VENUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIFmuhtLvHOHF0EoxOCiD/wm36rK5FDKvURpujRI+z4o+6XV998XG1S03nW9+P26MQ==", null, false, "ef8e23b7-56bf-4fcd-ac97-6ff70726dd74", 1, false, "venus@example.com" },
                    { "a761ea6b-6a47-445f-b0d4-1a37f8b41569", 0, "475a03ee-9fba-4db0-9d14-48b43663ce89", "mack@example.com", false, false, false, null, "MACK@EXAMPLE.COM", "MACK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEECrtBic9yNJvgJPoHHaeE+e5WhpgyxVYhIg4VnoRGYhKXoWiskDEH+ALxwdzOTpQA==", null, false, "b4930413-d238-48d8-af59-f2b4d80f38b9", 5, false, "mack@example.com" },
                    { "af558003-466e-4ff4-91fb-e281cad61f68", 0, "909aa804-c271-4f25-8ce2-4101ad9d9af1", "watermeloen@example.com", false, false, false, null, "WATERMELOEN@EXAMPLE.COM", "WATERMELOEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAELascqoLO3dj2XnRwLi3/JfNsQIQNWEQVq4pmcFh0+93ls3aLft+zGSgOg+hu1Zs2g==", null, false, "e20d4136-638d-4f68-8ecb-175be7f66ac6", 6, false, "watermeloen@example.com" },
                    { "b9a8c61f-35e0-4299-b56d-6ef0ca4f67cf", 0, "d0dd7ab8-d082-49f4-aa07-e3173a33cf3a", "fennec@example.com", false, false, false, null, "FENNEC@EXAMPLE.COM", "FENNEC@EXAMPLE.COM", "AQAAAAIAAYagAAAAED7qeQLHNJMzQDpFUop+I1iHUiNKa6axCwgeboX9tLaPWrOH5NX/2fQ6Vek4taTbDw==", null, false, "2478cda0-8882-4e15-ae3e-5151fb25986c", 2, false, "fennec@example.com" },
                    { "cd407bc3-a6bb-4051-b3a9-a8f0bb66ca41", 0, "b7ca4a84-b3d1-4d43-8635-6cf5222e4d50", "volvo@example.com", false, true, false, null, "VOLVO@EXAMPLE.COM", "VOLVO@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJh+TYECqOJ24u0Vz09Q3Dvn4hjn14lMjiuxb3HSjytxkFIAes3Jtk0LFw6tBw9UWA==", null, false, "b43f3959-a395-400c-9220-e8ac035602b1", 3, false, "volvo@example.com" },
                    { "e9b8e143-b588-4b95-b74a-8e6ba60d1f60", 0, "c64663da-890f-43ad-8da8-232987e2606e", "aarde@example.com", false, true, false, null, "AARDE@EXAMPLE.COM", "AARDE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOaoF86G65dT8OKCBcwdcqrcioj7Uh6kHjXkZVCGaWsfMHNEpnNT0u9RfLQFDlAxGQ==", null, false, "0b2e0ef5-7e47-4b81-9362-05b9be00379a", 1, false, "aarde@example.com" },
                    { "f6b6d6d3-10b2-4bcf-b9fb-17c767fc1ab0", 0, "da2c0005-7957-48b7-b11d-99174d3c7f62", "banaan@example.com", false, true, false, null, "BANAAN@EXAMPLE.COM", "BANAAN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMqu5357xwUY8DuCxO60ODkaLgJq7ixQoaqM6i69Bap3fR9fR/av2ITirfajYhVT+Q==", null, false, "075db8bf-49f0-4caf-94f3-cf82d1c041ad", 6, false, "banaan@example.com" },
                    { "fbc02091-1d0a-4f1a-af66-7c282f17c739", 0, "05abec35-6519-4e7c-affc-863f4c218121", "kiwi@example.com", false, false, false, null, "KIWI@EXAMPLE.COM", "KIWI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH8ugt6qwUz+hIuzrXPGLe9D0+llTwIfeE8cMZ6u/MtY7bwIT1GHI6hCgYWp2mhvHQ==", null, false, "b3b39b7d-7f99-4b5d-9cf9-8777689ff34f", 6, false, "kiwi@example.com" },
                    { "fce44453-b29a-498c-a97c-6f4e56396561", 0, "f78b0f78-f87b-4091-8bc8-e1cf7abde88f", "bruce@example.com", false, true, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKzTrFxkilmZkG4JwgBxAE4wRq8dFuykV2WQoqYHGVkYNmYVfLyI8DEqeYJzTkwVvQ==", null, false, "de9238cb-c81b-49b6-9657-94cebe693118", 4, false, "bruce@example.com" }
                });
        }
    }
}
