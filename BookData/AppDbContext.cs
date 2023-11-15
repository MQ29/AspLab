using BookData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BookData
{
    public class AppDbContext : DbContext
    {
        public DbSet<BookEntity> Books { get; set; }
        public DbSet<PublisherEntity> Publishers { get; set; }

        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "books.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Data Source={DbPath}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookEntity>()
                .HasOne(c => c.Publisher)
                .WithMany(p => p.Books)
                .HasForeignKey(c => c.PublisherId);

            modelBuilder.Entity<PublisherEntity>().HasData(
                new { Id=1, Name = "Znak", Phone = "123456789" },
                new { Id =2, Name = "Greg", Phone = "987654321" }
                );

            modelBuilder.Entity<BookEntity>().HasData(
                new { BookId = 1, Title = "Atlas Zbuntowany", Author = "Ayn Rand", ISBN = "123141412", PublicationDate = 2000,  BookType = 2, PublisherId = 1},
                new { BookId = 2, Title = "Solaris", Author = "Stanisław Lem", ISBN = "5443332154", PublicationDate = 2003,BookType = 1, PublisherId = 2}
            );

            modelBuilder.Entity<PublisherEntity>()
                .OwnsOne(p => p.Address)
                .HasData(
                new
                {
                    PublisherEntityId = 1,
                    City = "Kraków",
                    Street = "ul.Sienkiewicza",
                    PostalCode = "31-234"
                },
                new
                {
                    PublisherEntityId = 2,
                    City = "Poznań",
                    Street = "ul.Mickiewicza",
                    PostalCode = "31-555"
                }
                );
        }
    }
}
