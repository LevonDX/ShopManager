using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedingProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, null, null, "iPhone 12", 999.99m },
                    { 2, null, null, "Samsung Galaxy S21", 899.99m },
                    { 3, null, null, "Google Pixel 5", 699.99m },
                    { 4, null, null, "Sony PlayStation 5", 499.99m },
                    { 5, null, null, "Xbox Series X", 499.99m },
                    { 6, null, null, "Nintendo Switch", 299.99m },
                    { 7, null, null, "Apple AirPods Pro", 249.99m },
                    { 8, null, null, "Samsung 4K Smart TV", 1499.99m },
                    { 9, null, null, "Dell XPS 13 Laptop", 1299.99m },
                    { 10, null, null, "Logitech G502 Gaming Mouse", 79.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
