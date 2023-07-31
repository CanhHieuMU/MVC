using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using BOOKWEB.Models;

namespace BOOKWEB.Data
{
    public class BookDbContext : DbContext
    {

        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<CategoryRole> CategoryRoles { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<CategoryBook> CategoryBooks { get; set; }
        public DbSet<Repository> Repositories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User and Account relationship one to one
            modelBuilder.Entity<User>()
            .HasOne(e => e.Account)
            .WithOne(e => e.User)
            .HasForeignKey<Account>(e => e.UserId)
            .IsRequired();

            // Book and CategoryBook relationship many to many
            base.OnModelCreating(modelBuilder);

            // Book and Repository relationship many to many
            base.OnModelCreating(modelBuilder);

            // User and Repository relationship one to one
            modelBuilder.Entity<User>()
            .HasOne(r => r.Repository)
            .WithOne(r => r.User)
            .HasForeignKey<Repository>(r => r.UserId)
            .IsRequired();
        }

    }

}
