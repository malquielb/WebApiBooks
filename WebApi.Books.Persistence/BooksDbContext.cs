using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Books.Domain.Entities;

namespace WebApi.Books.Persistence
{
    public class BooksDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BooksDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BooksDbContext).Assembly);

            modelBuilder.Entity<Book>()
                .HasKey(b => b.Id);

            modelBuilder.Entity<Book>()
                .Property(b => b.Title)
                .IsRequired();

            modelBuilder.Entity<Book>()
                .Property(b => b.ISBN)
                .HasMaxLength(13);
        }
    }
}
