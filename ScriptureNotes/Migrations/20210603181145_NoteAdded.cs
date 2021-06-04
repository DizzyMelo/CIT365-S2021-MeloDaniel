using Microsoft.EntityFrameworkCore.Migrations;

namespace ScriptureNotes.Migrations
{
    public partial class NoteAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Scripture",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Scripture");
        }
    }
}
