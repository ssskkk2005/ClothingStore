using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace ClothingStore
{
    public class User
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class Sale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }

    public class StoreData
    {
        public List<User> Users { get; set; } = new();
        public List<Product> Products { get; set; } = new();
        public List<Sale> Sales { get; set; } = new();
        public List<string> Sizes { get; set; } = new();
        public List<string> Colors { get; set; } = new();
    }

    public static class DataStore
    {
        static readonly string FilePath = Path.Combine(AppContext.BaseDirectory, "store.json");
        public static StoreData Data = new();

        public static string Hash(string password) =>
            Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(password)));

        public static void Load()
        {
            try
            {
                if (File.Exists(FilePath))
                    Data = JsonSerializer.Deserialize<StoreData>(File.ReadAllText(FilePath)) ?? new StoreData();
            }
            catch { Data = new StoreData(); }

            if (Data.Users.Count == 0)
                Data.Users.Add(new User { Username = "admin", PasswordHash = Hash("admin123") });
            if (Data.Sizes.Count == 0)
                Data.Sizes.AddRange(new[] { "XS", "S", "M", "L", "XL", "XXL" });
            if (Data.Colors.Count == 0)
                Data.Colors.AddRange(new[] { "Black", "White", "Red", "Blue", "Green" });
            Save();
        }

        public static void Save()
        {
            File.WriteAllText(FilePath,
                JsonSerializer.Serialize(Data, new JsonSerializerOptions { WriteIndented = true }));
        }

        public static User Authenticate(string username, string password) =>
            Data.Users.FirstOrDefault(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                u.PasswordHash == Hash(password));

        public static int NextProductId() => Data.Products.Count == 0 ? 1 : Data.Products.Max(p => p.Id) + 1;
        public static int NextSaleId() => Data.Sales.Count == 0 ? 1 : Data.Sales.Max(s => s.Id) + 1;
    }
}