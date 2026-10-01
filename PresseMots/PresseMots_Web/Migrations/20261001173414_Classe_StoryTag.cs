using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PresseMots.Migrations
{
    /// <inheritdoc />
    public partial class Classe_StoryTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StoryTagId",
                table: "StoryTags",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StoryTags_StoryId",
                table: "StoryTags",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_StoryTags_TagId",
                table: "StoryTags",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_StoryTags_Stories_StoryId",
                table: "StoryTags",
                column: "StoryId",
                principalTable: "Stories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StoryTags_Tags_TagId",
                table: "StoryTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoryTags_Stories_StoryId",
                table: "StoryTags");

            migrationBuilder.DropForeignKey(
                name: "FK_StoryTags_Tags_TagId",
                table: "StoryTags");

            migrationBuilder.DropIndex(
                name: "IX_StoryTags_StoryId",
                table: "StoryTags");

            migrationBuilder.DropIndex(
                name: "IX_StoryTags_TagId",
                table: "StoryTags");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "StoryTags",
                newName: "StoryTagId");
        }
    }
}
