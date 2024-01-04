using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BuyBox.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductstoDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "This is an regular brick", 12.0, 11.0, 8.0, 10.0, "Regular Brick" },
                    { 2, "This is an Premium brick", 15.0, 14.0, 10.0, 12.0, "Premium Brick" },
                    { 3, "This is M-sand used for building purpose", 70.0, 65.0, 60.0, 65.0, "M-Sand" },
                    { 4, "This is P-sand used for building purpose", 60.0, 60.0, 50.0, 55.0, "P-Sand" },
                    { 5, "This is River-sand used for building purpose", 110.0, 110.0, 100.0, 105.0, "River-Sand" },
                    { 6, "This is Blue Metal used for building purpose", 110.0, 110.0, 100.0, 105.0, "Blue Metal" },
                    { 7, "This is AAC Block used for building purpose", 60.0, 60.0, 52.0, 55.0, " 4 inch AAC Block" },
                    { 8, "This is AAC Block used for building purpose", 60.0, 60.0, 52.0, 55.0, " 6 inch AAC Block" },
                    { 9, "This is AAC Block used for building purpose", 60.0, 60.0, 52.0, 55.0, " 9 inch AAC Block" },
                    { 10, "This is best quality cement used for building purpose", 420.0, 420.0, 410.0, 415.0, "Coromental Cement" },
                    { 11, "This is best quality cement used for building purpose", 400.0, 400.0, 390.0, 395.0, "Priya Cement" },
                    { 12, "This is best quality AAC BLock paste used for building purpose", 400.0, 400.0, 390.0, 395.0, "AAC block Paste" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
