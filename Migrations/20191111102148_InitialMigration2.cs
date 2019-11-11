using Microsoft.EntityFrameworkCore.Migrations;

namespace NGK_Assignment_3.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Temp",
                table: "Measurements",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<double>(
                name: "Pressure",
                table: "Measurements",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Temp",
                table: "Measurements",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<decimal>(
                name: "Pressure",
                table: "Measurements",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
