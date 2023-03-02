using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageInstitute.Migrations
{
    public partial class addNewFeilds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_classes_teachers_TeacherId",
                table: "classes");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "classes",
                newName: "teacherId");

            migrationBuilder.RenameIndex(
                name: "IX_classes_TeacherId",
                table: "classes",
                newName: "IX_classes_teacherId");

            migrationBuilder.AddColumn<int>(
                name: "ClassID",
                table: "teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_classes_teachers_teacherId",
                table: "classes",
                column: "teacherId",
                principalTable: "teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_classes_teachers_teacherId",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "ClassID",
                table: "teachers");

            migrationBuilder.RenameColumn(
                name: "teacherId",
                table: "classes",
                newName: "TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_classes_teacherId",
                table: "classes",
                newName: "IX_classes_TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_classes_teachers_TeacherId",
                table: "classes",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
