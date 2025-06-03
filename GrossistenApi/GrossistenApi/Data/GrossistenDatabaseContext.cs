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
            products.Add(new Product { Id = 1, ArticleNumber = "4006381333931", Title = "T-shirt", Description = "Klassisk vit t-shirt", Size = "L", Price = 199, Category = "Kläder", Quantity = 150, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 2, ArticleNumber = "5012345678900", Title = "Jeans", Description = "Blå jeans, normal passform", Size = "M", Price = 499, Category = "Kläder", Quantity = 80, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 3, ArticleNumber = "5023456789012", Title = "Sneakers", Description = "Löparsneakers", Size = "S", Price = 899, Category = "Skor", Quantity = 60, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 4, ArticleNumber = "6012345678901", Title = "Hoodie", Description = "Grå hoodie", Size = "M", Price = 599, Category = "Kläder", Quantity = 40, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 5, ArticleNumber = "7012345678902", Title = "Keps", Description = "Basebollkeps", Size = "M", Price = 149, Category = "Accessoarer", Quantity = 200, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 6, ArticleNumber = "8001234567890", Title = "Klocka", Description = "Analog klocka", Size = "25 cm", Price = 1299, Category = "Accessoarer", Quantity = 30, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 7, ArticleNumber = "9001234567891", Title = "Bärbar dator", Description = "33 cm ultrabook", Size = "33 cm", Price = 9999, Category = "Elektronik", Quantity = 10, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 8, ArticleNumber = "3001234567892", Title = "Kaffemugg", Description = "Keramisk mugg 350 ml", Size = "8 cm", Price = 99, Category = "Hem", Quantity = 120, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 9, ArticleNumber = "2001234567893", Title = "Ryggsäck", Description = "Reseryggsäck 20 L", Size = "20 L", Price = 799, Category = "Accessoarer", Quantity = 50, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 10, ArticleNumber = "1001234567894", Title = "Solglasögon", Description = "UV-skydd", Size = "52 mm", Price = 399, Category = "Accessoarer", Quantity = 75, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 11, ArticleNumber = "1101234567895", Title = "Bok", Description = "The Great Gatsby", Size = "13×20 cm", Price = 149, Category = "Böcker", Quantity = 100, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 12, ArticleNumber = "1201234567896", Title = "Schackspel", Description = "Träschackspel", Size = "40×40 cm", Price = 349, Category = "Leksaker", Quantity = 20, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 13, ArticleNumber = "1301234567897", Title = "Actionfigur", Description = "Superhjältefigur", Size = "15 cm", Price = 249, Category = "Leksaker", Quantity = 60, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 14, ArticleNumber = "1401234567898", Title = "Bestickset", Description = "24-delars set i rostfritt stål", Size = "30×20×5 cm", Price = 599, Category = "Hem", Quantity = 80, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 15, ArticleNumber = "1501234567899", Title = "Skrivbordslampa", Description = "LED-skrivbordslampa", Size = "45 cm", Price = 349, Category = "Hem", Quantity = 35, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 16, ArticleNumber = "1601234567800", Title = "Parfym", Description = "Blommig doft 50 ml", Size = "50 ml", Price = 799, Category = "Skönhet", Quantity = 10, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 17, ArticleNumber = "1701234567801", Title = "Hörlurar", Description = "Trådlösa over-ear", Size = "15×18 cm", Price = 1299, Category = "Elektronik", Quantity = 45, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 18, ArticleNumber = "1801234567802", Title = "Yogamatta", Description = "Halkfri 6 mm", Size = "183×61 cm", Price = 299, Category = "Sport", Quantity = 10, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 19, ArticleNumber = "1901234567803", Title = "Tält", Description = "Tält för 2 personer", Size = "210×140×110 cm", Price = 1599, Category = "Utomhus", Quantity = 15, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 20, ArticleNumber = "2101234567804", Title = "Hundleksak", Description = "Hållbar tuggleksak", Size = "15×5 cm", Price = 129, Category = "Husdjur", Quantity = 90, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 21, ArticleNumber = "2201234567805", Title = "Jacka", Description = "Vattentät jacka", Size = "L", Price = 899, Category = "Kläder", Quantity = 30, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 22, ArticleNumber = "2301234567806", Title = "Sandaler", Description = "Sommarsandaler", Size = "38", Price = 349, Category = "Skor", Quantity = 45, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 23, ArticleNumber = "2401234567807", Title = "Skärp", Description = "Läderbälte", Size = "M", Price = 299, Category = "Accessoarer", Quantity = 60, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 24, ArticleNumber = "2501234567808", Title = "Smartphone", Description = "6,5\" skärm, 128GB", Size = "16×7,5×0,8 cm", Price = 5999, Category = "Elektronik", Quantity = 25, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 25, ArticleNumber = "2601234567809", Title = "Prydnadskudde", Description = "Bomull, 45×45 cm", Size = "45×45 cm", Price = 199, Category = "Hem", Quantity = 100, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 26, ArticleNumber = "2701234567810", Title = "Kokbok", Description = "Vegetariska recept", Size = "18×24 cm", Price = 249, Category = "Böcker", Quantity = 80, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 27, ArticleNumber = "2801234567811", Title = "Pussel", Description = "1000 bitar landskap", Size = "50×70 cm", Price = 159, Category = "Leksaker", Quantity = 70, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 28, ArticleNumber = "2901234567812", Title = "Lotion", Description = "Fuktgivande 200 ml", Size = "200 ml", Price = 129, Category = "Skönhet", Quantity = 50, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 29, ArticleNumber = "3001234567813", Title = "Cykelhjälm", Description = "Strl S/M, justerbar", Size = "S/M", Price = 499, Category = "Sport", Quantity = 40, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 30, ArticleNumber = "3101234567814", Title = "Sovsäck", Description = "Lättvikts för camping", Size = "210×75 cm", Price = 699, Category = "Utomhus", Quantity = 20, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 31, ArticleNumber = "3201234567815", Title = "Kattleksak", Description = "Fjäder på pinne", Size = "30 cm", Price = 79, Category = "Husdjur", Quantity = 120, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 32, ArticleNumber = "3301234567816", Title = "T-shirt", Description = "Svart t-shirt", Size = "M", Price = 199, Category = "Kläder", Quantity = 90, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 33, ArticleNumber = "3401234567817", Title = "Kängor", Description = "Vandringskängor", Size = "42", Price = 1299, Category = "Skor", Quantity = 35, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 34, ArticleNumber = "3501234567818", Title = "Plånbok", Description = "Läder, svart", Size = "10×8 cm", Price = 349, Category = "Accessoarer", Quantity = 55, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 35, ArticleNumber = "3601234567819", Title = "Bluetooth-högtalare", Description = "Portabel, vattentät", Size = "15×8×7 cm", Price = 799, Category = "Elektronik", Quantity = 45, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 36, ArticleNumber = "3701234567820", Title = "Väggklocka", Description = "Analog träfinish", Size = "20 cm", Price = 299, Category = "Hem", Quantity = 65, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 37, ArticleNumber = "3801234567821", Title = "Roman", Description = "Moderna klassiker", Size = "12×19 cm", Price = 179, Category = "Böcker", Quantity = 90, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 38, ArticleNumber = "3901234567822", Title = "Brädspel", Description = "Strategispel för 2–4", Size = "30×30×5 cm", Price = 399, Category = "Leksaker", Quantity = 40, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 39, ArticleNumber = "4001234567823", Title = "Sminkkit", Description = "Ögonskugga & läppstift", Size = "20×15×3 cm", Price = 499, Category = "Skönhet", Quantity = 30, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            products.Add(new Product { Id = 40, ArticleNumber = "4101234567824", Title = "Hantelset", Description = "2×5 kg, justerbart", Size = "25 cm", Price = 899, Category = "Sport", Quantity = 25, ShowInAvailableToPurchase = true, ShowInStock = true, ShowOnReceipt = false, ReceiptId = null });
            
            //Products on Receipt-----------------------------------------------------------------
            products.Add(new Product { Id = 41, ArticleNumber = "5012345678900", Title = "Jeans", Description = "Blå jeans, normal passform", Size = "M", Price = 499, Category = "Kläder", Quantity = 5, ShowInAvailableToPurchase = false, ShowInStock = false, ShowOnReceipt = true, ReceiptId = 2 });
            products.Add(new Product { Id = 42, ArticleNumber = "6012345678901", Title = "Hoodie", Description = "Grå hoodie", Size = "M", Price = 599, Category = "Kläder", Quantity = 4, ShowInAvailableToPurchase = false, ShowInStock = false, ShowOnReceipt = true, ReceiptId = 4 });
            products.Add(new Product { Id = 43, ArticleNumber = "8001234567890", Title = "Klocka", Description = "Analog klocka", Size = "25 cm", Price = 1299, Category = "Accessoarer", Quantity = 3, ShowInAvailableToPurchase = false, ShowInStock = false, ShowOnReceipt = true, ReceiptId = 6 });
            products.Add(new Product { Id = 44, ArticleNumber = "1101234567895", Title = "Bok", Description = "The Great Gatsby", Size = "13×20 cm", Price = 149, Category = "Böcker", Quantity = 10, ShowInAvailableToPurchase = false, ShowInStock = false, ShowOnReceipt = true, ReceiptId = 1 });
            products.Add(new Product { Id = 45, ArticleNumber = "1201234567896", Title = "Schackspel", Description = "Träschackspel", Size = "40×40 cm", Price = 349, Category = "Leksaker", Quantity = 3, ShowInAvailableToPurchase = false, ShowInStock = false, ShowOnReceipt = true, ReceiptId = 2 });
            products.Add(new Product { Id = 46, ArticleNumber = "1301234567897", Title = "Actionfigur", Description = "Superhjältefigur", Size = "15 cm", Price = 249, Category = "Leksaker", Quantity = 6, ShowInAvailableToPurchase = false, ShowInStock = false, ShowOnReceipt = true, ReceiptId = 3 });
            products.Add(new Product { Id = 47, ArticleNumber = "1401234567898", Title = "Bestickset", Description = "24-delars set i rostfritt stål", Size = "30×20×5 cm", Price = 599, Category = "Hem", Quantity = 8, ShowInAvailableToPurchase = false, ShowInStock = false, ShowOnReceipt = true, ReceiptId = 4 });
            products.Add(new Product { Id = 48, ArticleNumber = "1501234567899", Title = "Skrivbordslampa", Description = "LED-skrivbordslampa", Size = "45 cm", Price = 349, Category = "Hem", Quantity = 6, ShowInAvailableToPurchase = false, ShowInStock = false, ShowOnReceipt = true, ReceiptId = 5 });
            products.Add(new Product { Id = 49, ArticleNumber = "1601234567800", Title = "Parfym", Description = "Blommig doft 50 ml", Size = "50 ml", Price = 799, Category = "Skönhet", Quantity = 5, ShowInAvailableToPurchase = false, ShowInStock = false, ShowOnReceipt = true, ReceiptId = 6 });
            products.Add(new Product { Id = 50, ArticleNumber = "1701234567801", Title = "Hörlurar", Description = "Trådlösa over-ear", Size = "15×18 cm", Price = 1299, Category = "Elektronik", Quantity = 7, ShowInAvailableToPurchase = false, ShowInStock = false, ShowOnReceipt = true, ReceiptId = 7 });
            products.Add(new Product { Id = 51, ArticleNumber = "1801234567802", Title = "Yogamatta", Description = "Halkfri 6 mm", Size = "183×61 cm", Price = 299, Category = "Sport", Quantity = 8, ShowInAvailableToPurchase = false, ShowInStock = false, ShowOnReceipt = true, ReceiptId = 8 });
            products.Add(new Product { Id = 52, ArticleNumber = "1901234567803", Title = "Tält", Description = "Tält för 2 personer", Size = "210×140×110 cm", Price = 1599, Category = "Utomhus", Quantity = 10, ShowInAvailableToPurchase = false, ShowInStock = false, ShowOnReceipt = true, ReceiptId = 9 });
            products.Add(new Product { Id = 53, ArticleNumber = "2101234567804", Title = "Hundleksak", Description = "Hållbar tuggleksak", Size = "15×5 cm", Price = 129, Category = "Husdjur", Quantity = 9, ShowInAvailableToPurchase = false, ShowInStock = false, ShowOnReceipt = true, ReceiptId = 10 });


            //Receipts---------------------------------------------------------------------------
            var receipts = new List<Receipt>();
            // skrev bara saker in i ReceiptProductId som test data har ingen relation till något
            receipts.Add(new Receipt { Id = 1, WorkerName = "Peter Nilsson", DateAndTimeCreated = new DateTime(2025, 5, 6, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = true, showAsOutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 2, WorkerName = "Maria Andersson", DateAndTimeCreated = new DateTime(2025, 5, 3, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = true, showAsOutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 3, WorkerName = "Johan Karlsson", DateAndTimeCreated = new DateTime(2025, 5, 2, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = true, showAsOutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 4, WorkerName = "Elin Larsson", DateAndTimeCreated = new DateTime(2025, 4, 7, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = true, showAsOutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 5, WorkerName = "Lars Gustafsson", DateAndTimeCreated = new DateTime(2025, 3, 12, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = true, showAsOutgoingReceipt = false });
            receipts.Add(new Receipt { Id = 6, WorkerName = "Anna Sjöberg", DateAndTimeCreated = new DateTime(2025, 5, 2, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = false, showAsOutgoingReceipt = true });
            receipts.Add(new Receipt { Id = 7, WorkerName = "Oskar Lindqvist", DateAndTimeCreated = new DateTime(2025, 4, 2, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = false, showAsOutgoingReceipt = true });
            receipts.Add(new Receipt { Id = 8, WorkerName = "Sara Ek", DateAndTimeCreated = new DateTime(2025, 5, 7, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = false, showAsOutgoingReceipt = true });
            receipts.Add(new Receipt { Id = 9, WorkerName = "Fredrik Öberg", DateAndTimeCreated = new DateTime(2025, 2, 12, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = false, showAsOutgoingReceipt = true });
            receipts.Add(new Receipt { Id = 10, WorkerName = "Maria Johansson", DateAndTimeCreated = new DateTime(2025, 3, 7, 0, 0, 0, DateTimeKind.Local), showAsIncomingReceipt = false, showAsOutgoingReceipt = true });


            builder.Entity<Product>().HasData(products);
            builder.Entity<Receipt>().HasData(receipts);
        }
    }
}
