using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarShowProject.Migrations
{
    public partial class AddCarMSRP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MSRP",
                table: "Vehicle",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MSRP",
                table: "Vehicle");
        }
    }
}
