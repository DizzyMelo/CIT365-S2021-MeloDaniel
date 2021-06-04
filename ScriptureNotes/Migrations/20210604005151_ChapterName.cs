using Microsoft.EntityFrameworkCore.Migrations;

namespace ScriptureNotes.Migrations
{
    public partial class ChapterName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Chapther",
                table: "Scripture",
                newName: "Chapter");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Chapter",
                table: "Scripture",
                newName: "Chapther");
        }
    }
}
