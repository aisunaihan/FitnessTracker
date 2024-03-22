using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTrackingSystem.Infrastructure.Migrations
{
    public partial class ClassesChangesMade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Videos");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "392c2a5e-e963-4da4-9244-97984bb6b49d", "AQAAAAEAACcQAAAAEFI5wDXZhbB5Tu9nni+m7fMZYeqcbEkw3Fo6ilYrZESCx5I4jdCmeFY9Bt+d2EFqFQ==", "95ec4300-38e2-4d3d-9aec-79a567d2affb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41448e32-ceec-4513-8f1b-700f4bfc02cb", "AQAAAAEAACcQAAAAEB0hNM9JOEUbX7Esf4cZXz1Tp2Cwjxh9FQYgQPE2GVp/2UBxxG0qGk9Ci6izmnTVSw==", "eeca5b5c-ac0f-4ff4-9131-77ba5eabaec5" });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 20, 16, 22, DateTimeKind.Local).AddTicks(5961), new DateTime(2024, 3, 21, 16, 20, 16, 22, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 20, 16, 22, DateTimeKind.Local).AddTicks(5975), new DateTime(2024, 3, 21, 16, 20, 16, 22, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 20, 16, 22, DateTimeKind.Local).AddTicks(5981), new DateTime(2024, 3, 21, 16, 20, 16, 22, DateTimeKind.Local).AddTicks(5979) });
        }
    }
}
