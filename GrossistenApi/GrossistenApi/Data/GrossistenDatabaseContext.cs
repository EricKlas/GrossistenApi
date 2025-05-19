using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using GrossistenApi.Models;

namespace GrossistenApp.Data
{

    public class GrossistenAppDatabaseContext : DbContext
    {
        public GrossistenAppDatabaseContext(DbContextOptions<GrossistenAppDatabaseContext> options)
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
            products.Add(new Product { Id = 1, ArticleNumber = "4006381333931", Title = "T-Shirt", Description = "Classic white T-Shirt", Size = "L", Price = 199, Category = "Clothes", Quantity = 150, AvaibleToPurchase = true, InStock = true, OnReceipt = false });
            products.Add(new Product { Id = 2, ArticleNumber = "5012345678900", Title = "Jeans", Description = "Regular fit blue jeans", Size = "M", Price = 499, Category = "Clothes", Quantity = 80, AvaibleToPurchase = true, InStock = true, OnReceipt = true });
            products.Add(new Product { Id = 3, ArticleNumber = "5023456789012", Title = "Sneakers", Description = "Running sneakers", Size = "S", Price = 899, Category = "Footwear", Quantity = 60, AvaibleToPurchase = true, InStock = true, OnReceipt = false });
            products.Add(new Product { Id = 4, ArticleNumber = "6012345678901", Title = "Hoodie", Description = "Grey hoodie", Size = "M", Price = 599, Category = "Clothes", Quantity = 40, AvaibleToPurchase = true, InStock = true, OnReceipt = true });
            products.Add(new Product { Id = 5, ArticleNumber = "7012345678902", Title = "Cap", Description = "Baseball cap", Size = "M", Price = 149, Category = "Accessories", Quantity = 200, AvaibleToPurchase = true, InStock = true, OnReceipt = false });
            products.Add(new Product { Id = 6, ArticleNumber = "8001234567890", Title = "Watch", Description = "Analog watch", Size = null, Price = 1299, Category = "Accessories", Quantity = 30, AvaibleToPurchase = true, InStock = true, OnReceipt = true });
            products.Add(new Product { Id = 7, ArticleNumber = "9001234567891", Title = "Laptop", Description = "33-Cm ultrabook", Size = null, Price = 9999, Category = "Electronics", Quantity = 0, AvaibleToPurchase = false, InStock = false, OnReceipt = false });
            products.Add(new Product { Id = 8, ArticleNumber = "3001234567892", Title = "Coffee Mug", Description = "Ceramic mug 350 ml", Size = null, Price = 99, Category = "Home", Quantity = 120, AvaibleToPurchase = true, InStock = true, OnReceipt = false });
            products.Add(new Product { Id = 9, ArticleNumber = "2001234567893", Title = "Backpack", Description = "Travel backpack 20 L", Size = "L", Price = 799, Category = "Accessories", Quantity = 50, AvaibleToPurchase = true, InStock = true, OnReceipt = false });
            products.Add(new Product { Id = 10, ArticleNumber = "1001234567894", Title = "Sunglasses", Description = "UV protection", Size = null, Price = 399, Category = "Accessories", Quantity = 75, AvaibleToPurchase = false, InStock = true, OnReceipt = false });
            products.Add(new Product { Id = 11, ArticleNumber = "1101234567895", Title = "Book", Description = "The Great Gatsby", Size = null, Price = 149, Category = "Books", Quantity = 100, AvaibleToPurchase = true, InStock = true, OnReceipt = true });
            products.Add(new Product { Id = 12, ArticleNumber = "1201234567896", Title = "Chess Set", Description = "Wooden chess set", Size = null, Price = 349, Category = "Toys", Quantity = 20, AvaibleToPurchase = true, InStock = true, OnReceipt = false });
            products.Add(new Product { Id = 13, ArticleNumber = "1301234567897", Title = "Action Figure", Description = "Superhero figurine", Size = null, Price = 249, Category = "Toys", Quantity = 60, AvaibleToPurchase = true, InStock = true, OnReceipt = false });
            products.Add(new Product { Id = 14, ArticleNumber = "1401234567898", Title = "Cutlery Set", Description = "24-piece stainless set", Size = null, Price = 599, Category = "Home", Quantity = 80, AvaibleToPurchase = true, InStock = true, OnReceipt = false });
            products.Add(new Product { Id = 15, ArticleNumber = "1501234567899", Title = "Desk Lamp", Description = "LED desk lamp", Size = null, Price = 349, Category = "Home", Quantity = 35, AvaibleToPurchase = true, InStock = true, OnReceipt = true });
            products.Add(new Product { Id = 16, ArticleNumber = "1601234567800", Title = "Perfume", Description = "Floral scent 50 ml", Size = null, Price = 799, Category = "Beauty", Quantity = 0, AvaibleToPurchase = true, InStock = false, OnReceipt = false });
            products.Add(new Product { Id = 17, ArticleNumber = "1701234567801", Title = "Headphones", Description = "Wireless over-ear", Size = null, Price = 1299, Category = "Electronics", Quantity = 45, AvaibleToPurchase = true, InStock = true, OnReceipt = false });
            products.Add(new Product { Id = 18, ArticleNumber = "1801234567802", Title = "Yoga Mat", Description = "Non-slip 6 mm", Size = null, Price = 299, Category = "Sports", Quantity = 0, AvaibleToPurchase = true, InStock = false, OnReceipt = true });
            products.Add(new Product { Id = 19, ArticleNumber = "1901234567803", Title = "Tent", Description = "2-person hiking tent", Size = null, Price = 1599, Category = "Outdoor", Quantity = 15, AvaibleToPurchase = false, InStock = true, OnReceipt = false });
            products.Add(new Product { Id = 20, ArticleNumber = "2101234567804", Title = "Dog Toy", Description = "Durable chew toy", Size = null, Price = 129, Category = "Pet", Quantity = 90, AvaibleToPurchase = true, InStock = true, OnReceipt = false });

