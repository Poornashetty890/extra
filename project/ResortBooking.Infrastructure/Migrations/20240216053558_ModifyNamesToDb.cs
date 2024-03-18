﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResortBooking.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifyNamesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prim",
                table: "Resorts",
                newName: "Price");

            migrationBuilder.InsertData(
                table: "Resorts",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "UpdatedDate" },
                values: new object[] { 1, null, "It is a beautiful resort with good and nice free space.", "https://placehold.co/600x400", "Royal Resort", 4, 200.0, 0, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Resorts",
                newName: "Prim");
        }
    }
}
