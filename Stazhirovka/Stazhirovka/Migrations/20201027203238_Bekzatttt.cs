using Microsoft.EntityFrameworkCore.Migrations;

namespace Stazhirovka.Migrations
{
    public partial class Bekzatttt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_References_genreid",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "genreName",
                table: "References",
                newName: "GenreName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "References",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "Movies",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "relevance",
                table: "Movies",
                newName: "Relevance");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Movies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "genreid",
                table: "Movies",
                newName: "GenreId");

            migrationBuilder.RenameColumn(
                name: "endDate",
                table: "Movies",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Movies",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_genreid",
                table: "Movies",
                newName: "IX_Movies_GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_References_GenreId",
                table: "Movies",
                column: "GenreId",
                principalTable: "References",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_References_GenreId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "References",
                newName: "genreName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "References",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Movies",
                newName: "startDate");

            migrationBuilder.RenameColumn(
                name: "Relevance",
                table: "Movies",
                newName: "relevance");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Movies",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Movies",
                newName: "genreid");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Movies",
                newName: "endDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movies",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                newName: "IX_Movies_genreid");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_References_genreid",
                table: "Movies",
                column: "genreid",
                principalTable: "References",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
