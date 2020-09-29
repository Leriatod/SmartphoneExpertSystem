using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneExp.Migrations
{
    public partial class ExtendedPhonesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionUrl",
                table: "Phones",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Phones",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionUrl",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Phones");
        }
    }
}
