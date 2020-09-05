using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Persistance.Migrations
{
    public partial class classes_removedidproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FieldID",
                table: "Fields");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "FieldID",
                table: "Fields",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
