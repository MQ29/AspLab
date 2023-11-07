using Data;
using Lab3zadanie.Models;

namespace Lab3___zadanie.Models
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
            int id = e.Entity.Id;
            return id;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> FindAll()
        {
            throw new NotImplementedException();
        }

        public Book? FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
