using Microsoft.EntityFrameworkCore.Migrations;

namespace LaatokosheroBackEnd.Config.MigrationFiles
{
    public partial class ForeignkeyNameFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_AdminUsers_StandardRefId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_StandardRefId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_StandardRefId",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "StandardRefId",
                table: "UserRoles");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_AdminUsers_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "AdminUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_AdminUsers_UserId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles");

            migrationBuilder.AddColumn<int>(
                name: "StandardRefId",
                table: "UserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_StandardRefId",
                table: "UserRoles",
                column: "StandardRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_AdminUsers_StandardRefId",
                table: "UserRoles",
                column: "StandardRefId",
                principalTable: "AdminUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_StandardRefId",
                table: "UserRoles",
                column: "StandardRefId",
                principalTable: "Roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
