using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuctionReviews_Users_UserId",
                table: "AuctionReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Auctions_Users_CreatorId",
                table: "Auctions");

            migrationBuilder.DropForeignKey(
                name: "FK_Bids_Lots_LotId",
                table: "Bids");

            migrationBuilder.DropForeignKey(
                name: "FK_Lots_Auctions_AuctionId",
                table: "Lots");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWatchlists_Auctions_AuctionId",
                table: "UserWatchlists");

            migrationBuilder.DropIndex(
                name: "IX_UserWatchlists_AuctionId",
                table: "UserWatchlists");

            migrationBuilder.DropIndex(
                name: "IX_Auctions_CreatorId",
                table: "Auctions");

            migrationBuilder.DropIndex(
                name: "IX_AuctionReviews_UserId",
                table: "AuctionReviews");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserName",
                table: "Users",
                newName: "IX_Users_Username");

            migrationBuilder.AlterColumn<int>(
                name: "AuctionId",
                table: "UserWatchlists",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LotId",
                table: "Bids",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CreatorId",
                table: "Auctions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "AuctionReviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LotCategory",
                columns: table => new
                {
                    LotId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotCategory", x => new { x.CategoryId, x.LotId });
                    table.ForeignKey(
                        name: "FK_LotCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LotCategory_Lots_LotId",
                        column: x => x.LotId,
                        principalTable: "Lots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserWatchlists_AuctionId",
                table: "UserWatchlists",
                column: "AuctionId",
                unique: true,
                filter: "[AuctionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_CreatorId",
                table: "Auctions",
                column: "CreatorId",
                unique: true,
                filter: "[CreatorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionReviews_UserId",
                table: "AuctionReviews",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LotCategory_LotId",
                table: "LotCategory",
                column: "LotId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionReviews_Users_UserId",
                table: "AuctionReviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Auctions_Users_CreatorId",
                table: "Auctions",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Bids_Lots_LotId",
                table: "Bids",
                column: "LotId",
                principalTable: "Lots",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Lots_Auctions_AuctionId",
                table: "Lots",
                column: "AuctionId",
                principalTable: "Auctions",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWatchlists_Auctions_AuctionId",
                table: "UserWatchlists",
                column: "AuctionId",
                principalTable: "Auctions",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuctionReviews_Users_UserId",
                table: "AuctionReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Auctions_Users_CreatorId",
                table: "Auctions");

            migrationBuilder.DropForeignKey(
                name: "FK_Bids_Lots_LotId",
                table: "Bids");

            migrationBuilder.DropForeignKey(
                name: "FK_Lots_Auctions_AuctionId",
                table: "Lots");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWatchlists_Auctions_AuctionId",
                table: "UserWatchlists");

            migrationBuilder.DropTable(
                name: "LotCategory");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_UserWatchlists_AuctionId",
                table: "UserWatchlists");

            migrationBuilder.DropIndex(
                name: "IX_Auctions_CreatorId",
                table: "Auctions");

            migrationBuilder.DropIndex(
                name: "IX_AuctionReviews_UserId",
                table: "AuctionReviews");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Username",
                table: "Users",
                newName: "IX_Users_UserName");

            migrationBuilder.AlterColumn<int>(
                name: "AuctionId",
                table: "UserWatchlists",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LotId",
                table: "Bids",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatorId",
                table: "Auctions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "AuctionReviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserWatchlists_AuctionId",
                table: "UserWatchlists",
                column: "AuctionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_CreatorId",
                table: "Auctions",
                column: "CreatorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuctionReviews_UserId",
                table: "AuctionReviews",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionReviews_Users_UserId",
                table: "AuctionReviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Auctions_Users_CreatorId",
                table: "Auctions",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bids_Lots_LotId",
                table: "Bids",
                column: "LotId",
                principalTable: "Lots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lots_Auctions_AuctionId",
                table: "Lots",
                column: "AuctionId",
                principalTable: "Auctions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserWatchlists_Auctions_AuctionId",
                table: "UserWatchlists",
                column: "AuctionId",
                principalTable: "Auctions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
