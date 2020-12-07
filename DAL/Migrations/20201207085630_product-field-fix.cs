using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class productfieldfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pricture",
                table: "Products",
                newName: "Picture");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Products",
                newName: "Pricture");
        }
    }
}
