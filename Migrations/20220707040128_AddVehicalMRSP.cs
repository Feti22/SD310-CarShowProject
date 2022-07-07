using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarShowProject.Migrations
{
    public partial class AddVehicalMRSP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MRSP",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MRSP",
                table: "Vehicle");
        }
    }
}
