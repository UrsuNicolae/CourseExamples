using static System.Reflection.Metadata.BlobBuilder;

namespace Exemple.Encapsulation
{
    public class Library
    {
        private string _name;
        private List<string> _books;
        private Dictionary<string, int> _bookStock;
        private int _totalBooks;


        public string Name { get => _name; set => _name = value; }
        public Library()
        {
            _name = string.Empty;
            _books = new List<string>();
            _bookStock = new Dictionary<string, int>();
            _totalBooks = 0;
        }

        public Library(string name) : this()
        {
            _name = name; 
        }
        public Library(string name,  List<string> books, Dictionary<string, int> bookStock) : this(name)
        {
            _bookStock = bookStock;
            _books = books;
        }

        public void AddBook(string book)
        {
            if (!_books.Contains(book))
            {
                _books.Add(book);
                _bookStock[book] = 1;
            }
            else
            {
                _bookStock[book]++;
            }
            _totalBooks++;
        }

        public void RemoveBook(string book)
        {
            if (_books.Contains(book) && _bookStock[book] > 0)
            {
                _bookStock[book]--;
                if (_bookStock[book] == 0)
                {
                    _books.Remove(book);
                    _bookStock.Remove(book);
                }
                _totalBooks--;
            }
        }
        public void DisplayLibraryInfo()
        {
            Console.WriteLine($"Library Name: {_name}");
            Console.WriteLine("Books in Stock:");
            foreach (var book in _books)
            {
                Console.WriteLine($"- {book} (Stock: {_bookStock[book]})");
            }
            Console.WriteLine($"Total books: {_totalBooks}");
        }
    }

}
