using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConferenceManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedConferences : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Organizers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Organizers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
