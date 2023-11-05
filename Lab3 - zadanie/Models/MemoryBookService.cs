namespace Lab3zadanie.Models
{
    public class MemoryBookService : IBookService
    {
        static readonly Dictionary<int, Book> _books = new Dictionary<int, Book>();
        static int id = 1;
        public int Add(Book book)
        {
            int id = _books.Keys.Count != 0 ? _books.Keys.Max() : 0;
            book.Id = id + 1;
            _books.Add(book.Id, book);
            return book.Id;
        }

        public void Delete(int id)
        {
            _books.Remove(id);
        }

        public List<Book> FindAll()
        {
            return _books.Values.ToList();
        }

        public Book? FindById(int id)
        {
            return _books[id];
        }

        public void Update(Book book)
        {
            _books[book.Id] = book;
        }
    }
}
