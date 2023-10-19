using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CTFTournamentPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class SelectedTeamPropertiesInMatchup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01540c75-7e8f-42fe-a45d-f834e522bef5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07c46f13-8296-4bef-9860-f0559a355b64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08f76bd8-f14e-4a00-8a47-92d160e856f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b180b65-9138-45b3-b844-88cb39d88c40");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108eeebb-7eb8-450e-ab15-ae92e1e05849");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2422bd80-04c4-4bec-8d9f-02e50f676bba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d722f3-68f7-42a3-905a-52098e566c51");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b98acb7-6027-4f54-943f-f977ea8b6df6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55c8442a-4198-4e28-b035-d7c39e3ef855");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "562c2c81-e901-4b1c-8c28-a11c5b671787");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56b624f7-15de-4965-9ed2-f5ce745c2427");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58ad7c06-e494-4411-8537-4480fc28f516");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5efb9286-2103-4ca2-91c1-d612fbfac094");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60b05027-c941-40c8-a68e-a004a54b1016");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64bfd85e-31eb-4ed7-92ee-d71a83a7e37a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "721c20ff-5d34-4c4f-a9fc-59658476912f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75051934-a5f1-426e-8a73-04f0b6772583");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87fbf155-60c1-4e49-a762-e3aa4575a27f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94936367-a01f-4f75-b8ef-b53313ba9519");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96633b4c-cb12-41d8-8c04-fdadb59c7964");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a718130-42f1-4001-a0cc-0ffe65407ed2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b5b1d0c-1c8a-4f74-bac4-57f1d0e85ef5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ff5e509-31f7-4c39-a5c9-f42b1f10287d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a80b61a4-da7a-49c1-a390-c15730c4e794");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a96c3d9c-1304-43ce-946a-0e4c5a51804b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4bb479c-678a-4fcc-9b15-7973ba035c31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b66826b2-ec13-440e-8135-704a23a03fd9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba643c0e-6ba7-4297-88bd-cc53a5634d1e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d43f9978-34db-440d-b546-4bf308b8936a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f03d148e-5e52-415d-bc12-cb9b88782b8f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0bd370f-e9bf-4223-b9ea-1b70cb6cb16c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f743b192-1832-4116-a652-91c1e35f1b1d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb1c6af6-c657-416a-bedd-7c0afa8cdc22");

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
                values: new object[] { "e6ef40d1-fe08-45e7-bbd8-32d4b3f0f94f", "AQAAAAIAAYagAAAAEMaRXbo8tPjRUsZd8OAi3s8k5Ra8j9a8H6sqBNRjVirexHsZYsbExvBoF48GAN0cng==", "893c17c9-cff5-404f-97da-f6e83b59fbab" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "086fe6d2-a294-4856-a877-fcad0670d1c4", 0, "4d274a18-d315-4d85-8f93-6faaed1912a0", "waterzwijn@example.com", false, true, false, null, "WATERZWIJN@EXAMPLE.COM", "WATERZWIJN@EXAMPLE.COM", "AQAAAAIAAYagAAAAED1me9eex40/dRQnGyP8nh0HbDABx4Z30DsV2NZNwvQ27rcmqGsku5HOoS7zJvHdjQ==", null, false, "20792246-a99b-4bdb-9c81-6948d31388c8", 7, false, "waterzwijn@example.com" },
                    { "0a46404e-c572-4fa6-bd56-6b50f3c905ce", 0, "3afc186a-2ad5-4b69-9adf-cb29b0e52f11", "octane@example.com", false, true, false, null, "OCTANE@EXAMPLE.COM", "OCTANE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKfuXnSmIMLmjYWbTpmT6rxH1/7VOmNT98aAAmrQ/5IB85J5fWDgHXP5u+OOX/RDeg==", null, false, "d8155d17-a793-424f-8c2a-8f6d308bb0c6", 2, false, "octane@example.com" },
                    { "0b1b1fc6-336c-4696-9bce-eb6ea121411c", 0, "6de2368c-c12b-4ce7-91b6-4c589775079e", "rusty@example.com", false, false, false, null, "RUSTY@EXAMPLE.COM", "RUSTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEj/QziA7+Yv6GPg9dmqe3h6y0SoViHpeDRUbKBA9MtQXGVPfaacuHJxRO4IDGobFg==", null, false, "8d126cb7-fe55-4752-a53a-dee7433c91e1", 5, false, "rusty@example.com" },
                    { "0b3b3c4e-87bf-4de8-a2f2-c119041731ac", 0, "4f3f0392-d3d3-43fa-941c-c4a464288144", "dominus@example.com", false, false, false, null, "DOMINUS@EXAMPLE.COM", "DOMINUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAECivvjfGNjIdGO7JGDTBi7J9wDuBbKpjXBSK5M+B2InEGaiZyqDUf5b8+vFVtKr+7Q==", null, false, "d572fd21-5d46-4f5f-9294-34bea280b8ee", 2, false, "dominus@example.com" },
                    { "0efbaefc-8f42-48d5-b7d4-1dc48856c553", 0, "1c7015d2-f38c-49d3-b4c9-71e1ded72a19", "appel@example.com", false, false, false, null, "APPEL@EXAMPLE.COM", "APPEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJpQyv4zvXSc9EUdUCTQYVuktTlZZ515KRWM+yi4RQXK4/HjH6RJmqmIGHgCPAT8Pg==", null, false, "937a31f0-6aea-4c48-809e-bca46e53c2d8", 6, false, "appel@example.com" },
                    { "24923f4f-28d2-4d33-b591-fd62eff4ec0b", 0, "cf9ef788-c855-45cb-b8ff-9c6336c8ba2a", "fennec@example.com", false, false, false, null, "FENNEC@EXAMPLE.COM", "FENNEC@EXAMPLE.COM", "AQAAAAIAAYagAAAAEC8y+/9mGrBPPTyWIJFRQF9w8IIlyyt9rxQZufPw3rkXT76hwIK1SgdAETuL2MB6Ug==", null, false, "8ea8918a-d082-4a1e-a27c-e11eeb674a3a", 2, false, "fennec@example.com" },
                    { "2d6017ee-4cec-4193-b22f-9f0476766d6c", 0, "1f262013-a96d-493a-98c0-ecc187fd8622", "bruce@example.com", false, true, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH6M1DjMs5meZctUaKNw7UTK/3dXj36yxk38VWrKqTIf79nEJsW07vtmn9U5+eRf2w==", null, false, "ce973be7-b92d-4b95-b196-3ca6cfb44969", 4, false, "bruce@example.com" },
                    { "2fd8b3ba-3639-4796-a2e7-a2b5a01c7c62", 0, "612e4203-4cab-4ee3-9bad-ad35eb51ee01", "peer@example.com", false, false, false, null, "PEER@EXAMPLE.COM", "PEER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBNfq+LQ7NctnqD5xOEIeHmZ0Tqn/bKHJn10MU7Sg9cFAflqzoDpE2faTHQPr7nnFw==", null, false, "50557e96-426c-4312-8a4c-1fe97c0e1877", 6, false, "peer@example.com" },
                    { "4377849e-17ec-40b0-b9e0-5829cd20f99b", 0, "e28e240c-5230-40ef-80be-7e6d7dc66a87", "avocado@example.com", false, false, false, null, "AVOCADO@EXAMPLE.COM", "AVOCADO@EXAMPLE.COM", "AQAAAAIAAYagAAAAELDY43NTgRG+knmrmnmI+sf0T/JE8NBPJh5YVFNavROeu804M5kryyZPsfnF39XVyg==", null, false, "b1eb8936-9871-49f1-8058-a9d0260396cb", 6, false, "avocado@example.com" },
                    { "4df4c77c-b17b-4004-8313-0f6186197a91", 0, "3dcd9c88-8d4f-4d83-b64e-2fc176043be6", "aarde@example.com", false, true, false, null, "AARDE@EXAMPLE.COM", "AARDE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKY87Y+GNiS5R8N2xHXCm3sZnbiLGBp1gimHIxwK4vcfX4tHTN5ZEEb0UAO3QeBwrw==", null, false, "c0731370-6d2d-4753-abc3-58a6ebc15bb8", 1, false, "aarde@example.com" },
                    { "5cf817ed-761d-45fa-8dc7-9006f340f073", 0, "b2608a56-784f-4c05-b4ba-c5b5807ef8c7", "mars@example.com", false, false, false, null, "MARS@EXAMPLE.COM", "MARS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFGEIF+A3YKU55xKqdchoNRhysRdnyTj+nb0wpNKcVhmsj0YHy8V1iUE/JfDK3zUrA==", null, false, "6490be31-2ec0-4453-ae12-99746807390d", 1, false, "mars@example.com" },
                    { "62ab27ff-6f66-4365-9322-991dfd9883ff", 0, "4288ceb0-4686-450d-a4c5-232f7a5cd9a1", "saturnus@example.com", false, false, false, null, "SATURNUS@EXAMPLE.COM", "SATURNUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKV0S406Wxnmq4MG62Lk+/M0jKHznkWiHWu+yiyuhHXavEq8SQnVI1TODgxOCvgJ+A==", null, false, "1340fe23-ba74-48dd-9363-b27be79366cf", 1, false, "saturnus@example.com" },
                    { "6819b530-01d3-4dbb-8b00-8bc9a62b47f6", 0, "a5851098-c5dd-4e51-b557-72869446fc88", "watermeloen@example.com", false, false, false, null, "WATERMELOEN@EXAMPLE.COM", "WATERMELOEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDTDgQsPGTTj9sq4VWcrNhQ7dr3mdbjGEyfismcID92Y8UlKHRyx815UfkKAr6sHJw==", null, false, "34c2c50c-46a2-495a-9d84-9641922a4401", 6, false, "watermeloen@example.com" },
                    { "681bbf2e-5b68-4275-a863-b120c6ef85bc", 0, "06b90db1-157c-4b32-b767-9f44bfdbedcb", "huiskat@example.com", false, false, false, null, "HUISKAT@EXAMPLE.COM", "HUISKAT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFdy0npP7Fwyi1r0B2mAGGi4a378sAVf6dFhkmoEEmLYdYTaliErBk5BQ7xULsORUw==", null, false, "bc0bb646-5177-48fa-9ee7-823047cb2fb8", 7, false, "huiskat@example.com" },
                    { "77f8ae78-85ca-4fb8-af48-a1ee30db55e4", 0, "03cc3a13-1b2d-4c83-a7f3-b3682acfba51", "mack@example.com", false, false, false, null, "MACK@EXAMPLE.COM", "MACK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDvp3x9jHFpOGFJKBE6Q8hH3sa7MO9a24ReMn86ZwC0gxSBhBlvrICEzqabqoTez+g==", null, false, "14192a79-ddef-44ec-bf6d-5ab701bc6cbd", 5, false, "mack@example.com" },
                    { "8053d965-61fd-41b7-b4c3-8f4781a7a593", 0, "deeaf13f-99c8-4b8c-90e4-2952e3ab7e9c", "venus@example.com", false, false, false, null, "VENUS@EXAMPLE.COM", "VENUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGaJ8RAdBoSZlV2SomxDF+uzu725ZhxsE46ArN3u6M3BYGnYAaqY4fzzUHrDPd5dkw==", null, false, "508360af-e8b8-471b-b401-aaf2de11322a", 1, false, "venus@example.com" },
                    { "8235138c-558a-453e-8fba-6b74e1aefa66", 0, "11af4e6a-0b1d-436e-abfd-beabb417a7b5", "breakout@example.com", false, false, false, null, "BREAKOUT@EXAMPLE.COM", "BREAKOUT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAeGPOyibsalts62ugp/PuWd6GDOJ13nCde8fiaY7hYTxKzF9pTIwTMvqJ3arXXN4w==", null, false, "8d098367-ef0a-4c8d-b437-d6f3fd6db8cd", 2, false, "breakout@example.com" },
                    { "85616ac6-cf3c-40bb-931e-96129345323a", 0, "c0fa0df3-fe05-44e7-961a-e5789a0750e6", "jupiter@example.com", false, false, false, null, "JUPITER@EXAMPLE.COM", "JUPITER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHg6djFcbTzwTjU2MVvcSmNxj0aCACqrUQUnQuQRnv9LNMXeU5kp9l2VCfYwVEFYtg==", null, false, "f4289ac5-ca8a-4ab8-ad5e-a463aa4a926c", 1, false, "jupiter@example.com" },
                    { "86342fd1-a45f-40f1-b9de-c0d2e7b82943", 0, "c903a447-f635-4ef1-81fa-cdbddb818ca2", "neptunes@example.com", false, false, false, null, "NEPTUNES@EXAMPLE.COM", "NEPTUNES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEENbXebTDOi45cCTzV+XYNT+v5x2bYTNypviAKEOxpr4rcFJ0kp76QWNE+Dmvdx8Mg==", null, false, "be74c50c-f7d7-4c80-af88-fcc2bcb15391", 1, false, "neptunes@example.com" },
                    { "8afc4855-e9a5-4388-b333-791f8874e653", 0, "911bf4e4-6f9b-4212-8426-9c3f53e62eba", "mcqueen@example.com", false, true, false, null, "MCQUEEN@EXAMPLE.COM", "MCQUEEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGtp+OTUK6Wr+lrrM84TOPLxqiDvY46L9PQQlkm2bk6DazI7VVLipNIixOAjfWsiag==", null, false, "625f7bde-4c3f-44cb-9408-30c947033b08", 5, false, "mcqueen@example.com" },
                    { "8b2c9220-0d9d-4c1b-8fb3-5ff1b39b2065", 0, "8659c641-5077-4237-a3b9-983d3ea15326", "mercedes@example.com", false, false, false, null, "MERCEDES@EXAMPLE.COM", "MERCEDES@EXAMPLE.COM", "AQAAAAIAAYagAAAAENzqxt5fZCacmy8x7/zX8yfdebqZw4h936vM18r2MWdHAZfAxuRktYOyNoqpcAP5hg==", null, false, "4f171008-0f07-484f-a0e3-ef8b63a55153", 3, false, "mercedes@example.com" },
                    { "9cf4c124-2484-470b-8d73-c262b81e4a3a", 0, "9c145e78-6c27-45e6-bb9f-25bffc594346", "citroen@example.com", false, false, false, null, "CITROEN@EXAMPLE.COM", "CITROEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOH1gx0InptmLDKq3iFCc+7us8Z1lmhcnF4T/IZpUmdRbJeeVagaiaY6foM0PckRPg==", null, false, "bfad0833-2c18-4e21-9a86-cd8467cebc13", 6, false, "citroen@example.com" },
                    { "b3066c92-7ac9-4d89-b21b-4c395b54e2ab", 0, "5af3098a-b37f-4880-88eb-dc36922082c4", "hyena@example.com", false, false, false, null, "HYENA@EXAMPLE.COM", "HYENA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFj4GrnuEK/47r4JFX03RTtv0MafJP7amLiguHrEyviBRSm9UaUU7+4vpFeAh9XboQ==", null, false, "37799397-72b1-4628-abeb-0e64f14dd593", 7, false, "hyena@example.com" },
                    { "b8d64d7f-50da-4a29-addb-3a85f9ad88f8", 0, "763424ae-df04-475a-91f6-da7b25943b70", "sinaasappel@example.com", false, false, false, null, "SINAASAPPEL@EXAMPLE.COM", "SINAASAPPEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAECDzp6P3aWVyKPZzCCHSswNyks+o+aCH1lxEYYvu2fg4Pa5OGFvGEk3a5dSN+mchRg==", null, false, "ee465de7-da79-4fdb-a7c3-261b1c5c29a3", 6, false, "sinaasappel@example.com" },
                    { "c3f22d07-2738-4350-9e31-08479b25cec3", 0, "97db1aa9-552a-4b78-9ad4-57d4c11e200e", "uranus@example.com", false, false, false, null, "URANUS@EXAMPLE.COM", "URANUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAENXiKzucKNsCEAFeMgy7basE45inl4JIIVGIVAUU/GkDAOlxiOnxMvfWm5aK9tkXXg==", null, false, "f0f05c68-9e2e-4f04-a33f-ce4d280ae8c0", 1, false, "uranus@example.com" },
                    { "d9f1bd6f-d22b-4895-8a41-84f85861e87b", 0, "843797d7-bdec-4839-9842-112eaf408b14", "volkswagen@example.com", false, false, false, null, "VOLKSWAGEN@EXAMPLE.COM", "VOLKSWAGEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHwjqPwDVwJ4HYh9RZ2/qz2WMeutKCnRARpfkyMlmi1XJZ+BgmRvj/Ju+o7zeoE0Iw==", null, false, "d6ec2824-e743-4879-900d-a4ce9633a6fa", 3, false, "volkswagen@example.com" },
                    { "df23c1cf-bf3e-4b97-990f-2aa09dc245d3", 0, "8a56525a-1377-456c-b0c7-c5db86e645b3", "volvo@example.com", false, true, false, null, "VOLVO@EXAMPLE.COM", "VOLVO@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIbi8M6IvX/cLl8iOTJuMsLo2dYETazARCsDXHudggpW2I5M23wlFDDNk4JNU5xm+Q==", null, false, "bf9af943-61d2-4688-bea3-1c8ede9dc3b7", 3, false, "volvo@example.com" },
                    { "e51c7525-89e1-4844-8c0c-9cadefa30f0d", 0, "864e7626-18de-4249-a87d-0755d6d2b5dd", "mercurius@example.com", false, false, false, null, "MERCURIUS@EXAMPLE.COM", "MERCURIUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH+3I/C/ep5Yyl3VHpxP4cRqsP5u+7qxpi4W2fcb0ci7ou7fhVQ9xaf97TaX1wkz9A==", null, false, "d51b7143-fa13-4673-af58-a7ec5fbcf726", 1, false, "mercurius@example.com" },
                    { "e51e9790-755f-401d-a35d-295f925b5163", 0, "0eea0b5d-1a08-4b42-bb2f-6960c8216f4d", "toyota@example.com", false, false, false, null, "TOYOTA@EXAMPLE.COM", "TOYOTA@EXAMPLE.COM", "AQAAAAIAAYagAAAAELyuzK5N9ZIR/v3ZhQId11CHTxn7yKgnOAYkaAJw0OP3QzdIkDOdD8pOohSqiSvllA==", null, false, "278124f6-6440-4c17-a340-913b574b92d6", 3, false, "toyota@example.com" },
                    { "ec3a55ae-9170-4046-9245-1ef8a3e69b6f", 0, "3421e05b-6a67-4432-a992-6eb8681be1e7", "dusty@example.com", false, false, false, null, "DUSTY@EXAMPLE.COM", "DUSTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAELtNclygUAfv3IqpD21bFknsmuAydIjo540VrbLzXsEsEmvz59MIiwSYFPLkBGMG6w==", null, false, "acf02061-60b5-44c0-abad-4c065dd01263", 5, false, "dusty@example.com" },
                    { "f5a78858-eb70-4250-852b-573ba2bcf7a6", 0, "a8b90f7e-a930-46fc-9b34-d032ca8620cf", "ferrari@example.com", false, false, false, null, "FERRARI@EXAMPLE.COM", "FERRARI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEG5j/OC9hrAT5QC8jHqfiYCSkUfH5iLgX8hmG2a4GJ37qY4DbmOpxaUHoGXCzhd45g==", null, false, "5ca4582a-a41a-47f0-aed5-b37e13b186f4", 3, false, "ferrari@example.com" },
                    { "fc2b8738-7288-40b3-a0b3-384a61f368a8", 0, "188e655a-0771-4c7f-baaf-576c9dea3ab6", "banaan@example.com", false, true, false, null, "BANAAN@EXAMPLE.COM", "BANAAN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIAfGxF/iPFvb9USQQIcWVXy6ZYrJkmtm6zrvuRQApANgxlpAZSVgVvT4yVOHL9rxQ==", null, false, "00e37568-619f-45ac-b15e-c4a5f6d5e378", 6, false, "banaan@example.com" },
                    { "fc8aee3c-30ce-4718-83b1-48622109c7f3", 0, "e42e6135-4c25-44a8-b55a-784c1069408c", "kiwi@example.com", false, false, false, null, "KIWI@EXAMPLE.COM", "KIWI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIvFvYJxlvFsXeMAszKikgtTWCRyKvgjZhj/pBJ9+uVlRHyRgMl4ND3aX3Z13ATfOA==", null, false, "4cd51ad5-64c4-4932-8880-ed3c2b5292f1", 6, false, "kiwi@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "086fe6d2-a294-4856-a877-fcad0670d1c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a46404e-c572-4fa6-bd56-6b50f3c905ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b1b1fc6-336c-4696-9bce-eb6ea121411c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b3b3c4e-87bf-4de8-a2f2-c119041731ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0efbaefc-8f42-48d5-b7d4-1dc48856c553");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24923f4f-28d2-4d33-b591-fd62eff4ec0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d6017ee-4cec-4193-b22f-9f0476766d6c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fd8b3ba-3639-4796-a2e7-a2b5a01c7c62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4377849e-17ec-40b0-b9e0-5829cd20f99b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4df4c77c-b17b-4004-8313-0f6186197a91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cf817ed-761d-45fa-8dc7-9006f340f073");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62ab27ff-6f66-4365-9322-991dfd9883ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6819b530-01d3-4dbb-8b00-8bc9a62b47f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "681bbf2e-5b68-4275-a863-b120c6ef85bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77f8ae78-85ca-4fb8-af48-a1ee30db55e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8053d965-61fd-41b7-b4c3-8f4781a7a593");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8235138c-558a-453e-8fba-6b74e1aefa66");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85616ac6-cf3c-40bb-931e-96129345323a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86342fd1-a45f-40f1-b9de-c0d2e7b82943");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8afc4855-e9a5-4388-b333-791f8874e653");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b2c9220-0d9d-4c1b-8fb3-5ff1b39b2065");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cf4c124-2484-470b-8d73-c262b81e4a3a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3066c92-7ac9-4d89-b21b-4c395b54e2ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8d64d7f-50da-4a29-addb-3a85f9ad88f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3f22d07-2738-4350-9e31-08479b25cec3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9f1bd6f-d22b-4895-8a41-84f85861e87b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df23c1cf-bf3e-4b97-990f-2aa09dc245d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e51c7525-89e1-4844-8c0c-9cadefa30f0d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e51e9790-755f-401d-a35d-295f925b5163");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec3a55ae-9170-4046-9245-1ef8a3e69b6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5a78858-eb70-4250-852b-573ba2bcf7a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc2b8738-7288-40b3-a0b3-384a61f368a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc8aee3c-30ce-4718-83b1-48622109c7f3");

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
                values: new object[] { "0cd81709-877c-4158-ae03-5b1f9062cd1b", "AQAAAAIAAYagAAAAEC3nbhn9ObHoN6La9pDzgM8HQPQ8AZRVljGKWBpPjjR4dPbPzEhadMOY4U7NVKjm1A==", "b45cc6d7-7dd5-47bf-ab5b-cd11beaea957" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsTeamLeader", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01540c75-7e8f-42fe-a45d-f834e522bef5", 0, "bd8f7adf-00b3-498b-8d9d-e8322e6daf1e", "aarde@example.com", false, true, false, null, "AARDE@EXAMPLE.COM", "AARDE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEN1UOoT61rFzqOQ6/p/9/QzLkwLf0RZNC7H9bsILun9ey5HwZWZYSTgKsCCNrD6TaA==", null, false, "2f8cb2d5-615d-4c00-85e6-1844ceaced58", 1, false, "aarde@example.com" },
                    { "07c46f13-8296-4bef-9860-f0559a355b64", 0, "b5b27b04-b30b-4ad3-832b-34bd3b594515", "rusty@example.com", false, false, false, null, "RUSTY@EXAMPLE.COM", "RUSTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAENJbb4TFIoBbDwXcU7FmmHgAPbQAnqeT5OXUmXo9i6OZUpQ4ZYp0uonRx2XtOX02gA==", null, false, "5c735b1b-1303-4d94-8c26-e57bb4e41080", 5, false, "rusty@example.com" },
                    { "08f76bd8-f14e-4a00-8a47-92d160e856f4", 0, "53598ea9-8e7c-4f7b-afe1-66d042ddbb87", "mercedes@example.com", false, false, false, null, "MERCEDES@EXAMPLE.COM", "MERCEDES@EXAMPLE.COM", "AQAAAAIAAYagAAAAELp5UtO9kUzcdCAaAfAQhIJ7A67Yw6L74Np/x6CmksWRs+49+Pgjorn54pGaMS4LUg==", null, false, "cf5f3542-09ae-4167-b900-af0cfa4038d6", 3, false, "mercedes@example.com" },
                    { "0b180b65-9138-45b3-b844-88cb39d88c40", 0, "368a1e92-1414-4797-a75a-a53a0321c93b", "waterzwijn@example.com", false, true, false, null, "WATERZWIJN@EXAMPLE.COM", "WATERZWIJN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHxq6sqS4bW5TJPOX6QC2mYyC5p0NSriiya/lxu8RJWJ8vuHvl40+CW6NjSI50YOgw==", null, false, "291fa7f3-a9f5-4d93-8ee4-5bfe63067526", 7, false, "waterzwijn@example.com" },
                    { "108eeebb-7eb8-450e-ab15-ae92e1e05849", 0, "999bc8ad-4589-4fa2-8494-42887c09dcec", "avocado@example.com", false, false, false, null, "AVOCADO@EXAMPLE.COM", "AVOCADO@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIyxyxIrUWjwx9wFaVvzg8Z/0wjhq/zJMNrSrs+wkUMc+ofBP0bzduagfsBwh83mZQ==", null, false, "b44897d9-0f4a-42c0-a935-77ff5943e281", 6, false, "avocado@example.com" },
                    { "2422bd80-04c4-4bec-8d9f-02e50f676bba", 0, "c6a1469e-4203-4084-ba1c-b28c7e4ca081", "kiwi@example.com", false, false, false, null, "KIWI@EXAMPLE.COM", "KIWI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPoiYzj5WAo6OZuz1t1YNS11+/QFdtptUbR/6ZYeyY+sxqE49uyoeCnnzWYj7gR4UA==", null, false, "cfca8d75-d3de-405a-b991-0ec3eb4d9797", 6, false, "kiwi@example.com" },
                    { "27d722f3-68f7-42a3-905a-52098e566c51", 0, "8708e997-b52a-42ce-8059-ce22377fbc4d", "breakout@example.com", false, false, false, null, "BREAKOUT@EXAMPLE.COM", "BREAKOUT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPKlN2WxyFS0fCdNMouXNEGUsecIb5f0gjhV1iHTyrpE388HQryXpbUXGLJ2wjV4SA==", null, false, "36fd0c1e-8215-47b1-98a7-99700471dca1", 2, false, "breakout@example.com" },
                    { "2b98acb7-6027-4f54-943f-f977ea8b6df6", 0, "fa94920e-0f1b-414b-9b85-6ffe74a808bc", "citroen@example.com", false, false, false, null, "CITROEN@EXAMPLE.COM", "CITROEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKknH5xNi8rNfar0KmtZQb/HdAboEpj97tH9N3L2zaquOHkulloqxRcmVt8k2k7/rQ==", null, false, "668daa9d-0152-4a4d-b105-c5f8a6d78e0e", 6, false, "citroen@example.com" },
                    { "55c8442a-4198-4e28-b035-d7c39e3ef855", 0, "0fc1bb2b-d6ea-422a-bfa1-3dc7e224420a", "toyota@example.com", false, false, false, null, "TOYOTA@EXAMPLE.COM", "TOYOTA@EXAMPLE.COM", "AQAAAAIAAYagAAAAENRVMHnkjnRShigBIa0IvZOdyzcFDCxjCmihk+IEnEoolPSbDMN7Zd0kgYcDb833sw==", null, false, "7f136529-a29b-43ce-bcdc-bef50d61d8be", 3, false, "toyota@example.com" },
                    { "562c2c81-e901-4b1c-8c28-a11c5b671787", 0, "3022900c-a0d8-4926-88d3-73ce33e8c657", "jupiter@example.com", false, false, false, null, "JUPITER@EXAMPLE.COM", "JUPITER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEA9bih8pkTL+jOH4WVy05x9gFYav0MquxgL2f+bfwJIC2HZ7dwtTn9IiJS1t54xZtQ==", null, false, "1074c2e6-f3c7-49a1-a6b7-74f70ab16844", 1, false, "jupiter@example.com" },
                    { "56b624f7-15de-4965-9ed2-f5ce745c2427", 0, "1a55d634-a1da-4f6e-b83f-6e34538e8603", "ferrari@example.com", false, false, false, null, "FERRARI@EXAMPLE.COM", "FERRARI@EXAMPLE.COM", "AQAAAAIAAYagAAAAED7eIz0eD3eERK+6GFmAiYM4hOZ6uXMh32lAZSVQDgodKYO4+XFLrwz2apfR9Vy0Jw==", null, false, "91a9ff48-3b84-44b0-af8f-3705254a5cd3", 3, false, "ferrari@example.com" },
                    { "58ad7c06-e494-4411-8537-4480fc28f516", 0, "7aaa03b4-2ddf-4230-a423-8c3a91e7e675", "volkswagen@example.com", false, false, false, null, "VOLKSWAGEN@EXAMPLE.COM", "VOLKSWAGEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIQYeb8511Cioz4kM/RpABpn1cBmy5NgoQAWuRaMRmTDc2cgiVUCXds3pml2vwMBpw==", null, false, "337ed4e0-726e-4059-994b-ae55faf18ca3", 3, false, "volkswagen@example.com" },
                    { "5efb9286-2103-4ca2-91c1-d612fbfac094", 0, "7ea8b90c-707d-4f7f-905d-0f3bb3be6383", "hyena@example.com", false, false, false, null, "HYENA@EXAMPLE.COM", "HYENA@EXAMPLE.COM", "AQAAAAIAAYagAAAAENBgiYim4/luw/VPORJQX04baegpTqP1XAJpbTQa7800pLaN0zLfU+b385iIkpCZGg==", null, false, "1c6aa81a-07af-4d01-ad30-0b7b5ea9d30e", 7, false, "hyena@example.com" },
                    { "60b05027-c941-40c8-a68e-a004a54b1016", 0, "99adca0f-3ec3-4135-b9f4-08c63c7f2205", "sinaasappel@example.com", false, false, false, null, "SINAASAPPEL@EXAMPLE.COM", "SINAASAPPEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEApF/FUJKviihkA25qSn+8Bzew3YpJKTWERpj1yNsMBGcCCvBPIUGEXglzAHEU3Wrg==", null, false, "daeec8e8-f569-476e-9c9d-f0d4b54d6c48", 6, false, "sinaasappel@example.com" },
                    { "64bfd85e-31eb-4ed7-92ee-d71a83a7e37a", 0, "f2d85dc7-1902-4ed4-829e-2827d538bff9", "saturnus@example.com", false, false, false, null, "SATURNUS@EXAMPLE.COM", "SATURNUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAIHRYTW8W4ZGhr1nOO7o1zuUndcWV6r6qcrQqKrBj3p6vstDv+ubVRdAoCXbB/oIw==", null, false, "da095293-67f2-449d-bc7a-5c6e7f4c260e", 1, false, "saturnus@example.com" },
                    { "721c20ff-5d34-4c4f-a9fc-59658476912f", 0, "d0153ee5-e1c9-4b3b-a4fb-da24ec7684d4", "octane@example.com", false, true, false, null, "OCTANE@EXAMPLE.COM", "OCTANE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAbx3tixX5KNlFV9ozmiBK4i7c7LjCEV0melLlJZ6VIMkOY5wviPiZgVvCX5MVWhkw==", null, false, "cfaf3b8b-0517-4ecd-8b92-c8480d8f34a2", 2, false, "octane@example.com" },
                    { "75051934-a5f1-426e-8a73-04f0b6772583", 0, "a7356cdf-a660-4c3b-8bc1-11ee7586cc89", "mcqueen@example.com", false, true, false, null, "MCQUEEN@EXAMPLE.COM", "MCQUEEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAECgDivAj73ADyWMmlG2FO0hhsexy8xcnfx33f368yBGeNXysqstc1cUuN9RHZhR5zA==", null, false, "8bac177b-1871-44bc-8d8c-b15492d32dcd", 5, false, "mcqueen@example.com" },
                    { "87fbf155-60c1-4e49-a762-e3aa4575a27f", 0, "50b2bdf0-7f19-4ff0-93b9-be57fbcb873f", "dusty@example.com", false, false, false, null, "DUSTY@EXAMPLE.COM", "DUSTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIrDZJO8ZT0upBcxulClkN8zxl7uQJGkmsc1iXWjy3s9fJAVfTAGBOsCVWg34GyBeg==", null, false, "5da114b9-a5e1-472d-8e33-6a2a5218b87c", 5, false, "dusty@example.com" },
                    { "94936367-a01f-4f75-b8ef-b53313ba9519", 0, "cba5908e-ebb8-4b13-899c-207054c5f044", "mercurius@example.com", false, false, false, null, "MERCURIUS@EXAMPLE.COM", "MERCURIUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEKEet3UcoZzeN2BbeJY3mdDjgB/e5EF+Pb1VNQGaE2284LYsoJlDwtVLUAfiatLww==", null, false, "3f35723a-f42e-4144-81a3-cc95acc2ba8b", 1, false, "mercurius@example.com" },
                    { "96633b4c-cb12-41d8-8c04-fdadb59c7964", 0, "68d1ba45-16ec-4b39-a9e1-b98d0ba6ac33", "banaan@example.com", false, true, false, null, "BANAAN@EXAMPLE.COM", "BANAAN@EXAMPLE.COM", "AQAAAAIAAYagAAAAECaTCXY1/T0ifO/7zMnSxSbfZUxnXt1bGUtAhxAu4VibncGXxQWaUTR7Ndj2Qnq3bw==", null, false, "d280ee9d-6ed1-44bf-925b-da866734b921", 6, false, "banaan@example.com" },
                    { "9a718130-42f1-4001-a0cc-0ffe65407ed2", 0, "54209ca1-8281-449c-a838-2393218d4e23", "huiskat@example.com", false, false, false, null, "HUISKAT@EXAMPLE.COM", "HUISKAT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAMr2T5gNGA0JdCvEK4jM/GNPocFGSmb4u2UB0LqnvRnXfkye6lX5eTJR1JqvYQ3xA==", null, false, "140317fa-acf5-462e-b269-3f0161ca8b55", 7, false, "huiskat@example.com" },
                    { "9b5b1d0c-1c8a-4f74-bac4-57f1d0e85ef5", 0, "672c9ccc-6f0d-456e-b8cc-8c2ce8bdf9da", "watermeloen@example.com", false, false, false, null, "WATERMELOEN@EXAMPLE.COM", "WATERMELOEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBq0apSDP12W+EzpEmqdgzof4rIr8KGpTVPtO1qHQW5XnaZOpH5oKOdFacaL3a/+PA==", null, false, "99843410-6491-4f8c-9f9e-c3b5026ca20f", 6, false, "watermeloen@example.com" },
                    { "9ff5e509-31f7-4c39-a5c9-f42b1f10287d", 0, "a5f55465-8fab-4113-82ca-3c14e20eb5b3", "venus@example.com", false, false, false, null, "VENUS@EXAMPLE.COM", "VENUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGV1aGb44RVO+sTMJw0GbA5bTinwODKXwJbUSDa11KxtXk6mHW4qGoB9wchITbMWeQ==", null, false, "5a0f72d3-e581-4f68-be74-8883d32c9fc5", 1, false, "venus@example.com" },
                    { "a80b61a4-da7a-49c1-a390-c15730c4e794", 0, "f52e486e-c5b0-4590-ad50-c243e2acd7d7", "appel@example.com", false, false, false, null, "APPEL@EXAMPLE.COM", "APPEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAELugvI/7KiNt7x0mwjVXKqHSBPk+CTZrepMXBqRNrGY4WPaUYRGyHG2/wtixjeUSFw==", null, false, "a636f0a5-d37e-45bd-87f1-a2ee15514f75", 6, false, "appel@example.com" },
                    { "a96c3d9c-1304-43ce-946a-0e4c5a51804b", 0, "964ddf89-cb2d-4f74-8835-fe4467e5b815", "uranus@example.com", false, false, false, null, "URANUS@EXAMPLE.COM", "URANUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMQ9F8KPLAVnX+JmOLOywhBMlOsWLBX8vYkyC/gQMJ6xvRvwkNDZApGXc3y8eR+JKw==", null, false, "30c9109d-3762-4237-a210-266d79a90ca4", 1, false, "uranus@example.com" },
                    { "b4bb479c-678a-4fcc-9b15-7973ba035c31", 0, "27ee18f2-44fc-4e5a-8d30-b8a51b92a23b", "neptunes@example.com", false, false, false, null, "NEPTUNES@EXAMPLE.COM", "NEPTUNES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMFvtHKkBzMO9Jrdf7PbsNSyQigrMO345Ivg6YYhQoR/p4biiSM/nQQjBVSchL3NNA==", null, false, "098ca4cb-adc3-4b76-9954-8b4b0ec03549", 1, false, "neptunes@example.com" },
                    { "b66826b2-ec13-440e-8135-704a23a03fd9", 0, "3936a4f8-d0e3-4c01-911d-324673ba48a5", "mars@example.com", false, false, false, null, "MARS@EXAMPLE.COM", "MARS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH3GoXY6FuOXimcfwXwhIIenouN8sQghyRJ52v+LzXmXK9IFMIUMgVE8IIyCm09Caw==", null, false, "91668b00-c57b-4177-ae8d-c53ffe66df44", 1, false, "mars@example.com" },
                    { "ba643c0e-6ba7-4297-88bd-cc53a5634d1e", 0, "dae1053a-4e5a-4136-859d-afef0c3b6ca9", "dominus@example.com", false, false, false, null, "DOMINUS@EXAMPLE.COM", "DOMINUS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPJidYpXbR+qVzU3DLPpC895II0RgepE27CgnqcjbeO0ZTzK7f8yTeyzk1aHeoraNw==", null, false, "e21994a7-74c4-466a-8236-4d75735bacd5", 2, false, "dominus@example.com" },
                    { "d43f9978-34db-440d-b546-4bf308b8936a", 0, "90fffb20-4394-4b54-b45e-b9b9d1ce2c83", "fennec@example.com", false, false, false, null, "FENNEC@EXAMPLE.COM", "FENNEC@EXAMPLE.COM", "AQAAAAIAAYagAAAAECn8cvhA1CEBszwqzusYBLqxyDViCWdWhxXOhdvJ1XbWZgm7IM1Aio+zA7B3UZezVA==", null, false, "e11ae1c1-4056-4cc6-9bdb-c7f9b32703f5", 2, false, "fennec@example.com" },
                    { "f03d148e-5e52-415d-bc12-cb9b88782b8f", 0, "6b9b73dd-c5f0-4ba1-93e2-4d08fa9e2d00", "mack@example.com", false, false, false, null, "MACK@EXAMPLE.COM", "MACK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIQjp/Nm1QNahK/NySlkUDngYuBb5aY48QJIKiJ6tZ33LC8QIfJuepbEbuDFN4O+4Q==", null, false, "f075ee12-ebc2-4ebd-9f6d-2a3e3e1b0df6", 5, false, "mack@example.com" },
                    { "f0bd370f-e9bf-4223-b9ea-1b70cb6cb16c", 0, "a4c9e56e-6f46-4246-bfde-e4b2e1a4bc78", "peer@example.com", false, false, false, null, "PEER@EXAMPLE.COM", "PEER@EXAMPLE.COM", "AQAAAAIAAYagAAAAENF45GehAFb/aiRKaz6PDXU7Z8+BTHqUfajYQ4ZHqfekjJl4Tl9ZNqhwmob8pslptQ==", null, false, "7d9a36c2-5047-499f-8527-28319f7a7d28", 6, false, "peer@example.com" },
                    { "f743b192-1832-4116-a652-91c1e35f1b1d", 0, "3d2e2408-a10c-49e0-bfa7-4c2a47af865d", "bruce@example.com", false, true, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMOeQZxRvsoDRawbdhoK55yWrfhq1QKac814PXQQP2KakwgBvLcO+SldJzFWyomBIA==", null, false, "91800a7a-f935-4eb3-a23e-5ed0c1a30798", 4, false, "bruce@example.com" },
                    { "fb1c6af6-c657-416a-bedd-7c0afa8cdc22", 0, "f8f9ed08-c1ba-48a3-8396-b5d49cf989e1", "volvo@example.com", false, true, false, null, "VOLVO@EXAMPLE.COM", "VOLVO@EXAMPLE.COM", "AQAAAAIAAYagAAAAEL+vxOJKfnW4WLmMPdJ4rzILQtec3m0RVZjY7B/g2RU0Ygtge1Xt2aUQMBcYyaTfkg==", null, false, "45ea7870-f477-495f-8ad1-56c12b99953a", 3, false, "volvo@example.com" }
                });
        }
    }
}
