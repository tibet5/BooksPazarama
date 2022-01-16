using Microsoft.EntityFrameworkCore.Migrations;

namespace Books.Migrations
{
    public partial class genreupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Authors_AuthorId",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Genres_AuthorId",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Genres");

            migrationBuilder.CreateTable(
                name: "AuthorGenre",
                columns: table => new
                {
                    AuthorsId = table.Column<int>(type: "int", nullable: false),
                    GenresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorGenre", x => new { x.AuthorsId, x.GenresId });
                    table.ForeignKey(
                        name: "FK_AuthorGenre_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorGenre_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorGenre_GenresId",
                table: "AuthorGenre",
                column: "GenresId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorGenre");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Genres",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genres_AuthorId",
                table: "Genres",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Authors_AuthorId",
                table: "Genres",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
