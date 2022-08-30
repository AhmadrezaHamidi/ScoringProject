using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortLink.Repo.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "LinkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "LinkId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "LinkId", "ShortLink", "Url" },
                values: new object[] { 1612533, "EY64pu50w5Li", "googleTwo.com" });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "LinkId", "ShortLink", "Url" },
                values: new object[] { 7625800, "FkPSW3IdGXbL", "google.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "LinkId",
                keyValue: 1612533);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "LinkId",
                keyValue: 7625800);

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "LinkId", "ShortLink", "Url" },
                values: new object[] { 1, "Maths", "John" });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "LinkId", "ShortLink", "Url" },
                values: new object[] { 2, "English", "Femi" });
        }
    }
}
