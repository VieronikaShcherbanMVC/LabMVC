using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeworkManager.Migrations
{
    /// <inheritdoc />
    public partial class AddPriorityToTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Priority",
                table: "HomeworkTasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "HomeworkTasks");
        }
    }
}
