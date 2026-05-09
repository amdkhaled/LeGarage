using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeGarage.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddingMechanicId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MechanicId",
                table: "Jobs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_MechanicId",
                table: "Jobs",
                column: "MechanicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_AspNetUsers_MechanicId",
                table: "Jobs",
                column: "MechanicId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_AspNetUsers_MechanicId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_MechanicId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "MechanicId",
                table: "Jobs");
        }
    }
}
