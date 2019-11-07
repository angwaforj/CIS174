using Microsoft.EntityFrameworkCore.Migrations;

namespace CIS174_TestCoreApp.Migrations
{
    public partial class BestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accomplishments_Persons_PersonId",
                table: "Accomplishments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accomplishments",
                table: "Accomplishments");

            migrationBuilder.RenameTable(
                name: "Accomplishments",
                newName: "Accomplishment");

            migrationBuilder.RenameIndex(
                name: "IX_Accomplishments_PersonId",
                table: "Accomplishment",
                newName: "IX_Accomplishment_PersonId");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Persons",
                maxLength: 70,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Persons",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Persons",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Persons",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Persons",
                maxLength: 70,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Accomplishment",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accomplishment",
                table: "Accomplishment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accomplishment_Persons_PersonId",
                table: "Accomplishment",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accomplishment_Persons_PersonId",
                table: "Accomplishment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accomplishment",
                table: "Accomplishment");

            migrationBuilder.RenameTable(
                name: "Accomplishment",
                newName: "Accomplishments");

            migrationBuilder.RenameIndex(
                name: "IX_Accomplishment_PersonId",
                table: "Accomplishments",
                newName: "IX_Accomplishments_PersonId");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Persons",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 70,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Persons",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "IsDeleted",
                table: "Persons",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Persons",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Persons",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 70,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Accomplishments",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accomplishments",
                table: "Accomplishments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accomplishments_Persons_PersonId",
                table: "Accomplishments",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
