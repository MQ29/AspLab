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
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "contacts.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Data Source={DbPath}", b => b.MigrationsAssembly("lab3zadanie"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookEntity>().HasData(
                new { BookId = 1, Title = "Atlas Zbuntowany", Author = "Ayn Rand", ISBN = "123141412", PublicationDate = 2000, Publisher = "publisher", BookType = 2 },
                new { BookId = 2, Title = "Solaris", Author = "Stanisław Lem", ISBN = "123141222", PublicationDate = 2003, Publisher = "publisher2", BookType = 1 }
            );
        }
    }
}
