using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatApp.Data.Migrations
{
    public partial class NameChangeSentDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrivateMesseges_Users_ReceiverUserID",
                table: "PrivateMesseges");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivateMesseges_Users_SenderUserID",
                table: "PrivateMesseges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrivateMesseges",
                table: "PrivateMesseges");

            migrationBuilder.DropColumn(
                name: "MessageDate",
                table: "PrivateMesseges");

            migrationBuilder.RenameTable(
                name: "PrivateMesseges",
                newName: "PrivateMessages");

            migrationBuilder.RenameIndex(
                name: "IX_PrivateMesseges_SenderUserID",
                table: "PrivateMessages",
                newName: "IX_PrivateMessages_SenderUserID");

            migrationBuilder.RenameIndex(
                name: "IX_PrivateMesseges_ReceiverUserID",
                table: "PrivateMessages",
                newName: "IX_PrivateMessages_ReceiverUserID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SentDate",
                table: "GroupMessages",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<DateTime>(
                name: "SentDate",
                table: "PrivateMessages",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrivateMessages",
                table: "PrivateMessages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateMessages_Users_ReceiverUserID",
                table: "PrivateMessages",
                column: "ReceiverUserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateMessages_Users_SenderUserID",
                table: "PrivateMessages",
                column: "SenderUserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrivateMessages_Users_ReceiverUserID",
                table: "PrivateMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivateMessages_Users_SenderUserID",
                table: "PrivateMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrivateMessages",
                table: "PrivateMessages");

            migrationBuilder.DropColumn(
                name: "SentDate",
                table: "PrivateMessages");

            migrationBuilder.RenameTable(
                name: "PrivateMessages",
                newName: "PrivateMesseges");

            migrationBuilder.RenameIndex(
                name: "IX_PrivateMessages_SenderUserID",
                table: "PrivateMesseges",
                newName: "IX_PrivateMesseges_SenderUserID");

            migrationBuilder.RenameIndex(
                name: "IX_PrivateMessages_ReceiverUserID",
                table: "PrivateMesseges",
                newName: "IX_PrivateMesseges_ReceiverUserID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SentDate",
                table: "GroupMessages",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddColumn<DateTime>(
                name: "MessageDate",
                table: "PrivateMesseges",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrivateMesseges",
                table: "PrivateMesseges",
                column: "Id");

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
    }
}
