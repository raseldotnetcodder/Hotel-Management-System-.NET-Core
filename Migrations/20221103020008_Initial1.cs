using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelApplication.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomTypeId",
                table: "RoomTypes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomTypes_RoomTypeId",
                table: "RoomTypes",
                column: "RoomTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomTypes_RoomTypes_RoomTypeId",
                table: "RoomTypes",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomTypes_RoomTypes_RoomTypeId",
                table: "RoomTypes");

            migrationBuilder.DropIndex(
                name: "IX_RoomTypes_RoomTypeId",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "RoomTypeId",
                table: "RoomTypes");
        }
    }
}
