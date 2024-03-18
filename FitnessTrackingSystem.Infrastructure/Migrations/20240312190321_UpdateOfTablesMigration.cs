using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTrackingSystem.Infrastructure.Migrations
{
    public partial class UpdateOfTablesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Challenges",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1d1d44f-26d1-4c8f-9cb4-9b4a1a4bb82e", "AQAAAAEAACcQAAAAEC22oTfzBANF37VyFi6eAuemtuA84uzzue7xqF+T32iiEAwcBL84DGM5qAiZDB6QJA==", "27996c01-9da9-4427-8225-8175373c0dcd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08c85a49-11cf-4a12-9dc0-b9d57d1678da", "AQAAAAEAACcQAAAAELY2W7V/PzigKvaP3CiqnZ72LTRKjznjNkb32jcOba/BvE6L31nr1TOKGnss89smUw==", "1b861585-2eb8-40c6-92d6-82c845e2ae82" });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "End", "Start", "VideoUrl" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 3, 20, 491, DateTimeKind.Local).AddTicks(3472), new DateTime(2024, 3, 12, 21, 3, 20, 491, DateTimeKind.Local).AddTicks(3412), "" });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "End", "Start", "VideoUrl" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 3, 20, 491, DateTimeKind.Local).AddTicks(3480), new DateTime(2024, 3, 12, 21, 3, 20, 491, DateTimeKind.Local).AddTicks(3477), "" });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "End", "Start", "VideoUrl" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 3, 20, 491, DateTimeKind.Local).AddTicks(3487), new DateTime(2024, 3, 12, 21, 3, 20, 491, DateTimeKind.Local).AddTicks(3484), "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Challenges");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9f9eb47-4121-4359-abcc-4ee0bb2b495b", "AQAAAAEAACcQAAAAEMkbVhCGBL8YutF4q1rYKI5mdWwDCrBWHW0QNUe3Y2DVKZV0Ixhudt0LDSqYXXpLuQ==", "6429cd43-73f5-4d7c-a070-cf4c13e42b3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24bce7e3-f45e-40b9-b562-22148614b47a", "AQAAAAEAACcQAAAAEGtj+QVqE2ESEtPLErTaH5bPY4KyEVLJ7BPlwup1eoWNm4PSsJV0iYHXIhOdPMh0zQ==", "84c56c3a-2a77-4a73-a3e2-544e3686df51" });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 3, 15, 18, 52, 494, DateTimeKind.Local).AddTicks(9271), new DateTime(2024, 3, 3, 15, 18, 52, 494, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 3, 15, 18, 52, 494, DateTimeKind.Local).AddTicks(9276), new DateTime(2024, 3, 3, 15, 18, 52, 494, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 3, 15, 18, 52, 494, DateTimeKind.Local).AddTicks(9279), new DateTime(2024, 3, 3, 15, 18, 52, 494, DateTimeKind.Local).AddTicks(9278) });
        }
    }
}
