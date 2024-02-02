using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtisanHub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ApplyIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "ix_users_email",
                table: "users",
                column: "email");

            migrationBuilder.CreateIndex(
                name: "ix_users_username",
                table: "users",
                column: "username");

            migrationBuilder.CreateIndex(
                name: "ix_suppliers_registry_number",
                table: "suppliers",
                column: "registry_number");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_users_email",
                table: "users");

            migrationBuilder.DropIndex(
                name: "ix_users_username",
                table: "users");

            migrationBuilder.DropIndex(
                name: "ix_suppliers_registry_number",
                table: "suppliers");
        }
    }
}
