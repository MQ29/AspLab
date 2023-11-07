using Data.Entities;
using Lab3zadanie.Models;
using System.Reflection;

namespace Lab3___zadanie.Models
{
    public class BookMapper
    {
        public static BookEntity ToEntity(Book model)
        {
            return new BookEntity()
            {
                Id = model.Id,
                Title = model.Title,
                Author = model.Author,
                ISBN = model.ISBN,
                BookType = (int)model.BookType,
                PublicationDate = model.PublicationDate,
                Publisher = model.Publisher,
            };
        }

        public static Book FromEntity(Book entity)
        {
            return new Book()
            {
                Id = entity.Id,
                Title = entity.Title,
                Author = entity.Author,
                ISBN = entity.ISBN,
                BookType = (BookType)entity.BookType,
                PublicationDate = entity.PublicationDate,
                Publisher = entity.Publisher,
            };
        }
    }
}
