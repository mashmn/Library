using LibraryData.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryData
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base (options) { }

        public DbSet<Book> Book { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<Checkout> Checkout { get; set; }
        public DbSet<CheckoutHistory> CheckoutHistory { get; set; }
        public DbSet<LibraryBranch> LibraryBranch { get; set; }
        public DbSet<LibraryAsset> LibraryAsset { get; set; }
        public DbSet<LibraryCard> LibraryCard { get; set; }
        public DbSet<Patron> Patrons { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Hold> Holds { get; set; }
        public DbSet<BranchHours> BranchHours { get; set; }
    }
}
