using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectDemo.Models.Migrations
{
    public partial class AddUser301 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedDate", "Email", "Name", "Password", "Phone", "UpdatedDate", "UserName" },
                values: new object[] { 301, "Address 301", new DateTime(2023, 11, 30, 17, 46, 41, 524, DateTimeKind.Unspecified).AddTicks(297), "user301@yopmail.com", "Customer 301", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", "0123456789301", new DateTime(2023, 11, 30, 17, 46, 41, 524, DateTimeKind.Unspecified).AddTicks(297), "user301" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 301);
        }
    }
}
