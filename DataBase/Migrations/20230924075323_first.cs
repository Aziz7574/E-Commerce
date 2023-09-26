using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ExpirationDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    ProducedTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    ClassCondition = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCardHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ShoppingCardHistoriesId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCardHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCardHistories_ShoppingCardHistories_ShoppingCardHistoriesId",
                        column: x => x.ShoppingCardHistoriesId,
                        principalTable: "ShoppingCardHistories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShoppingCardHistories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserIdId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCards_Users_UserIdId",
                        column: x => x.UserIdId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Condition = table.Column<int>(type: "INTEGER", nullable: false),
                    UserIdId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ProductIdId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Count = table.Column<int>(type: "INTEGER", nullable: false),
                    ProducedTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    ClassCondition = table.Column<int>(type: "INTEGER", nullable: false),
                    ShoppingCardId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Products_ProductIdId",
                        column: x => x.ProductIdId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_ShoppingCards_ShoppingCardId",
                        column: x => x.ShoppingCardId,
                        principalTable: "ShoppingCards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserIdId",
                        column: x => x.UserIdId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductIdId",
                table: "Orders",
                column: "ProductIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShoppingCardId",
                table: "Orders",
                column: "ShoppingCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserIdId",
                table: "Orders",
                column: "UserIdId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCardHistories_ShoppingCardHistoriesId",
                table: "ShoppingCardHistories",
                column: "ShoppingCardHistoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCardHistories_UserId",
                table: "ShoppingCardHistories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCards_UserIdId",
                table: "ShoppingCards",
                column: "UserIdId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ShoppingCardHistories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShoppingCards");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
