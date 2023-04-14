using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class SeedShift : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "ShiftId", "Description", "Payrate" },
                values: new object[] { 1, "FirstShift", 5.0 });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "ShiftId", "Description", "Payrate" },
                values: new object[] { 2, "SecondShift", 5.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ShiftId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ShiftId",
                keyValue: 2);
        }
    }
}
