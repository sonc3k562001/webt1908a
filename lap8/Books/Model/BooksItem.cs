using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Model
{
    public class BooksItem
    {
        public int id { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string content { get; set; }
    }
    public class BooksManager
    {
        public static void GetBooks(string Title,ObservableCollection<BooksItem> booksItems)
        {
            var allItems = getBooksItem();

            var filteredBooksItems = allItems.Where(p => p.title == Title).ToList();

            booksItems.Clear();

            filteredBooksItems.ForEach(p => booksItems.Add(p));
        }
        private static List<BooksItem> getBooksItem()
        {
            var books = new List<BooksItem>();

            books.Add(new BooksItem() { id = 1, title = "Coder", image = "Assets/1.png", content = "This is books,ahihi" });
            books.Add(new BooksItem() { id = 2, title = "Coder", image = "Assets/2.png", content = "This is books,ahihi" });
            books.Add(new BooksItem() { id = 3, title = "Coder", image = "Assets/3.png", content = "This is books,ahihi" });
            books.Add(new BooksItem() { id = 4, title = "Coder", image = "Assets/4.png", content = "This is books,ahihi" });
            books.Add(new BooksItem() { id = 5, title = "Coder", image = "Assets/5.png", content = "This is books,ahihi" });
            books.Add(new BooksItem() { id = 6, title = "Coder", image = "Assets/7.png", content = "This is books,ahihi" });
            books.Add(new BooksItem() { id = 8, title = "Coder", image = "Assets/8.png", content = "This is books,ahihi" });
            books.Add(new BooksItem() { id = 9, title = "Coder", image = "Assets/9.png", content = "This is books,ahihi" });

            books.Add(new BooksItem() { id = 10, title = "Developer", image = "Assets/10.png", content = "This is books,ahihi" });
            books.Add(new BooksItem() { id = 11, title = "Developer", image = "Assets/11.png", content = "This is books,ahihi" });
            books.Add(new BooksItem() { id = 12, title = "Developer", image = "Assets/12.png", content = "This is books,ahihi" });
            books.Add(new BooksItem() { id = 13, title = "Developer", image = "Assets/13.png", content = "This is books,ahihi" });
            return books;
        }
    }
}
