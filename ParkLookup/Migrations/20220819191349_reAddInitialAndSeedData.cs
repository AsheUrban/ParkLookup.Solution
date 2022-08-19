using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkLookup.Solution.Migrations
{
    public partial class reAddInitialAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Type = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Location = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Feature = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Feature", "Location", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Deepest and Clearest lake in USA.", "Oregon", "Crater Lake", "National Park" },
                    { 2, "Lakes, hot springs, cincer cones, and lava beds.", "California", "Lassen Volcanic", "National Park" },
                    { 3, "Tallest peak in North America and over 6 million acres of wilderness.", "Alaska", "Denali", "National Park and Preserve" },
                    { 4, "Sweeping views and several thousand climbs, with over a thousand bolted routes.", "Oregon", "Smith Rock", "State Park" },
                    { 5, "Camp, fish, run, climb, bike, boat, ride horses, sail, and more at this lively recreational destination.", "Idaho", "Ponderosa", "State Park" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
