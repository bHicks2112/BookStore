﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class CheckOut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Books",
            //    columns: table => new
            //    {
            //        BookId = table.Column<long>(nullable: false)
            //            .Annotation("Sqlite:Autoincrement", true),
            //        Title = table.Column<string>(nullable: true),
            //        Author = table.Column<string>(nullable: true),
            //        Publisher = table.Column<string>(nullable: true),
            //        Isbn = table.Column<string>(nullable: true),
            //        Classification = table.Column<string>(nullable: true),
            //        Category = table.Column<string>(nullable: true),
            //        PageCount = table.Column<long>(nullable: false),
            //        Price = table.Column<double>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Books", x => x.BookId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CheckOut",
            //    columns: table => new
            //    {
            //        CheckOutId = table.Column<int>(nullable: false)
            //            .Annotation("Sqlite:Autoincrement", true),
            //        Name = table.Column<string>(nullable: false),
            //        AddressLine1 = table.Column<string>(nullable: true),
            //        AddressLine2 = table.Column<string>(nullable: true),
            //        AddressLine3 = table.Column<string>(nullable: true),
            //        City = table.Column<string>(nullable: false),
            //        State = table.Column<string>(nullable: false),
            //        Zip = table.Column<string>(nullable: true),
            //        Country = table.Column<string>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CheckOut", x => x.CheckOutId);
            //    });

            //    migrationBuilder.CreateTable(
            //        name: "CartLineItem",
            //        columns: table => new
            //        {
            //            LineID = table.Column<int>(nullable: false)
            //                .Annotation("Sqlite:Autoincrement", true),
            //            BooksBookId = table.Column<long>(nullable: true),
            //            Quantity = table.Column<int>(nullable: false),
            //            CheckOutId = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_CartLineItem", x => x.LineID);
            //            table.ForeignKey(
            //                name: "FK_CartLineItem_Books_BooksBookId",
            //                column: x => x.BooksBookId,
            //                principalTable: "Books",
            //                principalColumn: "BookId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_CartLineItem_CheckOut_CheckOutId",
            //                column: x => x.CheckOutId,
            //                principalTable: "CheckOut",
            //                principalColumn: "CheckOutId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateIndex(
            //        name: "IX_CartLineItem_BooksBookId",
            //        table: "CartLineItem",
            //        column: "BooksBookId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_CartLineItem_CheckOutId",
            //        table: "CartLineItem",
            //        column: "CheckOutId");
            //}

            //protected override void Down(MigrationBuilder migrationBuilder)
            //{
            //    migrationBuilder.DropTable(
            //        name: "CartLineItem");

            //migrationBuilder.DropTable(
            //    name: "Books");

            //migrationBuilder.DropTable(
            //    name: "CheckOut");
        }
    }
}