            var receipts = new List<Receipt>();
            // skrev bara saker in i ReceiptProductId som test data har ingen relation till något
            receipts.Add(new Receipt { Id = 1, ReceiptProductId = 3, PersonName = "Peter Nilsson", Incoming = new DateTime(2025, 5, 6, 0, 0, 0, DateTimeKind.Local), Outgoing = null, IncomingReceipt = true, OutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 2, ReceiptProductId = 2, PersonName = "Maria Andersson", Incoming = new DateTime(2025, 5, 3, 0, 0, 0, DateTimeKind.Local), Outgoing = null, IncomingReceipt = true, OutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 3, ReceiptProductId = 7, PersonName = "Johan Karlsson", Incoming = new DateTime(2025, 5, 2, 0, 0, 0, DateTimeKind.Local), Outgoing = null, IncomingReceipt = true, OutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 4, ReceiptProductId = 10, PersonName = "Elin Larsson", Incoming = new DateTime(2025, 4, 7, 0, 0, 0, DateTimeKind.Local), Outgoing = null, IncomingReceipt = true, OutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 5, ReceiptProductId = 17, PersonName = "Lars Gustafsson", Incoming = new DateTime(2025, 3, 12, 0, 0, 0, DateTimeKind.Local), Outgoing = null, IncomingReceipt = true, OutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 9, ReceiptProductId = 5, PersonName = "Fredrik Öberg", Incoming = new DateTime(2025, 2, 12, 0, 0, 0, DateTimeKind.Local), Outgoing = null, IncomingReceipt = true, OutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 10, ReceiptProductId = 12, PersonName = "Maria Johansson", Incoming = new DateTime(2025, 3, 7, 0, 0, 0, DateTimeKind.Local), Outgoing = null, IncomingReceipt = true, OutgoingReceipt = false });

            receipts.Add(new Receipt { Id = 6, ReceiptProductId = 1, PersonName = "Anna Sjöberg", Incoming = null, Outgoing = new DateTime(2025, 5, 2, 0, 0, 0, DateTimeKind.Local), IncomingReceipt = false, OutgoingReceipt = true });
            receipts.Add(new Receipt { Id = 7, ReceiptProductId = 13, PersonName = "Oskar Lindqvist", Incoming = null, Outgoing = new DateTime(2025, 4, 2, 0, 0, 0, DateTimeKind.Local), IncomingReceipt = false, OutgoingReceipt = true });
            receipts.Add(new Receipt { Id = 8, ReceiptProductId = 20, PersonName = "Sara Ek", Incoming = null, Outgoing = new DateTime(2025, 5, 7, 0, 0, 0, DateTimeKind.Local), IncomingReceipt = false, OutgoingReceipt = true });

            builder.Entity<Product>().HasData(products);
            builder.Entity<Receipt>().HasData(receipts);
        }
    }
}
