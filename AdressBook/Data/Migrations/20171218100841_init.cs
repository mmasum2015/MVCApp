using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AdressBook.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Persons",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Persons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Persons",
                newName: "Name");
        }
    }
}
