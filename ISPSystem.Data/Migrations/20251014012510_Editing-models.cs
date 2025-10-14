using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ISPSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class Editingmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveredAt",
                table: "Subscribing",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RetrievedAt",
                table: "Subscribing",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveredAt",
                table: "Subscribing");

            migrationBuilder.DropColumn(
                name: "RetrievedAt",
                table: "Subscribing");
        }
    }
}
