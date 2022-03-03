using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission10Final.Migrations
{
    public partial class OrderReceivedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OrderReceived",
                table: "Shoppers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderReceived",
                table: "Shoppers");
        }
    }
}
