using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTrackingSystem.Infrastructure.Migrations
{
    public partial class TrainerPropAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Biography",
                table: "Trainers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d568275-74cc-45b8-89d7-f7356b9ceb37", "AQAAAAEAACcQAAAAEH9expDH9Kgyc3JEbihIdda2QNAcXtb4ZL7rdarNsACJHhguFAvdXZxDbbnSldT+3g==", "66821c3c-ef55-46eb-babb-62a0b0efa054" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48fa921d-5a1f-427c-a05d-294ca937cefd", "AQAAAAEAACcQAAAAENaIDnJm8VZRbQIG5x7S1nHuQMyf9QD4PYZful2DoNVHYQzaou8pObYqdrDwcAJwqw==", "1c6ea5e5-65ab-4418-a592-12d8da26af12" });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 22, 20, 12, 52, 476, DateTimeKind.Local).AddTicks(7102), new DateTime(2024, 3, 22, 20, 12, 52, 476, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 22, 20, 12, 52, 476, DateTimeKind.Local).AddTicks(7111), new DateTime(2024, 3, 22, 20, 12, 52, 476, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 22, 20, 12, 52, 476, DateTimeKind.Local).AddTicks(7119), new DateTime(2024, 3, 22, 20, 12, 52, 476, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Biography",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Biography",
                table: "Trainers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee7242f6-ca33-4d15-8c54-573e7868bcdc", "AQAAAAEAACcQAAAAEOWhGMXy3m91mfgAXLmHo1qsWJFsrSUdsjC2JVDMTXVQN76jfszK3SHHhqIfPnuhNQ==", "9e23d7b4-2c21-47ea-9e95-8ae05f5c1d55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fb55760-d28a-4fc9-a5be-564b203951ec", "AQAAAAEAACcQAAAAEEOFzm4rCbTYPDFp5NuMx19fgN+JYsTbsdCgOkwH/x5rfm+LZEp4ZgIW47QbW2QOPw==", "459acf34-da5f-4723-86ba-b27dc899dfc4" });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 23, 30, 370, DateTimeKind.Local).AddTicks(8785), new DateTime(2024, 3, 21, 16, 23, 30, 370, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 23, 30, 370, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 3, 21, 16, 23, 30, 370, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 23, 30, 370, DateTimeKind.Local).AddTicks(8793), new DateTime(2024, 3, 21, 16, 23, 30, 370, DateTimeKind.Local).AddTicks(8792) });
        }
    }
}
