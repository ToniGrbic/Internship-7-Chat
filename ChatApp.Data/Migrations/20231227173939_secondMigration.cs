using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ChatApp.Data.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_UsersId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupUsers",
                table: "GroupUsers");

            migrationBuilder.DropIndex(
                name: "IX_GroupUsers_GroupId",
                table: "GroupUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_UsersId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "GroupUsers");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "PrivateMesseges");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupUsers",
                table: "GroupUsers",
                columns: new[] { "GroupId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrivateMesseges",
                table: "PrivateMesseges",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateMesseges_ReceiverUserID",
                table: "PrivateMesseges",
                column: "ReceiverUserID");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateMesseges_SenderUserID",
                table: "PrivateMesseges",
                column: "SenderUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateMesseges_Users_ReceiverUserID",
                table: "PrivateMesseges",
                column: "ReceiverUserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateMesseges_Users_SenderUserID",
                table: "PrivateMesseges",
                column: "SenderUserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrivateMesseges_Users_ReceiverUserID",
                table: "PrivateMesseges");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivateMesseges_Users_SenderUserID",
                table: "PrivateMesseges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupUsers",
                table: "GroupUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrivateMesseges",
                table: "PrivateMesseges");

            migrationBuilder.DropIndex(
                name: "IX_PrivateMesseges_ReceiverUserID",
                table: "PrivateMesseges");

            migrationBuilder.DropIndex(
                name: "IX_PrivateMesseges_SenderUserID",
                table: "PrivateMesseges");

            migrationBuilder.RenameTable(
                name: "PrivateMesseges",
                newName: "Items");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "GroupUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Items",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupUsers",
                table: "GroupUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_GroupUsers_GroupId",
                table: "GroupUsers",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_UsersId",
                table: "Items",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_UsersId",
                table: "Items",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
