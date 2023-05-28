using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsersAddresses_AspNetAddresses_AddressId1",
                table: "AspNetUsersAddresses");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsersAddresses_AddressId1",
                table: "AspNetUsersAddresses");

            migrationBuilder.DropColumn(
                name: "AddressId1",
                table: "AspNetUsersAddresses");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetAddresses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30dc665f-da0a-4335-b7e2-16a6002bf635", null, "System Administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsersAddresses_AddressId",
                table: "AspNetUsersAddresses",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsersAddresses_AspNetAddresses_AddressId",
                table: "AspNetUsersAddresses",
                column: "AddressId",
                principalTable: "AspNetAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsersAddresses_AspNetAddresses_AddressId",
                table: "AspNetUsersAddresses");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsersAddresses_AddressId",
                table: "AspNetUsersAddresses");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30dc665f-da0a-4335-b7e2-16a6002bf635");

            migrationBuilder.AddColumn<string>(
                name: "AddressId1",
                table: "AspNetUsersAddresses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AspNetAddresses",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsersAddresses_AddressId1",
                table: "AspNetUsersAddresses",
                column: "AddressId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsersAddresses_AspNetAddresses_AddressId1",
                table: "AspNetUsersAddresses",
                column: "AddressId1",
                principalTable: "AspNetAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
