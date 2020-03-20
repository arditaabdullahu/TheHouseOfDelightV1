using Microsoft.EntityFrameworkCore.Migrations;

namespace TheHouseOfDelightV1.Migrations
{
    public partial class changedbrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Foods_FoodID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Types_Foods_FoodID",
                table: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Types_FoodID",
                table: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Products_FoodID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FoodID",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "FoodID",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "FoodProduct",
                columns: table => new
                {
                    FoodID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodProduct", x => new { x.FoodID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_FoodProduct_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodProduct_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodTypes",
                columns: table => new
                {
                    FoodID = table.Column<int>(nullable: false),
                    TypeID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodTypes", x => new { x.FoodID, x.TypeID });
                    table.ForeignKey(
                        name: "FK_FoodTypes_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodTypes_Types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "Types",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodProduct_ProductID",
                table: "FoodProduct",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodTypes_TypeID",
                table: "FoodTypes",
                column: "TypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodProduct");

            migrationBuilder.DropTable(
                name: "FoodTypes");

            migrationBuilder.AddColumn<int>(
                name: "FoodID",
                table: "Types",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FoodID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Types_FoodID",
                table: "Types",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_FoodID",
                table: "Products",
                column: "FoodID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Foods_FoodID",
                table: "Products",
                column: "FoodID",
                principalTable: "Foods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Types_Foods_FoodID",
                table: "Types",
                column: "FoodID",
                principalTable: "Foods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
