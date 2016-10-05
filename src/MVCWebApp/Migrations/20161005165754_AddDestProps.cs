using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCWebApp.Migrations
{
    public partial class AddDestProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Destinations");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Destinations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Destinations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Destinations");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Destinations",
                nullable: true);
        }
    }
}
