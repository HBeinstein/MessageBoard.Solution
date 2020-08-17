using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Solution.Migrations
{
    public partial class AddGroupMessageJoins : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GroupMessages",
                columns: new[] { "GroupMessageId", "GroupId", "MessageId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 3 },
                    { 4, 3, 4 },
                    { 5, 3, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "GroupMessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "GroupMessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "GroupMessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "GroupMessageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GroupMessages",
                keyColumn: "GroupMessageId",
                keyValue: 5);
        }
    }
}
