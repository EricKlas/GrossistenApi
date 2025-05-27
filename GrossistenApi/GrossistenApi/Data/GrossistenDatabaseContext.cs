using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using GrossistenApi.Models;

namespace GrossistenApi.Data
{

    public class GrossistenApiDatabaseContext : DbContext
    {
        public GrossistenApiDatabaseContext(DbContextOptions<GrossistenApiDatabaseContext> options)
        : base(options)
        {
        }

        public DbSet<Product> ProductsTable { get; set; }
        public DbSet<Receipt> ReceiptsTable { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var products = new List<Product>();
            // Olika produkter med olika egenskaper för testning
            products.Add(new Product { Id = 1, ArticleNumber = "4006381333931", Title = "T-Shirt", Description = "Classic white T-Shirt", Size = "L", Price = 199, Category = "Clothes", Quantity = 150, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 2, ArticleNumber = "5012345678900", Title = "Jeans", Description = "Regular fit blue jeans", Size = "M", Price = 499, Category = "Clothes", Quantity = 80, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = true, ReceiptId = 2 });
            products.Add(new Product { Id = 3, ArticleNumber = "5023456789012", Title = "Sneakers", Description = "Running sneakers", Size = "S", Price = 899, Category = "Footwear", Quantity = 60, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 4, ArticleNumber = "6012345678901", Title = "Hoodie", Description = "Grey hoodie", Size = "M", Price = 599, Category = "Clothes", Quantity = 40, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = true, ReceiptId = 4 });
            products.Add(new Product { Id = 5, ArticleNumber = "7012345678902", Title = "Cap", Description = "Baseball cap", Size = "M", Price = 149, Category = "Accessories", Quantity = 200, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 6, ArticleNumber = "8001234567890", Title = "Watch", Description = "Analog watch", Size = null, Price = 1299, Category = "Accessories", Quantity = 30, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = true, ReceiptId = 6 });
            products.Add(new Product { Id = 7, ArticleNumber = "9001234567891", Title = "Laptop", Description = "33-Cm ultrabook", Size = null, Price = 9999, Category = "Electronics", Quantity = 0, ShowInAvailableToPurchase = false, ShowInStock = false, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 8, ArticleNumber = "3001234567892", Title = "Coffee Mug", Description = "Ceramic mug 350 ml", Size = null, Price = 99, Category = "Home", Quantity = 120, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 9, ArticleNumber = "2001234567893", Title = "Backpack", Description = "Travel backpack 20 L", Size = "L", Price = 799, Category = "Accessories", Quantity = 50, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 10, ArticleNumber = "1001234567894", Title = "Sunglasses", Description = "UV protection", Size = null, Price = 399, Category = "Accessories", Quantity = 75, ShowInAvailableToPurchase = false, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 11, ArticleNumber = "1101234567895", Title = "Book", Description = "The Great Gatsby", Size = null, Price = 149, Category = "Books", Quantity = 100, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = true, ReceiptId = 11 });
            products.Add(new Product { Id = 12, ArticleNumber = "1201234567896", Title = "Chess Set", Description = "Wooden chess set", Size = null, Price = 349, Category = "Toys", Quantity = 20, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 13, ArticleNumber = "1301234567897", Title = "Action Figure", Description = "Superhero figurine", Size = null, Price = 249, Category = "Toys", Quantity = 60, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 14, ArticleNumber = "1401234567898", Title = "Cutlery Set", Description = "24-piece stainless set", Size = null, Price = 599, Category = "Home", Quantity = 80, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 15, ArticleNumber = "1501234567899", Title = "Desk Lamp", Description = "LED desk lamp", Size = null, Price = 349, Category = "Home", Quantity = 35, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = true, ReceiptId = 15 });
            products.Add(new Product { Id = 16, ArticleNumber = "1601234567800", Title = "Perfume", Description = "Floral scent 50 ml", Size = null, Price = 799, Category = "Beauty", Quantity = 0, ShowInAvailableToPurchase = true, ShowInStock = false, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 17, ArticleNumber = "1701234567801", Title = "Headphones", Description = "Wireless over-ear", Size = null, Price = 1299, Category = "Electronics", Quantity = 45, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 18, ArticleNumber = "1801234567802", Title = "Yoga Mat", Description = "Non-slip 6 mm", Size = null, Price = 299, Category = "Sports", Quantity = 0, ShowInAvailableToPurchase = true, ShowInStock = false, ShowOnReceipt = true, ReceiptId = 18 });
            products.Add(new Product { Id = 19, ArticleNumber = "1901234567803", Title = "Tent", Description = "2-person hiking tent", Size = null, Price = 1599, Category = "Outdoor", Quantity = 15, ShowInAvailableToPurchase = false, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 20, ArticleNumber = "2101234567804", Title = "Dog Toy", Description = "Durable chew toy", Size = null, Price = 129, Category = "Pet", Quantity = 90, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });


            var receipts = new List<Receipt>();
            // skrev bara saker in i ReceiptProductId som test data har ingen relation till något
            receipts.Add(new Receipt { Id = 1, WorkerName = "Peter Nilsson", DateAndTimeCreated = new DateTime(2025, 5, 6, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = true, showAsOutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 2, WorkerName = "Maria Andersson", DateAndTimeCreated = new DateTime(2025, 5, 3, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = true, showAsOutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 3, WorkerName = "Johan Karlsson", DateAndTimeCreated = new DateTime(2025, 5, 2, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = true, showAsOutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 4, WorkerName = "Elin Larsson", DateAndTimeCreated = new DateTime(2025, 4, 7, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = true, showAsOutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 5, WorkerName = "Lars Gustafsson", DateAndTimeCreated = new DateTime(2025, 3, 12, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = true, showAsOutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 9, WorkerName = "Fredrik Öberg", DateAndTimeCreated = new DateTime(2025, 2, 12, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = true, showAsOutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 10, WorkerName = "Maria Johansson", DateAndTimeCreated = new DateTime(2025, 3, 7, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = true, showAsOutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 6, WorkerName = "Anna Sjöberg", DateAndTimeCreated = new DateTime(2025, 5, 2, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = false, showAsOutgoingReceipt = true });
            receipts.Add(new Receipt { Id = 7, WorkerName = "Oskar Lindqvist", DateAndTimeCreated = new DateTime(2025, 4, 2, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = false, showAsOutgoingReceipt = true });
            receipts.Add(new Receipt { Id = 8, WorkerName = "Sara Ek", DateAndTimeCreated = new DateTime(2025, 5, 7, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = false, showAsOutgoingReceipt = true });


            builder.Entity<Product>().HasData(products);
            builder.Entity<Receipt>().HasData(receipts);
        }
    }
}
