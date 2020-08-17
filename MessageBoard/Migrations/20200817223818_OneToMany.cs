using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Solution.Migrations
{
    public partial class OneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupMessages");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Messages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "GroupId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "GroupId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "GroupId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "GroupId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "GroupId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_GroupId",
                table: "Messages",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Groups_GroupId",
                table: "Messages",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Groups_GroupId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_GroupId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Messages");

            migrationBuilder.CreateTable(
                name: "GroupMessages",
                columns: table => new
                {
                    GroupMessageId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GroupId = table.Column<int>(nullable: false),
                    MessageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupMessages", x => x.GroupMessageId);
                    table.ForeignKey(
                        name: "FK_GroupMessages_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupMessages_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "MessageId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_GroupMessages_GroupId",
                table: "GroupMessages",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMessages_MessageId",
                table: "GroupMessages",
                column: "MessageId");
        }
    }
}
