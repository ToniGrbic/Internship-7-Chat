using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatApp.Data.Migrations
{
    public partial class newDatabaseWithSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "GroupName" },
                values: new object[,]
                {
                    { 1, "DUMP" },
                    { 2, "fesb" },
                    { 3, "pmf" },
                    { 4, "family" },
                    { 5, "friends" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "IsAdmin", "Password", "UserName" },
                values: new object[] { "ivaIvic23@gmail.com", false, "pass123", "IvaIvic23" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsAdmin", "IsLogged", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "anteAdmin@gmail.com", true, false, "123456", "AnteAdmin" },
                    { 2, "tonigrbic@gmail.com", false, false, "pass123", "ToniGrbic" },
                    { 3, "matematic@gmail.com", false, false, "pass123", "Matematic" },
                    { 4, "anteantic1@gmail.com", false, false, "pass123", "AnteAntic1" },
                    { 5, "ivoIvic@gmail.com", false, false, "pass123", "IvoIvic" },
                    { 6, "anaAnjic@gmail.com", true, false, "pass123", "AnaAnjic" },
                    { 8, "mateaMatic2@gmail.com", false, false, "pass123", "MateaMatic2" },
                    { 9, "simesimic@gmail.com", false, false, "pass123", "SimeSimic" },
                    { 10, "antonioAntic12@gmail.com", false, false, "pass123", "AntonioAntic12" },
                    { 11, "josipJosipovic@gmail.com", false, false, "pass123", "JosipJosipovic" }
                });

            migrationBuilder.InsertData(
                table: "GroupMessages",
                columns: new[] { "Id", "GroupID", "MessageText", "SenderUserID", "SentDate" },
                values: new object[,]
                {
                    { 1, 1, "Hello everyone!", 1, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5864) },
                    { 2, 1, "Yo yo whats up guys?", 2, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5905) },
                    { 3, 1, "Merry Christmas everyone!", 3, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5908) },
                    { 4, 1, "Happy ne year!", 4, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5911) },
                    { 5, 1, "yoyoyo whatsup!", 5, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5915) },
                    { 6, 1, "Good, what about you?", 6, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5918) },
                    { 7, 1, "How is the project going?", 7, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5926) },
                    { 8, 2, "How is the wheather?", 1, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5930) },
                    { 9, 2, "Very good! its sunny.", 2, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5943) },
                    { 10, 2, "Happy new year everyone!", 3, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5946) },
                    { 11, 2, "yoyo whatsup, happy new year aswell!", 4, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5954) },
                    { 12, 2, "all the best in the new year everyone!", 5, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5957) },
                    { 13, 2, "Happy new year!", 6, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5960) },
                    { 14, 2, "Hello, also wishing everyone the best", 7, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5963) },
                    { 15, 3, "hey does anyone wanna hang out tonight?", 8, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5966) },
                    { 16, 3, "Sure, im free tonight!", 9, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5987) },
                    { 17, 3, "I cant, im busy tonight.", 10, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5991) },
                    { 18, 3, "I can, but im really tired today.", 11, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5994) },
                    { 19, 4, "yoyo whatsup everyone!", 4, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(5997) },
                    { 20, 4, "good, what about you?", 5, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6000) },
                    { 21, 4, "Im fine, just working a lot lately", 6, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6003) },
                    { 22, 4, "Hello, im doing good", 7, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6006) },
                    { 23, 5, "Where would you like to travel next guys?", 5, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6009) },
                    { 24, 5, "I would like to go to Italy", 6, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6012) },
                    { 25, 5, "I would like to go to Spain", 7, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6015) },
                    { 26, 5, "I would like to go to France", 8, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6018) },
                    { 27, 5, "I would also love to go to France", 9, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6022) },
                    { 28, 5, "Me too!", 10, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6025) },
                    { 29, 5, "Then France it is?", 11, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6078) },
                    { 30, 1, "Helloooo!", 1, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6087) },
                    { 31, 1, "Hello helooo!", 2, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6130) },
                    { 32, 1, "Hello yoyooy!", 3, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6133) },
                    { 33, 1, "Hello whats upp!", 4, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6137) },
                    { 34, 1, "yoyoyo whatsup!", 5, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6140) }
                });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 5, 8 },
                    { 5, 9 },
                    { 5, 10 },
                    { 5, 11 }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "Id", "MessageText", "ReceiverUserID", "SenderUserID", "SentDate" },
                values: new object[,]
                {
                    { 1, "Hello, how are you?", 2, 1, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6169) },
                    { 2, "Im good, what about you?", 1, 2, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6173) },
                    { 3, "Im good aswell, just working a lot lately", 2, 1, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6176) },
                    { 4, "Hello, how are you?", 3, 1, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6179) },
                    { 5, "Im good, what about you?", 1, 3, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6182) },
                    { 6, "Im good aswell, just working a lot lately", 3, 1, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6185) },
                    { 7, "Hello, how are you?", 4, 1, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6188) },
                    { 8, "Im good, what about you?", 1, 4, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6191) },
                    { 9, "Im good aswell, just working a lot lately", 4, 1, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6194) },
                    { 10, "Hello, how are you?", 5, 1, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6197) },
                    { 11, "Im good, what about you?", 1, 5, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6200) },
                    { 12, "Im good aswell, just working a lot lately", 5, 1, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6203) },
                    { 13, "Hello, how are you?", 6, 1, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6206) },
                    { 14, "Im good, what about you?", 1, 6, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6209) },
                    { 15, "Im good aswell, just working a lot lately", 6, 1, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6212) },
                    { 16, "Hello, how are you?", 7, 1, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6215) },
                    { 17, "Im good, what about you?", 1, 7, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6219) },
                    { 18, "Im good aswell, just working a lot lately", 7, 2, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6222) },
                    { 19, "Hello, how are you?", 3, 2, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6225) },
                    { 20, "Im good, what about you?", 2, 3, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6228) },
                    { 21, "Im good aswell, just working a lot lately", 3, 2, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6231) },
                    { 22, "Hello, how are you?", 4, 2, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6234) },
                    { 23, "Im good, what about you?", 2, 4, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6237) },
                    { 24, "Im good aswell, just working a lot lately", 4, 2, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6239) },
                    { 25, "Hello, how are you?", 5, 2, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6242) },
                    { 26, "Im good, what about you?", 2, 5, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6245) },
                    { 27, "Im good aswell, just working a lot lately", 5, 2, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6248) },
                    { 28, "Hello, how are you?", 6, 2, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6251) },
                    { 29, "Im good, what about you?", 2, 6, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6254) },
                    { 30, "Im good aswell, just working a lot lately", 6, 2, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6257) },
                    { 31, "Hello, how are you?", 7, 2, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6260) },
                    { 32, "Im good, what about you?", 2, 7, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6263) },
                    { 33, "Im good aswell, just working a lot lately", 7, 2, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6266) },
                    { 34, "Hello, how are you?", 4, 3, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6269) },
                    { 35, "Im good, what about you?", 3, 4, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6272) },
                    { 36, "Im good aswell, just working a lot lately", 4, 3, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6275) },
                    { 37, "Hello, how are you?", 5, 3, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6278) },
                    { 38, "Im good, what about you?", 3, 5, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6281) },
                    { 39, "Im good aswell, just working a lot lately", 5, 3, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6284) },
                    { 40, "Hello, how are you?", 6, 3, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6286) },
                    { 41, "Im good, what about you?", 3, 6, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6289) },
                    { 42, "Im good aswell, just working a lot lately", 6, 3, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6292) },
                    { 43, "Hello, how are you?", 7, 3, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6295) },
                    { 44, "Im good, what about you?", 3, 7, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6298) },
                    { 45, "Im good aswell, just working a lot lately", 7, 3, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6301) },
                    { 46, "Hello, how are you?", 5, 4, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6304) },
                    { 47, "Im good, what about you?", 4, 5, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6307) },
                    { 48, "Im good aswell, just working a lot lately", 5, 4, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6310) },
                    { 49, "Hello, how are you?", 6, 4, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6313) },
                    { 50, "Im good, what about you?", 4, 6, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6316) },
                    { 51, "Im good aswell, just working a lot lately", 6, 4, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6319) },
                    { 52, "Hello, how are you?", 7, 4, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6322) },
                    { 53, "Im good, what about you?", 4, 7, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6325) },
                    { 54, "Im good aswell, just working a lot lately", 7, 4, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6328) },
                    { 55, "Hello, how are you?", 6, 5, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6331) },
                    { 56, "Im good, what about you?", 5, 6, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6334) },
                    { 57, "Im good aswell, just working a lot lately", 6, 5, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6336) },
                    { 58, "Hello, how are you?", 7, 5, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6339) },
                    { 59, "Im good, what about you?", 5, 7, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6343) },
                    { 60, "Im good aswell, just working a lot lately", 7, 5, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6345) },
                    { 61, "Hello, how are you?", 7, 6, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6348) },
                    { 62, "Im good, what about you?", 6, 7, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6351) },
                    { 63, "Im good aswell, just working a lot lately", 7, 6, new DateTime(2024, 1, 4, 1, 58, 40, 919, DateTimeKind.Local).AddTicks(6354) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PrivateMessages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "IsAdmin", "Password", "UserName" },
                values: new object[] { "anteAdmin@gmail.com", true, "123456", "AnteAdmin" });
        }
    }
}
