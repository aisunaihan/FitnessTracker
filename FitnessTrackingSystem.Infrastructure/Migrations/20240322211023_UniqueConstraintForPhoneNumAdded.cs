using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTrackingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f940a460-f293-4f11-a43f-817b09ca87af", "AQAAAAEAACcQAAAAEGU7UI4aHHSAMxAJAGEiWkqpH2mrs4KS26LN35m61nNEbkQG7l5UpVSNXpCbBTUd9g==", "21af6f05-1425-4a41-b7b7-9ff82493b8ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dc1839c-d9cb-457d-ae58-f3e47fc690e1", "AQAAAAEAACcQAAAAENTKyjfiT7Isvfhlojuh6U4sZy4ePXUM4C8ShKlhpvNkHTU2tptW/MW1aBta0aPX7g==", "4c54359b-3776-4712-bb23-0cddea2a8f55" });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 22, 23, 10, 23, 291, DateTimeKind.Local).AddTicks(284), new DateTime(2024, 3, 22, 23, 10, 23, 291, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 22, 23, 10, 23, 291, DateTimeKind.Local).AddTicks(292), new DateTime(2024, 3, 22, 23, 10, 23, 291, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2024, 3, 22, 23, 10, 23, 291, DateTimeKind.Local).AddTicks(298), new DateTime(2024, 3, 22, 23, 10, 23, 291, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Biography",
                value: "I am a fitness trainer.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
