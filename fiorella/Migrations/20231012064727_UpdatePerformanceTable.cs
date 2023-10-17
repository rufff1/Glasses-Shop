using Microsoft.EntityFrameworkCore.Migrations;

namespace fiorella.Migrations
{
    public partial class UpdatePerformanceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descriptoion",
                table: "OurPerformances");

            migrationBuilder.AddColumn<string>(
                name: "Descriptoion1",
                table: "OurPerformances",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Descriptoion2",
                table: "OurPerformances",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descriptoion1",
                table: "OurPerformances");

            migrationBuilder.DropColumn(
                name: "Descriptoion2",
                table: "OurPerformances");

            migrationBuilder.AddColumn<string>(
                name: "Descriptoion",
                table: "OurPerformances",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");
        }
    }
}
