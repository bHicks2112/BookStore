﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class ADdShippedField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Shipped",
                table: "CheckOut",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shipped",
                table: "CheckOut");
        }
    }
}
