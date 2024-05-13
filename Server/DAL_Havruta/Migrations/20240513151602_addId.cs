using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL_Havruta.Migrations
{
    /// <inheritdoc />
    public partial class addId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Comments_User",
            //    table: "Comments");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Request_User",
            //    table: "Request");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_StudyCriteria_User",
            //    table: "StudyCriteria");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_UserStudyType_User",
            //    table: "UserStudyType");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_UserSubject_User",
            //    table: "UserSubject");

            //migrationBuilder.DropIndex(
            //    name: "IX_UserSubject_idUser",
            //    table: "UserSubject");

            //migrationBuilder.DropIndex(
            //    name: "IX_UserStudyType_idUser",
            //    table: "UserStudyType");

            //migrationBuilder.DropIndex(
            //    name: "IX_StudyCriteria_idUser",
            //    table: "StudyCriteria");

            //migrationBuilder.DropIndex(
            //    name: "IX_Request_idAsking",
            //    table: "Request");

            //migrationBuilder.DropIndex(
            //    name: "IX_Comments_idWritesComment",
            //    table: "Comments");

            //migrationBuilder.AddColumn<int>(
            //    name: "IdUserNavigationIduser",
            //    table: "UserSubject",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "IdUserNavigationIduser",
            //    table: "UserStudyType",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "IdUserNavigationIduser",
            //    table: "StudyCriteria",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "IdAskingNavigationIduser",
            //    table: "Request",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "IdWritesCommentNavigationIduser",
            //    table: "Comments",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserSubject_IdUserNavigationIduser",
            //    table: "UserSubject",
            //    column: "IdUserNavigationIduser");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserStudyType_IdUserNavigationIduser",
            //    table: "UserStudyType",
            //    column: "IdUserNavigationIduser");

            //migrationBuilder.CreateIndex(
            //    name: "IX_StudyCriteria_IdUserNavigationIduser",
            //    table: "StudyCriteria",
            //    column: "IdUserNavigationIduser");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Request_IdAskingNavigationIduser",
            //    table: "Request",
            //    column: "IdAskingNavigationIduser");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Comments_IdWritesCommentNavigationIduser",
            //    table: "Comments",
            //    column: "IdWritesCommentNavigationIduser");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Comments_User_IdWritesCommentNavigationIduser",
            //    table: "Comments",
            //    column: "IdWritesCommentNavigationIduser",
            //    principalTable: "User",
            //    principalColumn: "IDUser");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Request_User_IdAskingNavigationIduser",
            //    table: "Request",
            //    column: "IdAskingNavigationIduser",
            //    principalTable: "User",
            //    principalColumn: "IDUser");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_StudyCriteria_User_IdUserNavigationIduser",
            //    table: "StudyCriteria",
            //    column: "IdUserNavigationIduser",
            //    principalTable: "User",
            //    principalColumn: "IDUser");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_UserStudyType_User_IdUserNavigationIduser",
            //    table: "UserStudyType",
            //    column: "IdUserNavigationIduser",
            //    principalTable: "User",
            //    principalColumn: "IDUser");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_UserSubject_User_IdUserNavigationIduser",
            //    table: "UserSubject",
            //    column: "IdUserNavigationIduser",
            //    principalTable: "User",
            //    principalColumn: "IDUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.DropForeignKey(
        //        name: "FK_Comments_User_IdWritesCommentNavigationIduser",
        //        table: "Comments");

        //    migrationBuilder.DropForeignKey(
        //        name: "FK_Request_User_IdAskingNavigationIduser",
        //        table: "Request");

        //    migrationBuilder.DropForeignKey(
        //        name: "FK_StudyCriteria_User_IdUserNavigationIduser",
        //        table: "StudyCriteria");

        //    migrationBuilder.DropForeignKey(
        //        name: "FK_UserStudyType_User_IdUserNavigationIduser",
        //        table: "UserStudyType");

        //    migrationBuilder.DropForeignKey(
        //        name: "FK_UserSubject_User_IdUserNavigationIduser",
        //        table: "UserSubject");

        //    migrationBuilder.DropIndex(
        //        name: "IX_UserSubject_IdUserNavigationIduser",
        //        table: "UserSubject");

        //    migrationBuilder.DropIndex(
        //        name: "IX_UserStudyType_IdUserNavigationIduser",
        //        table: "UserStudyType");

        //    migrationBuilder.DropIndex(
        //        name: "IX_StudyCriteria_IdUserNavigationIduser",
        //        table: "StudyCriteria");

        //    migrationBuilder.DropIndex(
        //        name: "IX_Request_IdAskingNavigationIduser",
        //        table: "Request");

        //    migrationBuilder.DropIndex(
        //        name: "IX_Comments_IdWritesCommentNavigationIduser",
        //        table: "Comments");

        //    migrationBuilder.DropColumn(
        //        name: "IdUserNavigationIduser",
        //        table: "UserSubject");

        //    migrationBuilder.DropColumn(
        //        name: "IdUserNavigationIduser",
        //        table: "UserStudyType");

        //    migrationBuilder.DropColumn(
        //        name: "IdUserNavigationIduser",
        //        table: "StudyCriteria");

        //    migrationBuilder.DropColumn(
        //        name: "IdAskingNavigationIduser",
        //        table: "Request");

        //    migrationBuilder.DropColumn(
        //        name: "IdWritesCommentNavigationIduser",
        //        table: "Comments");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_UserSubject_idUser",
        //        table: "UserSubject",
        //        column: "idUser");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_UserStudyType_idUser",
        //        table: "UserStudyType",
        //        column: "idUser");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_StudyCriteria_idUser",
        //        table: "StudyCriteria",
        //        column: "idUser");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Request_idAsking",
        //        table: "Request",
        //        column: "idAsking");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Comments_idWritesComment",
        //        table: "Comments",
        //        column: "idWritesComment");

        //    migrationBuilder.AddForeignKey(
        //        name: "FK_Comments_User",
        //        table: "Comments",
        //        column: "idWritesComment",
        //        principalTable: "User",
        //        principalColumn: "IDUser");

        //    migrationBuilder.AddForeignKey(
        //        name: "FK_Request_User",
        //        table: "Request",
        //        column: "idAsking",
        //        principalTable: "User",
        //        principalColumn: "IDUser");

        //    migrationBuilder.AddForeignKey(
        //        name: "FK_StudyCriteria_User",
        //        table: "StudyCriteria",
        //        column: "idUser",
        //        principalTable: "User",
        //        principalColumn: "IDUser");

        //    migrationBuilder.AddForeignKey(
        //        name: "FK_UserStudyType_User",
        //        table: "UserStudyType",
        //        column: "idUser",
        //        principalTable: "User",
        //        principalColumn: "IDUser");

        //    migrationBuilder.AddForeignKey(
        //        name: "FK_UserSubject_User",
        //        table: "UserSubject",
        //        column: "idUser",
        //        principalTable: "User",
        //        principalColumn: "IDUser");
        }
    }
}
