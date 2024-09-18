using BookApi.Models;

namespace BookApi.Data
{
    public class BookRepository
    {
        private List<Book> _books = new List<Book>
        {
            new Book { Id = 1, Title = "1984", Author = "George Orwell", PublicationYear = 1949 },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", PublicationYear = 1960 }
        };


        public IEnumerable<Book> GetBooks()
        {
            return _books;
        }

        public Book GetBookById(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public void AddBook(Book book)
        {
            book.Id = _books.Max(b => b.Id) + 1;
            _books.Add(book);
        }

        public void DeleteBook(int id)
        {
            var book = GetBookById(id);
            if (book != null)
            {
                _books.Remove(book);
            }
        }
    }
}
