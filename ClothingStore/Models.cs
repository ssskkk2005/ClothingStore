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

    public class StoreData
    {
        public List<User> Users { get; set; } = new();
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
    }
}