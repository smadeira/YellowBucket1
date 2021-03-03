using Microsoft.EntityFrameworkCore.Migrations;

namespace YellowBucket1.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Inventories_KiosksID",
                table: "Inventories",
                column: "KiosksID");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Kiosks_KiosksID",
                table: "Inventories",
                column: "KiosksID",
                principalTable: "Kiosks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Kiosks_KiosksID",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_KiosksID",
                table: "Inventories");
        }
    }
}
