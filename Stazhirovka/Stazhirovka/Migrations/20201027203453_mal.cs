using Microsoft.EntityFrameworkCore.Migrations;

namespace Stazhirovka.Migrations
{
    public partial class mal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_References_GenreId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_References",
                table: "References");

            migrationBuilder.RenameTable(
                name: "References",
                newName: "GenreReferences");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenreReferences",
                table: "GenreReferences",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_GenreReferences_GenreId",
                table: "Movies",
                column: "GenreId",
                principalTable: "GenreReferences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_GenreReferences_GenreId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GenreReferences",
                table: "GenreReferences");

            migrationBuilder.RenameTable(
                name: "GenreReferences",
                newName: "References");

            migrationBuilder.AddPrimaryKey(
                name: "PK_References",
                table: "References",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_References_GenreId",
                table: "Movies",
                column: "GenreId",
                principalTable: "References",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
