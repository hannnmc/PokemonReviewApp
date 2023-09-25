using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonReviewApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOwnerEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Owners");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Owners",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Owners",
                nullable: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "Reviews",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Owners",
                nullable: false);

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Reviews");
        }
    }
}
