using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class Fix_Shift_TableShift_FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TableShifts_ShiftId",
                table: "TableShifts",
                column: "ShiftId");

            migrationBuilder.AddForeignKey(
                name: "FK_TableShifts_Shifts_ShiftId",
                table: "TableShifts",
                column: "ShiftId",
                principalTable: "Shifts",
                principalColumn: "ShiftId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableShifts_Shifts_ShiftId",
                table: "TableShifts");

            migrationBuilder.DropIndex(
                name: "IX_TableShifts_ShiftId",
                table: "TableShifts");
        }
    }
}
