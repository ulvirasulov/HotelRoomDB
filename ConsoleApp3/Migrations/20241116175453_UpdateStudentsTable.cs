﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp3.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStudentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Point",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Point",
                table: "Students");
        }
    }
}
