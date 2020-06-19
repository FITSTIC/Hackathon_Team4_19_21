using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fitstic_Hackathon_4.Migrations
{
    public partial class relDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "TabEsami",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TabDocenti",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 19, 15, 16, 33, 229, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "TabDocenti",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 19, 15, 16, 33, 229, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "TabOrganizzatori",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 19, 15, 16, 33, 228, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "TabOrganizzatori",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 19, 15, 16, 33, 228, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "TabTutor",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 19, 15, 16, 33, 222, DateTimeKind.Local).AddTicks(8976));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "TabEsami");

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
    }
}
