using Microsoft.EntityFrameworkCore.Migrations;

namespace fiorella.Migrations
{
    public partial class UpdateOurPerformanceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "OurPerformances");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "OurPerformances");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "OurPerformances",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "OurPerformances");

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "OurPerformances",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "OurPerformances",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }
    }
}
