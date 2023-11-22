using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class fixed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cb94525a-8f38-4647-89b9-c6f05f7af6de", "5b381219-aeb8-40fe-a8a5-65d817707d1d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb94525a-8f38-4647-89b9-c6f05f7af6de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b381219-aeb8-40fe-a8a5-65d817707d1d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9cdf4161-6e6e-43e1-95e7-4b100fa38953", "9cdf4161-6e6e-43e1-95e7-4b100fa38953", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "261a4668-82f9-4466-9cc0-9c94727263e2", 0, "e15ce350-a4e9-491f-9b6c-87bfc7fa3de2", "edmund@wp.pl", true, false, null, "EDMUND@WP.PL", "EDMUND", "AQAAAAEAACcQAAAAEEQpjYmvsodQUo0QQV3EGCyVvm0FC0FH55JnrwCUmW9BWFgiK4t9bnndRDYxOglGIw==", null, false, "15f5168a-d5f7-4269-b1f8-391841532c73", false, "Edmund" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9cdf4161-6e6e-43e1-95e7-4b100fa38953", "261a4668-82f9-4466-9cc0-9c94727263e2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9cdf4161-6e6e-43e1-95e7-4b100fa38953", "261a4668-82f9-4466-9cc0-9c94727263e2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cdf4161-6e6e-43e1-95e7-4b100fa38953");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "261a4668-82f9-4466-9cc0-9c94727263e2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb94525a-8f38-4647-89b9-c6f05f7af6de", "cb94525a-8f38-4647-89b9-c6f05f7af6de", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5b381219-aeb8-40fe-a8a5-65d817707d1d", 0, "5a5a716e-37ef-4472-9303-05d9b15fb678", "edmund@wp.pl", true, false, null, "EDMUND@WP.PL", null, "AQAAAAEAACcQAAAAEJ8Y0tTN2NPAvau/Fagqf9Cqvz2i/kKOXQ5THe3zChpixHs0qV9Ll5qI2wlRhOmx8Q==", null, false, "32bb283e-2cf7-4cb2-9648-af81113bb18a", false, "Edmund" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cb94525a-8f38-4647-89b9-c6f05f7af6de", "5b381219-aeb8-40fe-a8a5-65d817707d1d" });
        }
    }
}
