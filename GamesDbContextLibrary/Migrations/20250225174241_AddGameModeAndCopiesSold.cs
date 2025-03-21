﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesDbContextLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddGameModeAndCopiesSold : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CopiesSold",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GameMode",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CopiesSold",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GameMode",
                table: "Games");
        }
    }
}
