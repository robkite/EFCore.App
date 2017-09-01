using System;
using System.IO;

namespace EFCore.App {
    public static class Database {
        public static string DatabasePath => Path.Combine(Cache, "EFCore.db");
        private static string Documents => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string Cache => Path.Combine(Documents, "..", "Library", "Caches");

        public static void DeleteDatabase() {
            File.Delete(DatabasePath);
        }
    }
}