using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserSeeding6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51f84465-fd54-4ddb-a0df-bcd063a321c8", "AQAAAAIAAYagAAAAEOK1sarQcE/i9sL2ciE0SKfsuPWA2RLHzQ/Uj4mcjXnSsTxXDVwFU2SAFTBwkcc3sg==", "78ef60cf-19f0-4787-8530-5fb4d02c272c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1344c7e4-a10c-49f1-96a8-6cc705163bfb", 0, "fbd696ab-23f8-4e88-a28b-cf60026b1815", "mercurius@example.com", false, false, false, null, "MERCURIUS@EXAMPLE.COM", "MERCURIUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEN6OZjfLB7NHLS+P+gq8oMGXWkGwlLZnmVBjdWMdObecWSr80AjgDv9hoBdPKlPiMw==", null, false, "b36a52f0-11ad-4cda-ade2-9d9df380cc0e", 1, false, "mercurius@example.com" },
                    { "17cba1d2-6ea1-44c0-a7db-0e40a864fbf8", 0, "3fe9cec8-87ff-4728-96e4-ccd93a59aae1", "mars@example.com", false, false, false, null, "MARS@EXAMPLE.COM", "MARS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBwDNQqnnei2JYa6fUhH0e3VOozf0f4LgqLKM29PLGa8DBiVF8ZiEZxTiB6b4amjEw==", null, false, "93da63f3-b0ca-4fb5-a422-e41e85dde3e1", 1, false, "mars@example.com" },
                    { "20284b24-9a53-4d1f-bd4d-f330e1b334d5", 0, "98312278-fd3d-4c12-bc30-590ab8e8d89b", "octane@example.com", false, true, false, null, "OCTANE@EXAMPLE.COM", "OCTANE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGsIHX4QBSBnlOuqQQAHvkXef29NtwUMf6BEKppf7xwjMy/U9iR/y2NkOG9IaK5Cjg==", null, false, "ac5f908e-ca0c-451b-8e22-3fee06bf7756", 2, false, "octane@example.com" },
                    { "29d00832-82b0-4080-9df9-6c1a2013fd54", 0, "65becf48-9ceb-452e-bd63-34731296f308", "breakout@example.com", false, false, false, null, "BREAKOUT@EXAMPLE.COM", "BREAKOUT@EXAMPLE.COM", "AQAAAAIAAYagAAAAED6r72308lIWg6MFHBn8BbiAnk1OAy0D6P2nvMLGoKDRrOfQWtPbVMSfGJG2ZKKXUw==", null, false, "cb3fa142-76b9-471f-8c7b-a1edd07b47e7", 2, false, "breakout@example.com" },
                    { "2e3105e0-d9d5-4619-bc0e-aa9933bb4f79", 0, "c6ee66fa-b12a-406d-8657-aefb3cd7af59", "neptunes@example.com", false, false, false, null, "NEPTUNES@EXAMPLE.COM", "NEPTUNES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ2OjrgPyYXw3Y0u0rjU7LiMQ0wF7GBozPYhHh0uEyprUMPWXdNra8X89XcKE3MgYw==", null, false, "f1f081c8-2287-477c-92d4-b8ac5b420a6b", 1, false, "neptunes@example.com" },
                    { "3f7b3fe4-deb3-40b5-9178-d1c36e6daae2", 0, "19b0fea7-b77b-46b2-ad2f-053d1d669392", "dominus@example.com", false, false, false, null, "DOMINUS@EXAMPLE.COM", "DOMINUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPDh7DUg3Dw/SQo4fltkeSqTRQdcasdeASfz878YoRuHG90d3zWsKnV+P5W2/3Uwlw==", null, false, "3ac99ea1-707a-4a01-8336-3e1f7c3447f7", 2, false, "dominus@example.com" },
                    { "4c2f35de-e1d6-4f68-9e72-e26e6470e5d9", 0, "ba9fbb86-ef76-4e68-98fc-41e7a15332a2", "aarde@example.com", false, true, false, null, "AARDE@EXAMPLE.COM", "AARDE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDwYR9trhBzKm27gbbh8pNtw8Jllh+C5FKaGkPxnRpjiTDDdDTWW8IZqdEwEuiFNzQ==", null, false, "b3adc2c3-f7ce-4334-9b64-b83b3512cc9d", 1, false, "aarde@example.com" },
                    { "9e67efce-1dd6-46c1-aa4d-b12d19f328fa", 0, "10d4289d-d1bb-408e-bbfb-2a2533a67f01", "fennec@example.com", false, false, false, null, "FENNEC@EXAMPLE.COM", "FENNEC@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPVJclRnjgmRkoOvoYlxsm4p8qJYUhjqABQYFjwkOFpJ0vksC+Gni7U9FSHYpJqmFQ==", null, false, "6c930792-d77d-4a5d-85d7-daf91e94df4b", 2, false, "fennec@example.com" },
                    { "b19c9700-487a-440a-bdda-053fcc879e61", 0, "4543bf12-9130-4bf7-b2b1-56ddf9b17b8f", "uranus@example.com", false, false, false, null, "URANUS@EXAMPLE.COM", "URANUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDG9DAZiyi6uGZGIrEc6HlP/BvmcFC799hQjK7YTe2AUF4i1ijVHxmoeGwuOq5RNfA==", null, false, "171197b2-6ab2-443d-859e-a9ca5d326d65", 1, false, "uranus@example.com" },
                    { "ce34cf19-efa6-4ae7-b649-b55c7c236cb6", 0, "4401bb14-ded5-4fe7-b74f-dde5e64c71ae", "venus@example.com", false, false, false, null, "VENUS@EXAMPLE.COM", "VENUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHRx7rCoTmcENSrsIxzLF0sGpdFi9qLzlEs9VJT2OyvC9Ndv2uUHzxgg4ugp4v/Ryg==", null, false, "06f0b813-3118-4f72-b5aa-d572a69a214c", 1, false, "venus@example.com" },
                    { "cf8d2abc-20d7-4b88-8e50-c8e574942a2d", 0, "8c1e8c36-95c4-4e45-a1b6-8a35ff9845fe", "saturnus@example.com", false, false, false, null, "SATURNUS@EXAMPLE.COM", "SATURNUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM6Vj5H+26BcFq8vzhuOTOFF0PUSUnDms/cccDCW6rOwfcJ898n7HZqWicp4bGEeFw==", null, false, "e5636f33-3ce8-4e82-be70-6e61c444f87d", 1, false, "saturnus@example.com" },
                    { "e85d8cab-9060-4f10-99b2-c5fa31b224be", 0, "26e9f28d-767a-4f7a-8181-9d2b43879c63", "jupiter@example.com", false, false, false, null, "JUPITER@EXAMPLE.COM", "JUPITER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKnYNCqcyez9q9wPiC1gtefF84lZ0RaLZQwqZORarxNuXH7jujrIRcjcNgQ575xBcg==", null, false, "bb4c52bc-3347-4bb7-9cf9-aa24e1e33ec2", 1, false, "jupiter@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Gewoon buitenaards goed!", "Planeten" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Wij zijn de betere auto's. Wij rijden niet alleen, wij vliegen naar de overwinning!");

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 3, "Waarom zou je naar de overwinning rennen als je naar de overwinning kunt rijden?", "Auto" },
                    { 4, "Onze prestaties zijn te allen tijde vlekkeloos!", "Vlekkeloos" },
                    { 5, "Ka-chow!", "Rusteze" },
                    { 6, "Zoet of zuur, wij winnen elk uur!", "Fruit" },
                    { 7, "Wij rennen naar de overwinning!", "Vierpoten" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0044ab8a-86f8-4ab8-8b30-216aba5af903", 0, "48c0d668-e174-4d51-bf7f-9dfa37593a8c", "bruce@example.com", false, true, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAECwoQHR88QmonqHfvSIRyMJaF+Cqtscsn4PNiyml2DoaLFmCjnuqDXaGsJ9qxQa/YA==", null, false, "4cd60cc7-98ef-444c-aa15-7939e79d7e09", 4, false, "bruce@example.com" },
                    { "25753620-cd54-4cd7-a0ab-9c1487eb6699", 0, "50e58ff0-8e77-438f-8acc-7ee90430fbbc", "rusty@example.com", false, false, false, null, "RUSTY@EXAMPLE.COM", "RUSTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFCN0e9fdrxnG6/L1hEDA+mADTEbAM7PoiB1+5DOVzbd71i/Nk47HFQVDBUxwAbaow==", null, false, "704ae9d7-b51e-4b86-b6c4-8fd5b4db43cb", 5, false, "rusty@example.com" },
                    { "2bc4f6dc-8926-4728-b4df-30dce6ade8b4", 0, "67143c3e-0c3a-48eb-bd9f-21ecc43f541c", "mercedes@example.com", false, false, false, null, "MERCEDES@EXAMPLE.COM", "MERCEDES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDgDjHGhRtm2zA88jgX8yBhcrSz8OGwNm0GTaDKUQM6cCOZVfMXR3nmlm5XHScUwHQ==", null, false, "858f751e-1a1d-45e2-9e61-96d1174bf41e", 3, false, "mercedes@example.com" },
                    { "5895071a-c273-47b3-9a49-3ce6bbd1a9c3", 0, "21269214-ac44-4543-a64e-6164ef55bce3", "volvo@example.com", false, true, false, null, "VOLVO@EXAMPLE.COM", "VOLVO@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJFr/i2LXGrhvOYyR8QfNj1JvNcM6hNtF0gLQJMsqZddh85kZHimucsiYG1iMC37BQ==", null, false, "e0c0b20c-9fd3-4e6c-b261-c51c3f4f7578", 3, false, "volvo@example.com" },
                    { "6082d369-7981-48e4-b2f2-20f5e5cddcda", 0, "181260e3-d588-4a42-9808-dcfd70e0b697", "ferrari@example.com", false, false, false, null, "FERRARI@EXAMPLE.COM", "FERRARI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOg6b38NRFpuTIpeTsSZxkVfbDdk+QLfENbTj3y3QVVjDm/OKPIfDwoyZyg1/hmzHg==", null, false, "88e0eb9e-beb5-46f5-b7bd-3dced1329d39", 3, false, "ferrari@example.com" },
                    { "7e848164-f081-4fa8-9be2-da5e5f34b008", 0, "b151d4f4-4451-409c-96c3-6dcc68754ce1", "watermeloen@example.com", false, false, false, null, "WATERMELOEN@EXAMPLE.COM", "WATERMELOEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMXtS6Ytg19S8aLbtlzPIHvjGo6QZuaHxyShbO4k+Es2hv7r1dqGeaZuj1FArraA5g==", null, false, "156960da-89ab-4a9c-a9af-494033feb8e9", 6, false, "watermeloen@example.com" },
                    { "a217f5a9-eb50-4b26-9732-f398cbd670ea", 0, "47015180-e686-4741-80cd-76482f646c30", "mack@example.com", false, false, false, null, "MACK@EXAMPLE.COM", "MACK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEL/j+xEvRirWnKCVajY+kKjCmhPY3XoweMpqcaooqFQjBSbUjmzC08i7tHq2fHTapg==", null, false, "9abf38eb-e921-43c4-bb31-95b39372028a", 5, false, "mack@example.com" },
                    { "ac5e7e73-d30c-4d0d-a5d2-186dcb5cc7c9", 0, "37b0e6ad-2904-4396-b33f-bc5ce8fd781e", "waterzwijn@example.com", false, true, false, null, "WATERZWIJN@EXAMPLE.COM", "WATERZWIJN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEORI6bIST8VbJzaE6iNtZCn+2ZldkbC7JEtqhFLheT9nwtqHcwajoLjWeTqJkMN+4w==", null, false, "3c764eea-1cde-4e71-a7db-534ce26cb2a7", 7, false, "waterzwijn@example.com" },
                    { "afce0866-a0a2-40a5-af84-31eb3566dad4", 0, "ae97b966-ed71-4ed8-ac37-c55bb4fcc7be", "volkswagen@example.com", false, false, false, null, "VOLKSWAGEN@EXAMPLE.COM", "VOLKSWAGEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH8AxhcutqxJvlpKc6mcrjLssEpMCNnpo6rfKQc03FuCJcqGDA/QgfWT2vHhF7jfCA==", null, false, "2f28807a-600c-41be-b2d9-3dffc8b1ab41", 3, false, "volkswagen@example.com" },
                    { "b442d50d-d90c-424d-a8ba-6829517a6c42", 0, "052d67cd-b8b8-49ea-93ad-3e9cd26ad5e1", "appel@example.com", false, false, false, null, "APPEL@EXAMPLE.COM", "APPEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAED4Wf/IzRJCVJOvkoJWqhPnA87d3savoQc7YLWr7ooJEL6nOBRBqQ0B+mn3GCZ/OTg==", null, false, "87c395c8-f13b-4dcf-95b4-99cf7f7403d6", 6, false, "appel@example.com" },
                    { "b9095f76-3d64-4676-8c97-7431c5dd6eda", 0, "5627fea8-8efd-4551-a7b8-33c3a9c9c4d5", "citroen@example.com", false, false, false, null, "CITROEN@EXAMPLE.COM", "CITROEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBlKFstBU8bRO5m8emddRAAKf1Nqr3lp4SQ9H/MgOqiMKn90w464FRRSX8K7IB+LPg==", null, false, "0e6f1f2a-d1ad-4be8-8fbb-1a13d0ef9a3b", 6, false, "citroen@example.com" },
                    { "c0c38ba3-67b1-4450-9d7d-865932754e78", 0, "30766bd1-25a4-4c8f-adf7-2f7673a55092", "mcqueen@example.com", false, true, false, null, "MCQUEEN@EXAMPLE.COM", "MCQUEEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAECi1LckD1Dm/XoMGVRSnxXSfPF5YQ+U+0Mh8jAbEQg2AGjVjjun6KBxiapRsT5ciag==", null, false, "1ffaac89-d6e5-4991-82b6-05e0545fed3f", 5, false, "mcqueen@example.com" },
                    { "ca760475-8f16-4c27-b8b7-2a02e316c255", 0, "717109d5-9b93-413e-8d92-0d42cc6da3b8", "toyota@example.com", false, false, false, null, "TOYOTA@EXAMPLE.COM", "TOYOTA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMtxlLI7IP/pc8olGIZ3NGCVk+IwGzKsJd5OKUPuvscawXR5NOv50yFuHfnjzwQPtA==", null, false, "ebabfd3d-5a0d-49f0-8caf-f847f7f990ed", 3, false, "toyota@example.com" },
                    { "caf4ad7c-ddbf-4e76-b06f-5c5878d71f46", 0, "d12e0de7-0274-4f74-86e8-bb5c9eed16da", "huiskat@example.com", false, false, false, null, "HUISKAT@EXAMPLE.COM", "HUISKAT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPk0lAV31eBtTNbMCypOSuXK04u7+BBKgbt+fU7uWMu2AwggQI8dWY+jtNSkO6cjJg==", null, false, "c4d8e69c-96a6-4cd4-89cf-f843cb89b779", 7, false, "huiskat@example.com" },
                    { "cf6674af-2692-4515-aefb-a3fe31a0f803", 0, "6d687025-74f3-4816-aba3-cab7b8c7529e", "hyena@example.com", false, false, false, null, "HYENA@EXAMPLE.COM", "HYENA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPbZ9ExS5eV1EbybB2c9Oi0XZDbOddv1NVBKpNXgAtzSFmZeeAOw/pird4XiH2Bo2A==", null, false, "6f772798-207f-4284-bd7d-80f0f35c1565", 7, false, "hyena@example.com" },
                    { "d0761263-757f-4e63-8436-2409bf5205a5", 0, "2f7e860e-92d3-48ae-b19b-aeb7c2097c14", "peer@example.com", false, false, false, null, "PEER@EXAMPLE.COM", "PEER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOwbTiGuuh5oeklXAMYM38mlVdrtatSUc116XEcSPQSdgHPPlkZm92wn42q1MmLfcQ==", null, false, "00e2cf4f-2b32-48b4-97b0-c22be709b408", 6, false, "peer@example.com" },
                    { "d88d8bc6-7325-4d1c-b309-f274c9483c0c", 0, "1290f631-f810-4738-97df-8b9cf20d6086", "sinaasappel@example.com", false, false, false, null, "SINAASAPPEL@EXAMPLE.COM", "SINAASAPPEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPo7a0VpZoNmPAZvfJFrAtqxkh60zRKsGT9AfahAFu6pVSr0hY/t4db5Dk3BlIaQPQ==", null, false, "26a0c794-77ac-4f28-9895-3668a9ae4154", 6, false, "sinaasappel@example.com" },
                    { "e27b98c9-c856-4d1c-82b2-f9bfa905f4f7", 0, "e78fa82c-40d1-4850-a718-7b3e7bee30a6", "banaan@example.com", false, true, false, null, "BANAAN@EXAMPLE.COM", "BANAAN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOw3/whclPTsmd8Tb1a5IFjpBVZnLs9oTeI7xj5zFWx5gBxVWL9U6xXioRrtKll/cQ==", null, false, "da779b76-3048-45e1-a635-6b003899c332", 6, false, "banaan@example.com" },
                    { "e6aa4d0c-3f98-4cc8-b5e3-a2937fe426eb", 0, "2ab9edbf-81be-455e-8cae-419525d0b3df", "dusty@example.com", false, false, false, null, "DUSTY@EXAMPLE.COM", "DUSTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB2rXWzKrTNN9R/MFDYRH+WU0H96NMzrXotz0nx89CukpGNdYd3Zknio077SMEXjsg==", null, false, "9433bb95-6d38-478f-97c4-c3b91f26a0fe", 5, false, "dusty@example.com" },
                    { "ed60e34a-81de-4d05-88d2-2719d2bd4501", 0, "f21ace41-4f9c-492c-92d2-85fefe6a1944", "kiwi@example.com", false, false, false, null, "KIWI@EXAMPLE.COM", "KIWI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKz9OdrQ9DuELXG1DZXdgI3J8lbPYtMpfesa+g4XeTIrCoxQMmbtVmDf0Y4VUOaE+A==", null, false, "a076c82c-fc53-436c-aff9-c21a4d543e38", 6, false, "kiwi@example.com" },
                    { "fc15f759-9d99-4d19-ba0f-51e44e88db52", 0, "a59dc090-34e3-46c7-86e2-4d99aff1a84b", "avocado@example.com", false, false, false, null, "AVOCADO@EXAMPLE.COM", "AVOCADO@EXAMPLE.COM", "AQAAAAIAAYagAAAAEApenNunEJCiO0WnvQTz4ChTcvofYcaqZicy9P086s5urohCnxAkKUt7UIEc9N8ing==", null, false, "179ccf65-a451-467b-bad8-e8f262c46c1c", 6, false, "avocado@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0044ab8a-86f8-4ab8-8b30-216aba5af903");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1344c7e4-a10c-49f1-96a8-6cc705163bfb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17cba1d2-6ea1-44c0-a7db-0e40a864fbf8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20284b24-9a53-4d1f-bd4d-f330e1b334d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25753620-cd54-4cd7-a0ab-9c1487eb6699");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29d00832-82b0-4080-9df9-6c1a2013fd54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2bc4f6dc-8926-4728-b4df-30dce6ade8b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e3105e0-d9d5-4619-bc0e-aa9933bb4f79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f7b3fe4-deb3-40b5-9178-d1c36e6daae2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c2f35de-e1d6-4f68-9e72-e26e6470e5d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5895071a-c273-47b3-9a49-3ce6bbd1a9c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6082d369-7981-48e4-b2f2-20f5e5cddcda");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e848164-f081-4fa8-9be2-da5e5f34b008");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e67efce-1dd6-46c1-aa4d-b12d19f328fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a217f5a9-eb50-4b26-9732-f398cbd670ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac5e7e73-d30c-4d0d-a5d2-186dcb5cc7c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afce0866-a0a2-40a5-af84-31eb3566dad4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b19c9700-487a-440a-bdda-053fcc879e61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b442d50d-d90c-424d-a8ba-6829517a6c42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9095f76-3d64-4676-8c97-7431c5dd6eda");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0c38ba3-67b1-4450-9d7d-865932754e78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca760475-8f16-4c27-b8b7-2a02e316c255");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caf4ad7c-ddbf-4e76-b06f-5c5878d71f46");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce34cf19-efa6-4ae7-b649-b55c7c236cb6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf6674af-2692-4515-aefb-a3fe31a0f803");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf8d2abc-20d7-4b88-8e50-c8e574942a2d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0761263-757f-4e63-8436-2409bf5205a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d88d8bc6-7325-4d1c-b309-f274c9483c0c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e27b98c9-c856-4d1c-82b2-f9bfa905f4f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6aa4d0c-3f98-4cc8-b5e3-a2937fe426eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e85d8cab-9060-4f10-99b2-c5fa31b224be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed60e34a-81de-4d05-88d2-2719d2bd4501");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc15f759-9d99-4d19-ba0f-51e44e88db52");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5fbc722-2cf7-43a9-914c-7690ee88c542", "AQAAAAIAAYagAAAAED8tcncpaV22l8iE1inu5R/6lr+Wwq2/XivPdQCa0mJ5Y/c3wMYqYlWvZbtuvp1nXQ==", "de5f0159-a6a4-4643-8b87-29e341dfb3e9" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "32c518f4-a582-4693-9bb4-ba183fb35970", 0, "19ca5756-cea3-4715-b444-862c19c0153b", "octane@example.com", false, true, false, null, "OCTANE@EXAMPLE.COM", "OCTANE@EXAMPLE.COM", "AQAAAAIAAYagAAAAENwXzuIFvpxe09pyS3L5D8p445i4y5sB9CKxJPuIUcqRcQ6jQnHnTXOnjM8s0OTjSg==", null, false, "be16b465-0601-4bbb-bfbb-a8f36f83d072", 2, false, "octane@example.com" },
                    { "62326871-6356-48f9-a46a-39a5cef2b474", 0, "7f5c511b-8544-4b7e-8783-03f43aab214e", "breakout@example.com", false, false, false, null, "BREAKOUT@EXAMPLE.COM", "BREAKOUT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEInCkdtHxQUqJDcjTsT1TKvuj+ggRe/Qs2b3Tl8IdHtNfv9B3LTfjAaXbZKpb4ox2A==", null, false, "6e58c92e-d61d-47cd-b1aa-3ffa22b54514", 2, false, "breakout@example.com" },
                    { "7fd3d929-a335-4e2f-92f4-734113630c04", 0, "7b0acece-8879-49d6-b8da-a1ebff5c4293", "bruce2@example.com", false, false, false, null, "BRUCE2@EXAMPLE.COM", "BRUCE2@EXAMPLE.COM", "AQAAAAIAAYagAAAAELIllkZO02E/BpEUFj6hBYwBanNV6lR0VBQTLZFOdhKe9FCOD34SG48gses9BeaWpQ==", null, false, "28ee1b0d-765c-465f-8c19-9f3b1761f5c0", 1, false, "bruce2@example.com" },
                    { "9d451b8d-5504-4762-a61f-afb7cc5612e5", 0, "af1cadba-c0f7-4082-bee3-dd0e7d4a89bf", "bruce@example.com", false, true, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIf/zYH9fZ+AieRmV3sWcdwqDemw0l+RZXaOc/mwevI5GY1IqNnT9SpQywHso654+w==", null, false, "c284c517-c4e4-4fe1-b20a-7ae5cb7fe03e", 1, false, "bruce@example.com" },
                    { "bb3b8c4f-dfbf-41a1-883a-008682272e90", 0, "467b6230-cd68-4707-8374-dff68670051b", "dominus@example.com", false, false, false, null, "DOMINUS@EXAMPLE.COM", "DOMINUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEA/OBfD5eRe8Kp6LVM9Gti8B4AsWp3RxpOrIxS4k8KK3DnGNJhme/+eN5DUFWzsS1A==", null, false, "b01b4b67-6cf7-4d63-8994-d08b56668610", 2, false, "dominus@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Het beste team.", "Fireboss" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "glhf");
        }
    }
}
