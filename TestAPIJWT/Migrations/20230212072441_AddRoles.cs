using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace TestAPIJWT.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table:"AspNetRoles",
                columns: new[] {"Id","Name" , "NormalizedName" , "ConcurrencyStamp" },
                values: new[] {Guid.NewGuid().ToString(), "User" , "User".ToUpper(),Guid.NewGuid().ToString()} 

                );

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new[] { Guid.NewGuid().ToString(), "Admin", "Admin".ToUpper(), Guid.NewGuid().ToString() }

                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [AspNetRoles]");
        }
    }
}
