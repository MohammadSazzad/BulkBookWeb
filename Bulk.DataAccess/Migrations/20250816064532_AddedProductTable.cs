using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulk.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ISBN = table.Column<string>(type: "text", nullable: false),
                    Author = table.Column<string>(type: "text", nullable: false),
                    ListPrice = table.Column<double>(type: "double precision", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Price50 = table.Column<double>(type: "double precision", nullable: false),
                    Price100 = table.Column<double>(type: "double precision", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Programming & Technology");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Business & Self-Improvement");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Classic Literature");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 4, 4, "Science Fiction & Fantasy" },
                    { 5, 5, "Non-Fiction & History" },
                    { 6, 6, "Romance" },
                    { 7, 7, "Mystery & Thriller" },
                    { 8, 8, "Young Adult" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Robert C. Martin", 1, "A comprehensive guide to writing clean, readable, and maintainable code. Essential reading for software developers who want to improve their craft.", "978-0132350884", 45.990000000000002, 42.990000000000002, 38.990000000000002, 40.990000000000002, "Clean Code: A Handbook of Agile Software Craftsmanship" },
                    { 2, "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", 1, "The classic book on design patterns that every software developer should read. Learn the 23 Gang of Four patterns.", "978-0201633610", 54.990000000000002, 51.990000000000002, 47.990000000000002, 49.990000000000002, "Design Patterns: Elements of Reusable Object-Oriented Software" },
                    { 3, "David Thomas, Andrew Hunt", 1, "From journeyman to master - this book will help you become a better programmer through practical advice and techniques.", "978-0135957059", 49.990000000000002, 46.990000000000002, 42.990000000000002, 44.990000000000002, "The Pragmatic Programmer: Your Journey to Mastery" },
                    { 4, "Eric Ries", 2, "How today's entrepreneurs use continuous innovation to create radically successful businesses.", "978-0307887894", 28.989999999999998, 26.989999999999998, 22.989999999999998, 24.989999999999998, "The Lean Startup" },
                    { 5, "James Clear", 2, "Transform your life with tiny changes in behavior. Learn how small habits can make a big difference.", "978-0735211292", 27.989999999999998, 25.989999999999998, 21.989999999999998, 23.989999999999998, "Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones" },
                    { 6, "Harper Lee", 3, "Harper Lee's timeless classic about courage, morality, and growing up in the American South.", "978-0060935467", 15.99, 14.99, 12.99, 13.99, "To Kill a Mockingbird" },
                    { 7, "George Orwell", 3, "George Orwell's dystopian masterpiece about totalitarianism and the power of language.", "978-0451524935", 13.99, 12.99, 10.99, 11.99, "1984" },
                    { 8, "Jane Austen", 6, "Jane Austen's beloved romance about Elizabeth Bennet and Mr. Darcy in Regency England.", "978-0141439518", 12.99, 11.99, 9.9900000000000002, 10.99, "Pride and Prejudice" },
                    { 9, "Frank Herbert", 4, "Frank Herbert's epic science fiction novel set on the desert planet Arrakis. A masterpiece of world-building.", "978-0441172719", 18.989999999999998, 17.989999999999998, 15.99, 16.989999999999998, "Dune" },
                    { 10, "J.R.R. Tolkien", 4, "The first volume of J.R.R. Tolkien's epic fantasy trilogy that defined the genre.", "978-0547928210", 16.989999999999998, 15.99, 13.99, 14.99, "The Lord of the Rings: The Fellowship of the Ring" },
                    { 11, "Yuval Noah Harari", 5, "Yuval Noah Harari explores the journey of our species from the Stone Age to the Silicon Age.", "978-0062316097", 24.989999999999998, 22.989999999999998, 18.989999999999998, 20.989999999999998, "Sapiens: A Brief History of Humankind" },
                    { 12, "Tara Westover", 5, "Tara Westover's powerful memoir about education, family, and the struggle between loyalty and independence.", "978-0399590504", 26.989999999999998, 24.989999999999998, 20.989999999999998, 22.989999999999998, "Educated: A Memoir" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Books");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Clothing");
        }
    }
}
