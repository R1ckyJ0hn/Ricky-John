using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;

namespace DAy_24_Task
{
    class Program
    {
        public static void Main()
        {
            IList < Book > Bookdata = new List<Book>()
            {
                new Book() { BookID= 101, Author="J.K Rowling", BookName="Harry Potter" ,price=325 } ,
                new Book() { BookID =102 , Author = "Agatha Christie", BookName = "Murder on the orient express", price = 250 },
                new Book() { BookID =103 , Author = "Paulo Coehlo", BookName = "The Alchemist", price =130 },
                new Book() { BookID = 104, Author = "Dan Brown", BookName = "Da vinci Code", price = 180},
                new Book() { BookID = 105, Author = "Charles Dickens", BookName = "Oliver Twist", price = 245 }
            };
            Console.WriteLine("Book Info :\n");
            var allqry = from boo in Bookdata
                         select boo;
            foreach (var all in allqry)
                Console.WriteLine("Book."+all.BookID+"-"+all.BookName+" written by "+all.Author+" - Rs."+all.price);
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("For a Particular Author ");
            var autqry = from boo in Bookdata
                         where boo.Author.Contains("Agatha Christie")
                         select boo;
            foreach (var Authname in autqry)
                   Console.WriteLine(Authname.BookName);

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("\nLowest To highest in price :\n");
            var Priqry = from boo in Bookdata
                         orderby boo.price
                         select boo;
            foreach (var pri in Priqry)
                Console.WriteLine(pri.price +" " + pri.BookName +" Written by " +pri.Author);
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("\n Author name in order:\n");
            var authqry = from boo in Bookdata
                         orderby boo.Author
                         select boo;
            foreach (var auth in authqry)
                Console.WriteLine(auth.Author + " Wrote " +auth.BookName);

        }
        class Book
        {

            public int BookID { get; set; }
            public string BookName { get; set; }
            public string Author { get; set; }
            public int price { get; set; }
        }
    }
}
