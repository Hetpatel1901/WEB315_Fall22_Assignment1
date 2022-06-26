using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMobileList.Migrations
{
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Displaysize",
                table: "Mobilephones",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Mobilephones",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Users",
                table: "Mobilephones",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Mobilephones");

            migrationBuilder.DropColumn(
                name: "Users",
                table: "Mobilephones");

            migrationBuilder.AlterColumn<int>(
                name: "Displaysize",
                table: "Mobilephones",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");
        }
    }
}
