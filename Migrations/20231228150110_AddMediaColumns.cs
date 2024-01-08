using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hardware4You.Migrations
{
    public partial class AddMediaColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Product",
                newName: "MediaType");

            migrationBuilder.AddColumn<byte[]>(
                name: "Media",
                table: "Product",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Media",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "MediaType",
                table: "Product",
                newName: "ImageURL");
        }
    }
}
