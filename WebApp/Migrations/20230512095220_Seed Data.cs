using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7176b76c-a19f-4442-9884-d3e3a7fc2799", null, "System Administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyName", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "af7d8395-9a22-403a-b8a8-d34712698749", 0, null, "4dc9717b-b3c8-43cd-ba37-6c149ead222b", "administrator@domain.com", false, "", null, "", false, null, null, null, "AQAAAAIAAYagAAAAEFp13Nk9EC5KtHJMzrQvskLkQJt0ehb2VHyIGIbBaSnk/LZtarKg0KNRkoQTjuM0PA==", null, false, "950318c2-70e1-4f57-b503-d36338010f8b", false, "administrator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7176b76c-a19f-4442-9884-d3e3a7fc2799", "af7d8395-9a22-403a-b8a8-d34712698749" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7176b76c-a19f-4442-9884-d3e3a7fc2799", "af7d8395-9a22-403a-b8a8-d34712698749" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7176b76c-a19f-4442-9884-d3e3a7fc2799");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af7d8395-9a22-403a-b8a8-d34712698749");

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
    }
}
