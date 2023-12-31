﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fiorella.Migrations
{
    public partial class CreateWelcomeNestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WelcomeNests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatAt = table.Column<DateTime>(nullable: true),
                    CreatBy = table.Column<string>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Image = table.Column<string>(maxLength: 225, nullable: false),
                    Description1 = table.Column<string>(maxLength: 1000, nullable: true),
                    Description2 = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelcomeNests", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WelcomeNests");
        }
    }
}
