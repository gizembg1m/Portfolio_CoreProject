using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_project_columns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl3",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl4",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Platform",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Portfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl3",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "ImageUrl4",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Platform",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Portfolios");
        }
    }
}
