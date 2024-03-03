using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTrackingSystem.Infrastructure.Migrations
{
    public partial class DataSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1e229cb-6bfd-4b39-8004-1dbc8a7d52eb", "AQAAAAEAACcQAAAAEM5blk32lPIEFcV8hcNSLmXS1o2W+WXAUZF3gKsxypKLAGbdfHQCimHhhW2RS5Ye4w==", "5756dfb1-b527-4eff-ba2b-f1a72b2428f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0ce1dc1-4ee7-4da0-bffc-f1f60411060f", "AQAAAAEAACcQAAAAEAo+PltbSBZ+W5Sv0XvaUPN+B1GJhOTMPeVWvX9O1eEd60VbTjiNzwN5nTB5COJpTg==", "59ac9354-f830-48eb-8a94-91e9a378b2e7" });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 3, 14, 4, 24, 155, DateTimeKind.Local).AddTicks(4697), new DateTime(2024, 3, 3, 14, 4, 24, 155, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 3, 14, 4, 24, 155, DateTimeKind.Local).AddTicks(4702), new DateTime(2024, 3, 3, 14, 4, 24, 155, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 3, 14, 4, 24, 155, DateTimeKind.Local).AddTicks(4705), new DateTime(2024, 3, 3, 14, 4, 24, 155, DateTimeKind.Local).AddTicks(4704) });
        }
    }
}
