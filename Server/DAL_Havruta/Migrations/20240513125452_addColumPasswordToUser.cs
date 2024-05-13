using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL_Havruta.Migrations
{
    /// <inheritdoc />
    public partial class addColumPasswordToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "Password",
            //    table: "User",
            //    nullable: true); // ניתן להוסיף אפשרות נוספת כגון defaultValue
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "Password",
            //    table: "User");
        }
    }
}
