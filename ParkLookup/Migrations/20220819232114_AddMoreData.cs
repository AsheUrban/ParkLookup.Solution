using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkLookup.Solution.Migrations
{
    public partial class AddMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Feature", "Location", "Name", "Type" },
                values: new object[] { 6, "Iconic and ACTIVE volcano. Turqoise lakes and views galore.", "Washington", "Mount Rainier", "National Park" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Feature", "Location", "Name", "Type" },
                values: new object[] { 7, "Stunning coastline and classic beach town.", "Oregon", "Ecola", "State Park" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);
        }
    }
}
