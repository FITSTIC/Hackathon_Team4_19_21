using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fitstic_Hackathon_4.Migrations
{
    public partial class RelDb_CorsoId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TabDocenti",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 17, 17, 59, 30, 613, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "TabDocenti",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 17, 17, 59, 30, 613, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "TabOrganizzatori",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 17, 17, 59, 30, 612, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "TabOrganizzatori",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 17, 17, 59, 30, 612, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "TabTutor",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 17, 17, 59, 30, 606, DateTimeKind.Local).AddTicks(9815));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TabDocenti",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 14, 11, 24, 45, 414, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "TabDocenti",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 14, 11, 24, 45, 414, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "TabOrganizzatori",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 14, 11, 24, 45, 413, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "TabOrganizzatori",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 14, 11, 24, 45, 413, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "TabTutor",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 14, 11, 24, 45, 408, DateTimeKind.Local).AddTicks(902));
        }
    }
}
