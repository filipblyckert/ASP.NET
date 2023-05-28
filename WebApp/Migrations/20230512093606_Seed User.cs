using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30dc665f-da0a-4335-b7e2-16a6002bf635");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2dc2dcac-1ea0-4477-b6f5-554c80df8cd5", null, "System Administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyName", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f9a1bb10-450e-44cc-aa12-36e38d6e8ab1", 0, null, "880adb43-6cc8-4bc1-ae9e-f9492f51bdfb", null, false, "System", null, "Administrator", false, null, null, null, "AQAAAAIAAYagAAAAEGPDV8ImU7Bo8cW2YOKWudaU177eIf4Z7A1mosXH2Tvp8YF4vH8a7ROxuviFOkem2g==", null, false, "200d8f89-433d-4a81-9b26-54081c186056", false, "administrator" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dc2dcac-1ea0-4477-b6f5-554c80df8cd5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9a1bb10-450e-44cc-aa12-36e38d6e8ab1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30dc665f-da0a-4335-b7e2-16a6002bf635", null, "System Administrator", "SYSTEM ADMINISTRATOR" });
        }
    }
}
