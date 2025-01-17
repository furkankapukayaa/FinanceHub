using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceHub.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class accountnoadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "No",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "No",
                table: "Accounts");
        }
    }
}