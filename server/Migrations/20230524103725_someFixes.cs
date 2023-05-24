using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class someFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Additives_products_productid",
                table: "Additives");

            migrationBuilder.DropForeignKey(
                name: "FK_banck_cards_users_userid",
                table: "banck_cards");

            migrationBuilder.DropForeignKey(
                name: "FK_basket_products_productid",
                table: "basket");

            migrationBuilder.DropForeignKey(
                name: "FK_basket_users_userid",
                table: "basket");

            migrationBuilder.DropForeignKey(
                name: "FK_order_history_products_productid",
                table: "order_history");

            migrationBuilder.DropForeignKey(
                name: "FK_order_history_users_userid",
                table: "order_history");

            migrationBuilder.DropForeignKey(
                name: "FK_product_features_Features_featureid",
                table: "product_features");

            migrationBuilder.DropForeignKey(
                name: "FK_product_features_products_productid",
                table: "product_features");

            migrationBuilder.DropForeignKey(
                name: "FK_products_types_product_productTypeid",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_productTypeid",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_product_features_featureid",
                table: "product_features");

            migrationBuilder.DropIndex(
                name: "IX_product_features_productid",
                table: "product_features");

            migrationBuilder.DropIndex(
                name: "IX_order_history_productid",
                table: "order_history");

            migrationBuilder.DropIndex(
                name: "IX_order_history_userid",
                table: "order_history");

            migrationBuilder.DropIndex(
                name: "IX_basket_productid",
                table: "basket");

            migrationBuilder.DropIndex(
                name: "IX_basket_userid",
                table: "basket");

            migrationBuilder.DropIndex(
                name: "IX_banck_cards_userid",
                table: "banck_cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Additives",
                table: "Additives");

            migrationBuilder.DropIndex(
                name: "IX_Additives_productid",
                table: "Additives");

            migrationBuilder.DropColumn(
                name: "productTypeid",
                table: "products");

            migrationBuilder.RenameTable(
                name: "Additives",
                newName: "additives");

            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "users",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "numberAccumuletedBonuses",
                table: "users",
                newName: "number_accumuleted_bonuses");

            migrationBuilder.RenameColumn(
                name: "monthBirth",
                table: "users",
                newName: "month_birth");

            migrationBuilder.RenameColumn(
                name: "dayBirth",
                table: "users",
                newName: "day_birth");

            migrationBuilder.RenameColumn(
                name: "typeTitle",
                table: "types_product",
                newName: "type_title");

            migrationBuilder.RenameColumn(
                name: "productTitle",
                table: "products",
                newName: "product_title");

            migrationBuilder.RenameColumn(
                name: "productPrice",
                table: "products",
                newName: "product_price");

            migrationBuilder.RenameColumn(
                name: "productid",
                table: "product_features",
                newName: "product_id");

            migrationBuilder.RenameColumn(
                name: "featureid",
                table: "product_features",
                newName: "feature_id");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "order_history",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "productid",
                table: "order_history",
                newName: "product_id");

            migrationBuilder.RenameColumn(
                name: "dateOrder",
                table: "order_history",
                newName: "date_order");

            migrationBuilder.RenameColumn(
                name: "featureValue",
                table: "Features",
                newName: "feature_value");

            migrationBuilder.RenameColumn(
                name: "featureTitle",
                table: "Features",
                newName: "feature_title");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "basket",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "countProduct",
                table: "basket",
                newName: "count_product");

            migrationBuilder.RenameColumn(
                name: "productid",
                table: "basket",
                newName: "product_id");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "banck_cards",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "numberBanckCard",
                table: "banck_cards",
                newName: "number_bank_card");

            migrationBuilder.RenameColumn(
                name: "expirationDateBankCard",
                table: "banck_cards",
                newName: "expiration_date_bank_card");

            migrationBuilder.RenameColumn(
                name: "productid",
                table: "additives",
                newName: "product_id");

            migrationBuilder.RenameColumn(
                name: "additiveTitle",
                table: "additives",
                newName: "additive_title");

            migrationBuilder.RenameColumn(
                name: "additivePrice",
                table: "additives",
                newName: "additive_price");

            migrationBuilder.AlterColumn<string>(
                name: "type_title",
                table: "types_product",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "product_price",
                table: "products",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "product_type",
                table: "products",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "additive_price",
                table: "additives",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_additives",
                table: "additives",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_additives",
                table: "additives");

            migrationBuilder.DropColumn(
                name: "product_type",
                table: "products");

            migrationBuilder.RenameTable(
                name: "additives",
                newName: "Additives");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "users",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "number_accumuleted_bonuses",
                table: "users",
                newName: "numberAccumuletedBonuses");

            migrationBuilder.RenameColumn(
                name: "month_birth",
                table: "users",
                newName: "monthBirth");

            migrationBuilder.RenameColumn(
                name: "day_birth",
                table: "users",
                newName: "dayBirth");

            migrationBuilder.RenameColumn(
                name: "type_title",
                table: "types_product",
                newName: "typeTitle");

            migrationBuilder.RenameColumn(
                name: "product_title",
                table: "products",
                newName: "productTitle");

            migrationBuilder.RenameColumn(
                name: "product_price",
                table: "products",
                newName: "productPrice");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "product_features",
                newName: "productid");

            migrationBuilder.RenameColumn(
                name: "feature_id",
                table: "product_features",
                newName: "featureid");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "order_history",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "order_history",
                newName: "productid");

            migrationBuilder.RenameColumn(
                name: "date_order",
                table: "order_history",
                newName: "dateOrder");

            migrationBuilder.RenameColumn(
                name: "feature_value",
                table: "Features",
                newName: "featureValue");

            migrationBuilder.RenameColumn(
                name: "feature_title",
                table: "Features",
                newName: "featureTitle");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "basket",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "count_product",
                table: "basket",
                newName: "countProduct");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "basket",
                newName: "productid");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "banck_cards",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "number_bank_card",
                table: "banck_cards",
                newName: "numberBanckCard");

            migrationBuilder.RenameColumn(
                name: "expiration_date_bank_card",
                table: "banck_cards",
                newName: "expirationDateBankCard");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "Additives",
                newName: "productid");

            migrationBuilder.RenameColumn(
                name: "additive_title",
                table: "Additives",
                newName: "additiveTitle");

            migrationBuilder.RenameColumn(
                name: "additive_price",
                table: "Additives",
                newName: "additivePrice");

            migrationBuilder.AlterColumn<string>(
                name: "typeTitle",
                table: "types_product",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "productPrice",
                table: "products",
                type: "text",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AddColumn<int>(
                name: "productTypeid",
                table: "products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "additivePrice",
                table: "Additives",
                type: "text",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Additives",
                table: "Additives",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_products_productTypeid",
                table: "products",
                column: "productTypeid");

            migrationBuilder.CreateIndex(
                name: "IX_product_features_featureid",
                table: "product_features",
                column: "featureid");

            migrationBuilder.CreateIndex(
                name: "IX_product_features_productid",
                table: "product_features",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_order_history_productid",
                table: "order_history",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_order_history_userid",
                table: "order_history",
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
                name: "IX_banck_cards_userid",
                table: "banck_cards",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_Additives_productid",
                table: "Additives",
                column: "productid");

            migrationBuilder.AddForeignKey(
                name: "FK_Additives_products_productid",
                table: "Additives",
                column: "productid",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_banck_cards_users_userid",
                table: "banck_cards",
                column: "userid",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_basket_products_productid",
                table: "basket",
                column: "productid",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_basket_users_userid",
                table: "basket",
                column: "userid",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_history_products_productid",
                table: "order_history",
                column: "productid",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_history_users_userid",
                table: "order_history",
                column: "userid",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_features_Features_featureid",
                table: "product_features",
                column: "featureid",
                principalTable: "Features",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_features_products_productid",
                table: "product_features",
                column: "productid",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_types_product_productTypeid",
                table: "products",
                column: "productTypeid",
                principalTable: "types_product",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
