using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Context.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayNum",
                table: "Treats");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Treats",
                newName: "Kind");

            migrationBuilder.AlterColumn<int>(
                name: "Day",
                table: "Treats",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "DayS",
                table: "Treats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayS",
                table: "Treats");

            migrationBuilder.RenameColumn(
                name: "Kind",
                table: "Treats",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Day",
                table: "Treats",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DayNum",
                table: "Treats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
