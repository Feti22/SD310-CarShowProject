using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarShowProject.Migrations
{
    public partial class AddVehicleVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Version",
                table: "Vehicle");
        }
    }
}
