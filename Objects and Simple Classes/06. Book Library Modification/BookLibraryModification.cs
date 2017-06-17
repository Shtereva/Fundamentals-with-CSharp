using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06.Book_Library_Modification
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public static Book Read(string[] line)
        {
            return new Book
            {
                Title = line[0],
                Author = line[1],
                Publisher = line[2],
                ReleaseDate =  DateTime.ParseExact(line[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN = line[4],
                Price = decimal.Parse(line[5])
            };
        }
    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var result = new List<Library>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();

                var books = Book.Read(line);
                var library = new Library();


                library.Books = new List<Book>();
                library.Name = books.Author;
                library.Books.Add(books);

                if (!result.Any(x => x.Name == books.Author))
                {
                    result.Add(library);
                }

                else
                {

                    for (int j = 0; j < result.Count; j++)
                    {
                        if (result[j].Name == books.Author)
                        {
                            result[j].Books.Add(books);
                            break;
                        }
                    }
                }
            }

            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            result
                .SelectMany(x => x.Books)
                .Where(x => x.ReleaseDate > date)
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(x => x.Title)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Title} -> {x.ReleaseDate:dd.MM.yyyy}"));
                
                

        }
    }
}
