using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WTF.api.Migrations
{
    public partial class InitTransactionsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransactionId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_TransactionId",
                table: "Item",
                column: "TransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Transactions_TransactionId",
                table: "Item",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Transactions_TransactionId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Item_TransactionId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Item");
        }
    }
}
