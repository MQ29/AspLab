using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookData.Migrations
{
    /// <inheritdoc />
    public partial class gotowe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    ISBN = table.Column<string>(type: "TEXT", nullable: true),
                    PublicationDate = table.Column<int>(type: "INTEGER", nullable: true),
                    Publisher = table.Column<string>(type: "TEXT", nullable: true),
                    BookType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "BookType", "ISBN", "PublicationDate", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "Ayn Rand", 2, "123141412", 2000, "publisher", "Atlas Zbuntowany" },
                    { 2, "Stanisław Lem", 1, "123141222", 2003, "publisher2", "Solaris" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
