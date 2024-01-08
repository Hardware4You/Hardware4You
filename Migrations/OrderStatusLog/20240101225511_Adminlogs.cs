using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hardware4You.Migrations.OrderStatusLog
{
    public partial class Adminlogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderStatusLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminUsername = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    NewStatus = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatusLog", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderStatusLog");
        }
    }
}
