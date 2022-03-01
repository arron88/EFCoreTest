// See https://aka.ms/new-console-template for more information
namespace EFCoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyDbContext db = new MyDbContext())
            {
                /*
                Books books = new Books();
                books.Name = "程序员SQL经典";
                books.PubTime = DateTime.Now;
                books.AuthorName = "zy";
                Books books1 = new Books();
                books1.Name = "程序员SQL经典1";
                books1.PubTime = DateTime.Now;
                books1.AuthorName = "zy1";
                Books books2 = new Books();
                books2.Name = "程序员SQL经典2";
                books2.PubTime = DateTime.Now;
                books2.AuthorName = "zy2";
                Books books3 = new Books();
                books3.Name = "程序员SQL经典3";
                books3.PubTime = DateTime.Now;
                books3.AuthorName = "zy3";
                db.Books.Add(books);
                db.Books.Add(books1);s
                db.Books.Add(books2);
                db.Books.Add(books3);
                */
                /*Books books = new Books();
                books.Id = 2;
                db.Books.Remove(books);
                */
                
                var book = db.Books.Single(b=>b.Id==3);
                book.AuthorName = "arron";
                db.SaveChangesAsync();

                Console.WriteLine($"{book.Name} {book.AuthorName} {book.PubTime}");
                
            }
        }
    }
}