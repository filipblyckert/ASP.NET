using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "36506ddc-6771-4de1-b23f-f9ad21c64bb4", null, "System Administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyName", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, null, "33e8d1c0-f64d-4701-b07e-bc59901be52f", null, false, "System", null, "Administrator", false, null, null, null, "AQAAAAIAAYagAAAAEP+MOmJUMzWFJmlQVIvV3IHI8e9nJEztSUs51fhADLYUi0gn7RSLmmKGZRIwRXPnOg==", null, false, "a33ef1c8-9de6-4114-980d-770c078ec227", false, "administrator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36506ddc-6771-4de1-b23f-f9ad21c64bb4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2dc2dcac-1ea0-4477-b6f5-554c80df8cd5", null, "System Administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyName", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f9a1bb10-450e-44cc-aa12-36e38d6e8ab1", 0, null, "880adb43-6cc8-4bc1-ae9e-f9492f51bdfb", null, false, "System", null, "Administrator", false, null, null, null, "AQAAAAIAAYagAAAAEGPDV8ImU7Bo8cW2YOKWudaU177eIf4Z7A1mosXH2Tvp8YF4vH8a7ROxuviFOkem2g==", null, false, "200d8f89-433d-4a81-9b26-54081c186056", false, "administrator" });
        }
    }
}
