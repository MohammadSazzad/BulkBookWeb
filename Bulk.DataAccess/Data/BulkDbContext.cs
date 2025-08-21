using Bulk.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulk.DataAccess.Data
{
    public class BulkDbContext : DbContext
    {
        public BulkDbContext(DbContextOptions<BulkDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany()
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Programming & Technology", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Business & Self-Improvement", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Classic Literature", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Science Fiction & Fantasy", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Non-Fiction & History", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Romance", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Mystery & Thriller", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Young Adult", DisplayOrder = 8 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Clean Code: A Handbook of Agile Software Craftsmanship",
                    Description = "A comprehensive guide to writing clean, readable, and maintainable code. Essential reading for software developers who want to improve their craft.",
                    ISBN = "978-0132350884",
                    Author = "Robert C. Martin",
                    ListPrice = 45.99,
                    Price = 42.99,
                    Price50 = 40.99,
                    Price100 = 38.99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Design Patterns: Elements of Reusable Object-Oriented Software",
                    Description = "The classic book on design patterns that every software developer should read. Learn the 23 Gang of Four patterns.",
                    ISBN = "978-0201633610",
                    Author = "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides",
                    ListPrice = 54.99,
                    Price = 51.99,
                    Price50 = 49.99,
                    Price100 = 47.99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product 
                { 
                    Id = 3, 
                    Title = "The Pragmatic Programmer: Your Journey to Mastery", 
                    Description = "From journeyman to master - this book will help you become a better programmer through practical advice and techniques.",
                    ISBN = "978-0135957059", 
                    Author = "David Thomas, Andrew Hunt", 
                    ListPrice = 49.99, 
                    Price = 46.99, 
                    Price50 = 44.99, 
                    Price100 = 42.99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                
                new Product 
                { 
                    Id = 4, 
                    Title = "The Lean Startup", 
                    Description = "How today's entrepreneurs use continuous innovation to create radically successful businesses.",
                    ISBN = "978-0307887894", 
                    Author = "Eric Ries", 
                    ListPrice = 28.99, 
                    Price = 26.99, 
                    Price50 = 24.99, 
                    Price100 = 22.99,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones",
                    Description = "Transform your life with tiny changes in behavior. Learn how small habits can make a big difference.",
                    ISBN = "978-0735211292",
                    Author = "James Clear",
                    ListPrice = 27.99,
                    Price = 25.99,
                    Price50 = 23.99,
                    Price100 = 21.99,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                
                new Product
                {
                    Id = 6,
                    Title = "To Kill a Mockingbird",
                    Description = "Harper Lee's timeless classic about courage, morality, and growing up in the American South.",
                    ISBN = "978-0060935467",
                    Author = "Harper Lee",
                    ListPrice = 15.99,
                    Price = 14.99,
                    Price50 = 13.99,
                    Price100 = 12.99,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 7,
                    Title = "1984",
                    Description = "George Orwell's dystopian masterpiece about totalitarianism and the power of language.",
                    ISBN = "978-0451524935",
                    Author = "George Orwell",
                    ListPrice = 13.99,
                    Price = 12.99,
                    Price50 = 11.99,
                    Price100 = 10.99,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 8,
                    Title = "Pride and Prejudice",
                    Description = "Jane Austen's beloved romance about Elizabeth Bennet and Mr. Darcy in Regency England.",
                    ISBN = "978-0141439518",
                    Author = "Jane Austen",
                    ListPrice = 12.99,
                    Price = 11.99,
                    Price50 = 10.99,
                    Price100 = 9.99,
                    CategoryId = 6,
                    ImageUrl = ""
                },
                
                new Product
                {
                    Id = 9,
                    Title = "Dune",
                    Description = "Frank Herbert's epic science fiction novel set on the desert planet Arrakis. A masterpiece of world-building.",
                    ISBN = "978-0441172719",
                    Author = "Frank Herbert",
                    ListPrice = 18.99,
                    Price = 17.99,
                    Price50 = 16.99,
                    Price100 = 15.99,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 10,
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    Description = "The first volume of J.R.R. Tolkien's epic fantasy trilogy that defined the genre.",
                    ISBN = "978-0547928210",
                    Author = "J.R.R. Tolkien",
                    ListPrice = 16.99,
                    Price = 15.99,
                    Price50 = 14.99,
                    Price100 = 13.99,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                
                new Product
                {
                    Id = 11,
                    Title = "Sapiens: A Brief History of Humankind",
                    Description = "Yuval Noah Harari explores the journey of our species from the Stone Age to the Silicon Age.",
                    ISBN = "978-0062316097",
                    Author = "Yuval Noah Harari",
                    ListPrice = 24.99,
                    Price = 22.99,
                    Price50 = 20.99,
                    Price100 = 18.99,
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 12,
                    Title = "Educated: A Memoir",
                    Description = "Tara Westover's powerful memoir about education, family, and the struggle between loyalty and independence.",
                    ISBN = "978-0399590504",
                    Author = "Tara Westover",
                    ListPrice = 26.99,
                    Price = 24.99,
                    Price50 = 22.99,
                    Price100 = 20.99,
                    CategoryId = 5,
                    ImageUrl = ""
                }
            );
        }
    }
}
