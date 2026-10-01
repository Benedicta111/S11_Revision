using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PresseMots.Migrations
{
    /// <inheritdoc />
    public partial class DB_Lazyloading : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Stories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StoryTags",
                columns: table => new
                {
                    StoryTagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagId = table.Column<int>(type: "int", nullable: true),
                    StoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoryTags", x => x.StoryTagId);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TagId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TagId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Stories_TagId",
                table: "Stories",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_Tags_TagId",
                table: "Stories",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stories_Tags_TagId",
                table: "Stories");

            migrationBuilder.DropTable(
                name: "StoryTags");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Stories_TagId",
                table: "Stories");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Stories");
        }
    }
}
