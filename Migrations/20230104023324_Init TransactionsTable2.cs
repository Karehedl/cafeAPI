using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WTF.api.Migrations
{
    public partial class InitTransactionsTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_FoodMenus_MenuId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Transactions_TransactionId",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_Item_TransactionId",
                table: "Items",
                newName: "IX_Items_TransactionId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_MenuId",
                table: "Items",
                newName: "IX_Items_MenuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_FoodMenus_MenuId",
                table: "Items",
                column: "MenuId",
                principalTable: "FoodMenus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Transactions_TransactionId",
                table: "Items",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_FoodMenus_MenuId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Transactions_TransactionId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameIndex(
                name: "IX_Items_TransactionId",
                table: "Item",
                newName: "IX_Item_TransactionId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_MenuId",
                table: "Item",
                newName: "IX_Item_MenuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_FoodMenus_MenuId",
                table: "Item",
                column: "MenuId",
                principalTable: "FoodMenus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Transactions_TransactionId",
                table: "Item",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "Id");
        }
    }
}
