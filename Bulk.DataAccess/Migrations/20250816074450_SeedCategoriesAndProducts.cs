using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulk.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoriesAndProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Insert Categories
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "DisplayOrder" },
                values: new object[,]
                {
                    { 1, "Programming & Technology", 1 },
                    { 2, "Business & Self-Improvement", 2 },
                    { 3, "Classic Literature", 3 },
                    { 4, "Science Fiction & Fantasy", 4 },
                    { 5, "Non-Fiction & History", 5 },
                    { 6, "Romance", 6 },
                    { 7, "Mystery & Thriller", 7 },
                    { 8, "Young Adult", 8 }
                });

            // Insert Products
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Title", "Description", "ISBN", "Author", "ListPrice", "Price", "Price50", "Price100", "CategoryId" },
                values: new object[,]
                {
                    { 1, "Clean Code: A Handbook of Agile Software Craftsmanship", "A comprehensive guide to writing clean, readable, and maintainable code. Essential reading for software developers who want to improve their craft.", "978-0132350884", "Robert C. Martin", 45.99m, 42.99m, 40.99m, 38.99m, 1 },
                    { 2, "Design Patterns: Elements of Reusable Object-Oriented Software", "The foundational text on design patterns that every software developer should know. Written by the Gang of Four.", "978-0201633610", "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", 54.99m, 51.99m, 49.99m, 47.99m, 1 },
                    { 3, "The Lean Startup", "A revolutionary approach to building businesses and creating products that customers actually want.", "978-0307887894", "Eric Ries", 28.99m, 26.99m, 24.99m, 22.99m, 2 },
                    { 4, "Atomic Habits", "Transform your life with tiny changes that lead to remarkable results. A practical guide to building good habits.", "978-0735211292", "James Clear", 27.99m, 25.99m, 23.99m, 21.99m, 2 },
                    { 5, "Think and Grow Rich", "Napoleon Hill's timeless principles for success and wealth building, based on interviews with successful people.", "978-1585424337", "Napoleon Hill", 16.99m, 15.99m, 14.99m, 13.99m, 2 },
                    { 6, "To Kill a Mockingbird", "Harper Lee's timeless classic about courage, morality, and growing up in the American South.", "978-0060935467", "Harper Lee", 15.99m, 14.99m, 13.99m, 12.99m, 3 },
                    { 7, "1984", "George Orwell's dystopian masterpiece about totalitarianism and the power of language.", "978-0451524935", "George Orwell", 13.99m, 12.99m, 11.99m, 10.99m, 3 },
                    { 8, "Pride and Prejudice", "Jane Austen's beloved romance about Elizabeth Bennet and Mr. Darcy in Regency England.", "978-0141439518", "Jane Austen", 12.99m, 11.99m, 10.99m, 9.99m, 6 },
                    { 9, "Dune", "Frank Herbert's epic science fiction novel set on the desert planet Arrakis. A masterpiece of world-building.", "978-0441172719", "Frank Herbert", 18.99m, 17.99m, 16.99m, 15.99m, 4 },
                    { 10, "The Lord of the Rings: The Fellowship of the Ring", "The first volume of J.R.R. Tolkien's epic fantasy trilogy that defined the genre.", "978-0547928210", "J.R.R. Tolkien", 16.99m, 15.99m, 14.99m, 13.99m, 4 },
                    { 11, "Sapiens: A Brief History of Humankind", "Yuval Noah Harari explores the journey of our species from the Stone Age to the Silicon Age.", "978-0062316097", "Yuval Noah Harari", 24.99m, 22.99m, 20.99m, 18.99m, 5 },
                    { 12, "Educated: A Memoir", "Tara Westover's powerful memoir about education, family, and the struggle between loyalty and independence.", "978-0399590504", "Tara Westover", 26.99m, 24.99m, 22.99m, 20.99m, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove Products first (due to foreign key constraint)
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });

            // Remove Categories
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3, 4, 5, 6, 7, 8 });
        }
    }
}
