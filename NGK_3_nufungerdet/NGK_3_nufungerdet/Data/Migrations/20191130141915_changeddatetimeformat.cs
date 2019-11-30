using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NGK_3_nufungerdet.Data.Migrations
{
    public partial class changeddatetimeformat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Measurements",
                nullable: false,
                oldClrType: typeof(DateTimeOffset));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Date",
                table: "Measurements",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
