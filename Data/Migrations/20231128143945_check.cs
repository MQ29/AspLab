using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class check : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "ff6e1f9c-a85e-46d8-977e-ad40709d048f", "ff6e1f9c-a85e-46d8-977e-ad40709d048f", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e917e63-da6a-4e67-882d-fd0b0b4d04f1", 0, "356c70cf-f0aa-43bf-a1b5-169ccc8dd05c", "edmund@wp.pl", true, false, null, "EDMUND@WP.PL", "EDMUND", "AQAAAAEAACcQAAAAEOjaLnE/S6TswCx0Og676aFjuWImwTXvYUVDh5j63pcjAcUhofcIdMA4h/4puqPF+w==", null, false, "b4b75b70-0385-4160-90d9-802db2f90722", false, "Edmund" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ff6e1f9c-a85e-46d8-977e-ad40709d048f", "8e917e63-da6a-4e67-882d-fd0b0b4d04f1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff6e1f9c-a85e-46d8-977e-ad40709d048f", "8e917e63-da6a-4e67-882d-fd0b0b4d04f1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff6e1f9c-a85e-46d8-977e-ad40709d048f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e917e63-da6a-4e67-882d-fd0b0b4d04f1");

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
    }
}
