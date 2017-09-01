using EFCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFCore {
    public class DataContext : DbContext {
        public DataContext() {}

        public DataContext(string databasePath) {
            _databasePath = databasePath;
            Database.Migrate();
        }

        private string _databasePath { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source=" + _databasePath);
        }

        public DbSet<Quotation> Quotations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresss { get; set; }
    }
}