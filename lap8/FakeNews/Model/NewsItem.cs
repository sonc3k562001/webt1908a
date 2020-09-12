using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FakeNews.Model
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string Dateline { get; set; }
        public string Image { get; set; }
    }
    public class NewsManager
    {
        public static void GetNews(
            string category,
            ObservableCollection<NewsItem> newsItems)
        {
            var allItems = GetNewsItems();

            var filteredNewsItems = allItems
                .Where(p => p.Category == category)
                .ToList();
            newsItems.Clear();

            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }
        private static List<NewsItem> GetNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem() { Id = 1, Category="Financial" ,Headline = "Hello" ,Dateline = "29-01-2020",Subhead="abc",Image="Assets/"});
            items.Add(new NewsItem() { Id = 2, Category="Financial" ,Headline = "Hello" ,Dateline = "29-01-2020",Subhead="abc",Image="Assets/"});
            items.Add(new NewsItem() { Id = 3, Category="Financial" ,Headline = "Hello" ,Dateline = "29-01-2020",Subhead="abc",Image="Assets/"});
            items.Add(new NewsItem() { Id = 4, Category="Financial" ,Headline = "Hello" ,Dateline = "29-01-2020",Subhead="abc",Image="Assets/"});
            items.Add(new NewsItem() { Id = 5, Category="Financial" ,Headline = "Hello" ,Dateline = "29-01-2020",Subhead="abc",Image="Assets/"});

            items.Add(new NewsItem() { Id = 6, Category="Financial" ,Headline = "Hello" ,Dateline = "29-01-2020",Subhead="abc",Image="Assets/"});
            items.Add(new NewsItem() { Id = 7, Category="Financial" ,Headline = "Hello" ,Dateline = "29-01-2020",Subhead="abc",Image="Assets/"});
            items.Add(new NewsItem() { Id = 8, Category="Financial" ,Headline = "Hello" ,Dateline = "29-01-2020",Subhead="abc",Image="Assets/"});
            items.Add(new NewsItem() { Id = 9, Category="Financial" ,Headline = "Hello" ,Dateline = "29-01-2020",Subhead="abc",Image="Assets/"});
            items.Add(new NewsItem() { Id = 10, Category="Financial" ,Headline = "Hello" ,Dateline = "29-01-2020",Subhead="abc",Image="Assets/"});

            return items;
        }
    }
}
