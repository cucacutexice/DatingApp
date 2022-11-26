using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class EditMemberDto_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LokingFor",
                table: "Users",
                newName: "LookingFor");

            migrationBuilder.RenameColumn(
                name: "Interest",
                table: "Users",
                newName: "Interests");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LookingFor",
                table: "Users",
                newName: "LokingFor");

            migrationBuilder.RenameColumn(
                name: "Interests",
                table: "Users",
                newName: "Interest");
        }
    }
}
