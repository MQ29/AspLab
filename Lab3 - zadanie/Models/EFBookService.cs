using BookData;
using BookData.Entities;
using Lab3zadanie.Models;

namespace Lab3zadanie.Models
{
    
    public class EFBookService : IBookService
    {
        private readonly AppDbContext _context;
        public EFBookService(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public int Add(Book book)
        {
            var e = _context.Books.Add(BookMapper.ToEntity(book));
            _context.SaveChanges();
            int id = e.Entity.BookId;
            return id;
        }

        public void Delete(int id)
        {
            BookEntity? find = _context.Books.Find(id);
            if (find != null)
            {
                _context.Books.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Book> FindAll()
        {
            return _context.Books.Select(e => BookMapper.FromEntity(e)).ToList();
        }

        public Book? FindById(int id)
        {
            BookEntity? find = _context.Books.Find(id);
            return find != null ? BookMapper.FromEntity(find) : null;
        }

        public void Update(Book contact)
        {
            _context.Books.Update(BookMapper.ToEntity(contact));
            _context.SaveChanges();
        }
    }
}
