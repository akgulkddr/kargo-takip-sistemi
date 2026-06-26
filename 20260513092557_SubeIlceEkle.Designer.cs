using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KargoTakipSistemi1.Migrations
{
    /// <inheritdoc />
    public partial class SubeIlceEkle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "Subeler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "Subeler");
        }
    }
}
