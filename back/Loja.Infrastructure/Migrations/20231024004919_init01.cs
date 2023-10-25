using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Loja.Infrastructure.Migrations
{
    public partial class init01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CategoryEntity_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SupplyEntity_SupplyId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_UnitMeasureEntity_UnitMeasureId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyEntity_SupplierEntity_SupplierId",
                table: "SupplyEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnitMeasureEntity",
                table: "UnitMeasureEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplyEntity",
                table: "SupplyEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierEntity",
                table: "SupplierEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryEntity",
                table: "CategoryEntity");

            migrationBuilder.RenameTable(
                name: "UnitMeasureEntity",
                newName: "UnitsMeasures");

            migrationBuilder.RenameTable(
                name: "SupplyEntity",
                newName: "Supplies");

            migrationBuilder.RenameTable(
                name: "SupplierEntity",
                newName: "Suppliers");

            migrationBuilder.RenameTable(
                name: "CategoryEntity",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_SupplyEntity_SupplierId",
                table: "Supplies",
                newName: "IX_Supplies_SupplierId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnitsMeasures",
                table: "UnitsMeasures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supplies",
                table: "Supplies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Supplies_SupplyId",
                table: "Products",
                column: "SupplyId",
                principalTable: "Supplies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_UnitsMeasures_UnitMeasureId",
                table: "Products",
                column: "UnitMeasureId",
                principalTable: "UnitsMeasures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Supplies_Suppliers_SupplierId",
                table: "Supplies",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Supplies_SupplyId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_UnitsMeasures_UnitMeasureId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Supplies_Suppliers_SupplierId",
                table: "Supplies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnitsMeasures",
                table: "UnitsMeasures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supplies",
                table: "Supplies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "UnitsMeasures",
                newName: "UnitMeasureEntity");

            migrationBuilder.RenameTable(
                name: "Supplies",
                newName: "SupplyEntity");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "SupplierEntity");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "CategoryEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Supplies_SupplierId",
                table: "SupplyEntity",
                newName: "IX_SupplyEntity_SupplierId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnitMeasureEntity",
                table: "UnitMeasureEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplyEntity",
                table: "SupplyEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierEntity",
                table: "SupplierEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryEntity",
                table: "CategoryEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CategoryEntity_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "CategoryEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SupplyEntity_SupplyId",
                table: "Products",
                column: "SupplyId",
                principalTable: "SupplyEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_UnitMeasureEntity_UnitMeasureId",
                table: "Products",
                column: "UnitMeasureId",
                principalTable: "UnitMeasureEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyEntity_SupplierEntity_SupplierId",
                table: "SupplyEntity",
                column: "SupplierId",
                principalTable: "SupplierEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
