using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Manufacturer", "Name", "Pricture" },
                values: new object[,]
                {
                    { 1, "Gibson", "Guitar", "picture_link" },
                    { 2, "Yamaha", "Piano", "picture_link" },
                    { 3, "Dadario", "Strings", "picture_link" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "Adress", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "New York, #132", "MusicRoom", "Market" },
                    { 2, "Las Vegas, #9", "MusicHouse", "Market" }
                });

            migrationBuilder.InsertData(
                table: "StoreProduct",
                columns: new[] { "Id", "BarCode", "Price", "ProductID", "StoreID" },
                values: new object[] { 1, 12216654, 980, 1, 1 });

            migrationBuilder.InsertData(
                table: "StoreProduct",
                columns: new[] { "Id", "BarCode", "Price", "ProductID", "StoreID" },
                values: new object[] { 2, 12315651, 1080, 1, 2 });

            migrationBuilder.InsertData(
                table: "StoreProduct",
                columns: new[] { "Id", "BarCode", "Price", "ProductID", "StoreID" },
                values: new object[] { 3, 12451210, 1900, 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StoreProduct",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StoreProduct",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StoreProduct",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
