using Microsoft.EntityFrameworkCore.Migrations;

namespace burguerwebapp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Vegetarian", "Meat Free" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Beef", "for meat lovers" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Chicken", "tastefull chicken burguers" });

            migrationBuilder.InsertData(
                table: "Burguers",
                columns: new[] { "BurguerId", "CategoryId", "Description", "ImageUrl", "IsBestSeller", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Veggie Burger with sweet potatoes", "https://localhost:44375/images/chickenburger.jpg", true, "Chicken Burguer", 12.95m },
                    { 4, 1, "Veggie and SpiII-cy!", "https://localhost:44375/images/flamebur.jpg", false, "waygyou Burguer", 14.95m },
                    { 2, 2, "Traditional Beef Burger", "https://localhost:44375/images/BaconBurgers.jpg", false, "Burguer", 13.95m },
                    { 3, 2, "Double Taste", "https://localhost:44375/images/dbeef.jpg", false, "Double Beef Burguer", 14.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Burguers",
                keyColumn: "BurguerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Burguers",
                keyColumn: "BurguerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Burguers",
                keyColumn: "BurguerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Burguers",
                keyColumn: "BurguerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
