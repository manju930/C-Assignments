using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
    {
        enum BookType : byte
        {
            Magazine = 20,
            Novel = 2,
            ReferenceBook = 60,
            Miscellaneous = 4
        }

        struct BOOK
        {
            public int BookID;
            public string title;
            public short Price;
            public BookType heading;


            public BOOK(int i, string n, short p, BookType et)
            {
                BookID = i;
                title = n;
                Price = p;
                heading = et;

            }
        }

        class MainClass
        {
            public static void Main(string[] args)
            {
                BOOK bk;
                bk.BookID = 20;
                bk.title = "Jhon";
                bk.Price = 250;
                bk.heading = BookType.Novel;

                BOOK Larry = new BOOK(50, "Larry", 1450, BookType.Magazine);

                Console.WriteLine("BookID is {0} ", Larry.BookID);
                Console.WriteLine("Title is {0}", Larry.title);
                Console.WriteLine("Price is {0}", Larry.Price);
                Console.WriteLine("Tyoe of the book is {0}", Larry.heading);

                Console.WriteLine("\n");

                Console.WriteLine("BookID is {0}", bk.BookID);
                Console.WriteLine("Title is {0}", bk.title);
                Console.WriteLine("Price is {0}", bk.Price);
                Console.WriteLine("Tyoe of the book is {0}", bk.heading);


            }
        }
    }

