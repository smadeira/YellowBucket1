using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YellowBucket1.Migrations
{
    public partial class New_DataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kiosks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    Address = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    Address2 = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    City = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    State = table.Column<string>(type: "char(2)", maxLength: 2, nullable: false),
                    Zip = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kiosks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(128)", maxLength: 60, nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Rating = table.Column<string>(type: "varchar(8)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Description = table.Column<string>(type: "varchar(4096)", maxLength: 4096, nullable: true),
                    Length = table.Column<int>(nullable: true),
                    GenreID = table.Column<int>(nullable: true),
                    IsDVD = table.Column<bool>(nullable: false),
                    IsBluRay = table.Column<bool>(nullable: false),
                    CoverPhoto = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerReviews",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MoviesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerReviews", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerReviews_Movies_MoviesID",
                        column: x => x.MoviesID,
                        principalTable: "Movies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MoviesID = table.Column<int>(nullable: false),
                    KiosksID = table.Column<int>(nullable: false),
                    NumberDVD = table.Column<int>(nullable: false),
                    NumberBluRay = table.Column<int>(nullable: false),
                    NumberDVDRentedFrom = table.Column<int>(nullable: false),
                    NumberBluRayRentedFrom = table.Column<int>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Inventories_Movies_MoviesID",
                        column: x => x.MoviesID,
                        principalTable: "Movies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MoviesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Wishlists_Movies_MoviesID",
                        column: x => x.MoviesID,
                        principalTable: "Movies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoriesID = table.Column<int>(nullable: false),
                    CustomersID = table.Column<int>(nullable: false),
                    RentalKiosksID = table.Column<int>(nullable: false),
                    RentalDate = table.Column<DateTime>(nullable: false),
                    ReturnKiosksID = table.Column<int>(nullable: true),
                    ReturnDate = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    KiosksID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rentals_Inventories_InventoriesID",
                        column: x => x.InventoriesID,
                        principalTable: "Inventories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rentals_Kiosks_KiosksID",
                        column: x => x.KiosksID,
                        principalTable: "Kiosks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerReviews_MoviesID",
                table: "CustomerReviews",
                column: "MoviesID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_MoviesID",
                table: "Inventories",
                column: "MoviesID");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_InventoriesID",
                table: "Rentals",
                column: "InventoriesID");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_KiosksID",
                table: "Rentals",
                column: "KiosksID");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_MoviesID",
                table: "Wishlists",
                column: "MoviesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerReviews");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Kiosks");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
