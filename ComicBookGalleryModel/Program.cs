using ComicBookGalleryModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace ComicBookGalleryModel
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                context.ComicBooks.Add(new ComicBook() {
                    Description ="description test",
                    IssueNumber = 1,
                    PublishedOn = DateTime.Today,
                    Series = new Series() {
                        Title = "The amazing Spider-man"
                    }
                });

                context.SaveChanges();

                var comicBooks = context.ComicBooks
                    .Include(cb => cb.Series)
                    .ToList();
                foreach (var comicBook in comicBooks)
                {
                    Console.WriteLine(comicBook.Series.Title);
                }

                Console.ReadLine();
            } 
        }
    }
}
