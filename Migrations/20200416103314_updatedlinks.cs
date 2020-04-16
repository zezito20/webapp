using Microsoft.EntityFrameworkCore.Migrations;

namespace burguerwebapp.Migrations
{
    public partial class updatedlinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Burguers",
                keyColumn: "BurguerId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://strwebappdemoburguer.blob.core.windows.net/ctnwebappdemoburguer/chickenburger.jpg");

            migrationBuilder.UpdateData(
                table: "Burguers",
                keyColumn: "BurguerId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://strwebappdemoburguer.blob.core.windows.net/ctnwebappdemoburguer/Impossible-Burger-600-x-400.jpg");

            migrationBuilder.UpdateData(
                table: "Burguers",
                keyColumn: "BurguerId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://strwebappdemoburguer.blob.core.windows.net/ctnwebappdemoburguer/dbeef.jpg");

            migrationBuilder.UpdateData(
                table: "Burguers",
                keyColumn: "BurguerId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://strwebappdemoburguer.blob.core.windows.net/ctnwebappdemoburguer/BaconBurgers-infogourmet.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Burguers",
                keyColumn: "BurguerId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://localhost:44375/images/chickenburger.jpg");

            migrationBuilder.UpdateData(
                table: "Burguers",
                keyColumn: "BurguerId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://localhost:44375/images/BaconBurgers.jpg");

            migrationBuilder.UpdateData(
                table: "Burguers",
                keyColumn: "BurguerId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://localhost:44375/images/dbeef.jpg");

            migrationBuilder.UpdateData(
                table: "Burguers",
                keyColumn: "BurguerId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://localhost:44375/images/flamebur.jpg");
        }
    }
}
