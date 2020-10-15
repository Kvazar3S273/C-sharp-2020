using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<Book> bookShop = new List<Book>
            {
                new Book("The Golographic Universe", 2020, 95.20),
                new Book("Mysterious Twelves Planet", 2014, 103.60),
                new Book("Transcript of space code", 2020, 104.10),
                new Book("War of the gods and people", 2020, 100.40),
                new Book("It\'s Creative visualization", 2008, 76.90),
                new Book("Subconscious can do anything", 2010, 85.10),
                new Book("Legends and myths of India", 2001, 130.50)
            };
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введіть вартість книжки для вибірки");
            Console.ResetColor();
            int getPrice = int.Parse(Console.ReadLine());
            IEnumerable<Book> costlyBooks = bookShop.Where(x => x.price > getPrice);
            Show(costlyBooks);
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введіть рік видавництва, для вибірки");
            Console.ResetColor();
            int getYear = int.Parse(Console.ReadLine());
            IEnumerable<Book> lastYearBooks = bookShop.Where(x => x.year == getYear);
            Show(lastYearBooks);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Список книг (лише назви)");
            Console.ResetColor();
            Console.WriteLine();
            IEnumerable<string> onlyTitle = bookShop.Select(x => x.title).ToList();
            foreach (var item in onlyTitle)
            {
                Console.WriteLine(item);
            }
        }

        static void Show(IEnumerable<Book> books)
        {
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Book
    {
        public string title;
        public int year;
        public double price;
        public Book(string t, int y, double p)
        {
            title = t;
            year = y;
            price = p;
        }
        public override string ToString()
        {
            return title + "\t" + year + "\t" + price.ToString();
        }
    }
}
