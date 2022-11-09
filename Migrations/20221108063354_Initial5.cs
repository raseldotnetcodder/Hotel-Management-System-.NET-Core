using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelApplication.Migrations
{
    public partial class Initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookingComplementaryRelationships",
                columns: table => new
                {
                    BookingId = table.Column<int>(nullable: false),
                    ComplementaryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingComplementaryRelationships", x => new { x.BookingId, x.ComplementaryId });
                    table.ForeignKey(
                        name: "FK_BookingComplementaryRelationships_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingComplementaryRelationships_Complementaries_ComplementaryId",
                        column: x => x.ComplementaryId,
                        principalTable: "Complementaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingSuplementaryRelationships",
                columns: table => new
                {
                    BookingId = table.Column<int>(nullable: false),
                    SuplementaryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingSuplementaryRelationships", x => new { x.BookingId, x.SuplementaryId });
                    table.ForeignKey(
                        name: "FK_BookingSuplementaryRelationships_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingSuplementaryRelationships_Suplementaries_SuplementaryId",
                        column: x => x.SuplementaryId,
                        principalTable: "Suplementaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingComplementaryRelationships_ComplementaryId",
                table: "BookingComplementaryRelationships",
                column: "ComplementaryId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingSuplementaryRelationships_SuplementaryId",
                table: "BookingSuplementaryRelationships",
                column: "SuplementaryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingComplementaryRelationships");

            migrationBuilder.DropTable(
                name: "BookingSuplementaryRelationships");
        }
    }
}
