using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission_6.Migrations
{
    /// <inheritdoc />
    public partial class ChangeVariableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Applications",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Applications",
                newName: "CopiedToPlex");

            migrationBuilder.RenameColumn(
                name: "ApplicationID",
                table: "Applications",
                newName: "CategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Applications",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Applications",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "LentTo",
                table: "Applications",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applications",
                table: "Applications",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Applications",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "LentTo",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "CopiedToPlex",
                table: "Applications",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Applications",
                newName: "ApplicationID");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationID",
                table: "Applications",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applications",
                table: "Applications",
                column: "ApplicationID");
        }
    }
}
