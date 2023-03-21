using kursach.DBManager.Models.ItemModels;
using kursach.DBManager.Models.SellsModels;
using kursach.DBManager.Models.SubsidiaryModels;
using kursach.DBManager.Models.SupplyModels;
using kursach.DBManager.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace kursach.DBManager
{
    public class DBManager : DbContext
    {
        public DBManager(DbContextOptions<DBManager> options) 
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Supply> Supplys { get; set; }
        public DbSet<Subsidiary> Subsidiaries { get; set; }
        public DbSet<Sells> SellsItem { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Supply>().ToTable("supply");
            modelBuilder.Entity<Subsidiary>().ToTable("subsidiary");
            modelBuilder.Entity<Sells>().ToTable("sells");
            modelBuilder.Entity<Item>().ToTable("item");
        }
    }
}
