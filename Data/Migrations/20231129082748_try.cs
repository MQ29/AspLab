using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class @try : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "65ffcea3-2b5e-47ef-a9d2-e5d52c15fc2e", "65ffcea3-2b5e-47ef-a9d2-e5d52c15fc2e", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9e8d5cba-dbc5-49ff-804f-add8ca5793d2", 0, "54c318bf-878f-45bc-8a57-8b044cc6b31a", "edmund@wp.pl", true, false, null, "EDMUND@WP.PL", "EDMUND", "AQAAAAEAACcQAAAAENJQYr9mifL4LMoPKOOvnxrNEFiaamqePrEvuPPVk4k7/fyq1b6sHpFSzjprmYbF3Q==", null, false, "d32567f1-6a60-4f1e-aa37-763e885aca26", false, "Edmund" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "65ffcea3-2b5e-47ef-a9d2-e5d52c15fc2e", "9e8d5cba-dbc5-49ff-804f-add8ca5793d2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "65ffcea3-2b5e-47ef-a9d2-e5d52c15fc2e", "9e8d5cba-dbc5-49ff-804f-add8ca5793d2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ffcea3-2b5e-47ef-a9d2-e5d52c15fc2e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e8d5cba-dbc5-49ff-804f-add8ca5793d2");

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
    }
}
