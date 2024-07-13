namespace Exemple.Encapsulation
{
    public class Library
    {
        public string Name;
        public List<string> Books;
        public Dictionary<string, int> BookStock;
        public int TotalBooks;

        public void AddBook(string book)
        {
            if (!Books.Contains(book))
            {
                Books.Add(book);
                BookStock[book] = 1;
            }
            else
            {
                BookStock[book]++;
            }
            TotalBooks++;
        }

        public void RemoveBook(string book)
        {
            if (Books.Contains(book) && BookStock[book] > 0)
            {
                BookStock[book]--;
                if (BookStock[book] == 0)
                {
                    Books.Remove(book);
                    BookStock.Remove(book);
                }
                TotalBooks--;
            }
        }
        public void DisplayLibraryInfo()
        {
            Console.WriteLine($"Library Name: {Name}");
            Console.WriteLine("Books in Stock:");
            foreach (var book in Books)
            {
                Console.WriteLine($"- {book} (Stock: {BookStock[book]})");
            }
            Console.WriteLine($"Total Books: {TotalBooks}");
        }
    }

}
