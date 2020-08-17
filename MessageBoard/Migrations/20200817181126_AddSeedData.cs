using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Solution.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Body", "Date", "Title", "UserName" },
                values: new object[,]
                {
                    { 1, "Hello? Hello???", new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Hello", "Test1" },
                    { 2, "I don't know why you say goodbye I say hello.", new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Goodbye", "Test2" },
                    { 3, "This is a test of the emergency alert system.", new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "This is only a test", "Test3" },
                    { 4, "You would be dead. Probably, who knows. If you saw a flash, most likely.", new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "If this was a real alert", "Test4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4);
        }
    }
}
