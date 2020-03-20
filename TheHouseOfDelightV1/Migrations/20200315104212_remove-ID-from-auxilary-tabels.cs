using Microsoft.EntityFrameworkCore.Migrations;

namespace TheHouseOfDelightV1.Migrations
{
    public partial class removeIDfromauxilarytabels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodProduct");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "FoodTypes");

            migrationBuilder.CreateTable(
                name: "FoodProducts",
                columns: table => new
                {
                    FoodID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodProducts", x => new { x.FoodID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_FoodProducts_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodProducts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodProducts_ProductID",
                table: "FoodProducts",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodProducts");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "FoodTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FoodProduct",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_FoodProduct_ProductID",
                table: "FoodProduct",
                column: "ProductID");
        }
    }
}
