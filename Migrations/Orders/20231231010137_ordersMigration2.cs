using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hardware4You.Migrations.Orders
{
    public partial class ordersMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    cashOnDelivery = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    prePayment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    pickCity1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    pickCity2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    phoneNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "OrderedProduct",
                columns: table => new
                {
                    OrdersOrderID = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderedProduct", x => new { x.OrdersOrderID, x.Id });
                    table.ForeignKey(
                        name: "FK_OrderedProduct_Orders_OrdersOrderID",
                        column: x => x.OrdersOrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderedProduct");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}