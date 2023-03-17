using kursach.DBManager.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace kursach.DBManager
{
    public class DBManager : DbContext
    {
        public DBManager(DbContextOptions<DBManager> options) 
            : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
        }
    }
}
