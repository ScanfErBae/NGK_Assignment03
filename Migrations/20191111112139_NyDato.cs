using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NGK_Assignment_3.Migrations
{
    public partial class NyDato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "date",
                table: "Measurements",
                newName: "Date");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Date",
                table: "Measurements",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Measurements",
                newName: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "Measurements",
                nullable: false,
                oldClrType: typeof(DateTimeOffset));
        }
    }
}
