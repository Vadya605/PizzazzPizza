using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    featureTitle = table.Column<string>(type: "text", nullable: false),
                    featureValue = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "types_product",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    typeTitle = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_types_product", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phoneNumber = table.Column<string>(type: "text", nullable: false),
                    dayBirth = table.Column<int>(type: "integer", nullable: true),
                    monthBirth = table.Column<string>(type: "text", nullable: true),
                    numberAccumuletedBonuses = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    productTitle = table.Column<string>(type: "text", nullable: false),
                    productPrice = table.Column<string>(type: "text", nullable: false),
                    productTypeid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                    table.ForeignKey(
                        name: "FK_products_types_product_productTypeid",
                        column: x => x.productTypeid,
                        principalTable: "types_product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "banck_cards",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    numberBanckCard = table.Column<int>(type: "integer", nullable: false),
                    expirationDateBankCard = table.Column<string>(type: "text", nullable: false),
                    cvv = table.Column<string>(type: "text", nullable: false),
                    userid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banck_cards", x => x.id);
                    table.ForeignKey(
                        name: "FK_banck_cards_users_userid",
                        column: x => x.userid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Additives",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    additiveTitle = table.Column<string>(type: "text", nullable: false),
                    additivePrice = table.Column<string>(type: "text", nullable: false),
                    productid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Additives", x => x.id);
                    table.ForeignKey(
                        name: "FK_Additives_products_productid",
                        column: x => x.productid,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "basket",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    userid = table.Column<int>(type: "integer", nullable: false),
                    productid = table.Column<int>(type: "integer", nullable: false),
                    countProduct = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_basket", x => x.id);
                    table.ForeignKey(
                        name: "FK_basket_products_productid",
                        column: x => x.productid,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_basket_users_userid",
                        column: x => x.userid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_history",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    dateOrder = table.Column<DateOnly>(type: "date", nullable: false),
                    userid = table.Column<int>(type: "integer", nullable: false),
                    productid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_history", x => x.id);
                    table.ForeignKey(
                        name: "FK_order_history_products_productid",
                        column: x => x.productid,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_order_history_users_userid",
                        column: x => x.userid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "product_features",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    featureid = table.Column<int>(type: "integer", nullable: false),
                    productid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_features", x => x.id);
                    table.ForeignKey(
                        name: "FK_product_features_Features_featureid",
                        column: x => x.featureid,
                        principalTable: "Features",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_product_features_products_productid",
                        column: x => x.productid,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Additives_productid",
                table: "Additives",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_banck_cards_userid",
                table: "banck_cards",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_basket_productid",
                table: "basket",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_basket_userid",
                table: "basket",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_order_history_productid",
                table: "order_history",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_order_history_userid",
                table: "order_history",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_product_features_featureid",
                table: "product_features",
                column: "featureid");

            migrationBuilder.CreateIndex(
                name: "IX_product_features_productid",
                table: "product_features",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_products_productTypeid",
                table: "products",
                column: "productTypeid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Additives");

            migrationBuilder.DropTable(
                name: "banck_cards");

            migrationBuilder.DropTable(
                name: "basket");

            migrationBuilder.DropTable(
                name: "order_history");

            migrationBuilder.DropTable(
                name: "product_features");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "types_product");
        }
    }
}
