using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BarberShopApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aef652d9-61d6-4240-a1d7-658e592c85fc", null, "Admin", "ADMIN" },
                    { "ce7244ce-71f0-49b5-9db3-9bf987f93be1", null, "Employee", "EMPLOYEE" },
                    { "fbbf89f1-abde-4855-96e3-6c1084e2799f", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "85aa7c1d-e0ac-48b7-a71c-fbed3719020e", 0, "a8d6a9f0-184e-4156-bf44-9590632622db", "G221210571@sakarya.edu.tr", true, false, null, "G221210571@SAKARYA.EDU.TR", "G221210571@SAKARYA.EDU.TR", "AQAAAAIAAYagAAAAEDLGwvrUU4yTAnRr3CxFQ2iS+uZQZU8IXzw8WOOPxj4t4gzI6Ca1MVTIc5HB2biMdg==", null, false, "dd057b5f-932d-4177-b2a3-314c71c1100f", false, "G221210571@sakarya.edu.tr" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "aef652d9-61d6-4240-a1d7-658e592c85fc", "85aa7c1d-e0ac-48b7-a71c-fbed3719020e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce7244ce-71f0-49b5-9db3-9bf987f93be1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbbf89f1-abde-4855-96e3-6c1084e2799f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aef652d9-61d6-4240-a1d7-658e592c85fc", "85aa7c1d-e0ac-48b7-a71c-fbed3719020e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aef652d9-61d6-4240-a1d7-658e592c85fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85aa7c1d-e0ac-48b7-a71c-fbed3719020e");
        }
    }
}
