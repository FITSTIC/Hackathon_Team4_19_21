using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fitstic_Hackathon_4.Migrations
{
    public partial class RelDb_TabCorso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OrganizzatoreId",
                table: "TabCorsi",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "TabOrganizzatori",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 13, 10, 33, 42, 828, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "TabTutor",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 13, 10, 33, 42, 822, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.CreateIndex(
                name: "IX_TabCorsi_OrganizzatoreId",
                table: "TabCorsi",
                column: "OrganizzatoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_TabCorsi_TabOrganizzatori_OrganizzatoreId",
                table: "TabCorsi",
                column: "OrganizzatoreId",
                principalTable: "TabOrganizzatori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabCorsi_TabOrganizzatori_OrganizzatoreId",
                table: "TabCorsi");

            migrationBuilder.DropIndex(
                name: "IX_TabCorsi_OrganizzatoreId",
                table: "TabCorsi");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizzatoreId",
                table: "TabCorsi",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TabOrganizzatori",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 10, 11, 35, 27, 162, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "TabTutor",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataAssunzione",
                value: new DateTime(2020, 6, 10, 11, 35, 27, 156, DateTimeKind.Local).AddTicks(8064));
        }
    }
}
