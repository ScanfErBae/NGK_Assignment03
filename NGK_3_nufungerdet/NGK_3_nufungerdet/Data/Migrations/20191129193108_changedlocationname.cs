using Microsoft.EntityFrameworkCore.Migrations;

namespace NGK_3_nufungerdet.Data.Migrations
{
    public partial class changedlocationname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Measurements_Locations_MeasurementLocationId",
                table: "Measurements");

            migrationBuilder.RenameColumn(
                name: "MeasurementLocationId",
                table: "Measurements",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Measurements_MeasurementLocationId",
                table: "Measurements",
                newName: "IX_Measurements_LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Measurements_Locations_LocationId",
                table: "Measurements",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "MeasurementLocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Measurements_Locations_LocationId",
                table: "Measurements");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Measurements",
                newName: "MeasurementLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Measurements_LocationId",
                table: "Measurements",
                newName: "IX_Measurements_MeasurementLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Measurements_Locations_MeasurementLocationId",
                table: "Measurements",
                column: "MeasurementLocationId",
                principalTable: "Locations",
                principalColumn: "MeasurementLocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
