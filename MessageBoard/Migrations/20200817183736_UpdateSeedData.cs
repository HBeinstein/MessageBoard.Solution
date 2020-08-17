using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Solution.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
