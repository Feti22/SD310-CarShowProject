using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarShowProject.Migrations
{
    public partial class AddIsActiveToBrand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Brand",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Brand");
        }
    }
}
