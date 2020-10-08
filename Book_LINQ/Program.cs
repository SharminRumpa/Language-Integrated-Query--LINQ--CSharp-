using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
                new Book { BookID = 1, BookTitle = "The Bluest Eye" , ISBN = "O-671-854216" , NoOfPage = 230 , AuthorID = 5, PublisherID = 7},
                new Book { BookID = 2, BookTitle = "Major Barbara" , ISBN = "1-875-2545-5" , NoOfPage = 200 , AuthorID = 13, PublisherID = 1},
                new Book { BookID = 3, BookTitle = "'Mrityukshuda" , ISBN = "O-688-1433-4" , NoOfPage = 150 , AuthorID = 15, PublisherID = 2},
                new Book { BookID = 4, BookTitle = "She Stoop" ,    ISBN = "O-525-67520-5" , NoOfPage = 290 , AuthorID = 16, PublisherID = 3},
                new Book { BookID = 5, BookTitle = "Color Farm" ,   ISBN = "O-14-0505867" , NoOfPage = 150 , AuthorID = 14, PublisherID = 4},
                new Book { BookID = 6, BookTitle = "Cast Account",  ISBN = "Q-15-S788" ,    NoOfPage = 300 , AuthorID = 15, PublisherID = 2},
                new Book { BookID = 7, BookTitle = "Agni Bani" ,    ISBN = "O-14-0125867" , NoOfPage = 230 , AuthorID = 1, PublisherID = 5},
                new Book { BookID = 8, BookTitle = "Ratri Shesh" ,    ISBN = "O-14-11205867" , NoOfPage = 120 , AuthorID = 8, PublisherID = 6},
                new Book { BookID = 9, BookTitle = "What Management Is" , ISBN = "F-2154-2215" , NoOfPage = 250 , AuthorID = 7, PublisherID = 8},
                new Book { BookID = 10, BookTitle = "Theretical concept in physics" , ISBN = "1255-36598-89" , NoOfPage = 410 , AuthorID = 3, PublisherID = 9},
                new Book { BookID = 11, BookTitle = "Permutation city" ,  ISBN = "58-25256-85" , NoOfPage = 400 , AuthorID = 1, PublisherID = 10},
                new Book { BookID = 12, BookTitle = "General Chemistry" , ISBN = "123-35353-62" , NoOfPage = 280 , AuthorID = 2, PublisherID = 8},
                new Book { BookID = 13, BookTitle = "Financial Management" , ISBN = "O-12535-55" , NoOfPage = 250 , AuthorID = 3, PublisherID = 6},
                new Book { BookID = 14, BookTitle = "Epic Content Marketing" , ISBN = "E-1269877" , NoOfPage = 220 , AuthorID = 5, PublisherID = 7},
                new Book { BookID = 15, BookTitle = "Basic Principal of Marketing" , ISBN = "B-3695478" , NoOfPage = 120 , AuthorID = 2, PublisherID = 9},
                new Book { BookID = 16, BookTitle = "Introduction to Islam and Islamic Dawah" , ISBN = "I-1568795" , NoOfPage = 310 , AuthorID = 9, PublisherID = 5},
                new Book { BookID = 17, BookTitle = "The Basis of Public Budgeting and Financial Management" , ISBN = "F-98756412" , NoOfPage = 320 , AuthorID = 8, PublisherID = 3},
                new Book { BookID = 18, BookTitle = "Noukadubi" , ISBN = "122365448" , NoOfPage = 300 , AuthorID = 3, PublisherID = 5},
                new Book { BookID = 19, BookTitle = "Hello! Good-bye" , ISBN = "X-3548-9654" , NoOfPage = 150 , AuthorID = 10, PublisherID = 11},
                new Book { BookID = 20, BookTitle = "General Chemistry" , ISBN = "123-35353-62" , NoOfPage = 250 , AuthorID = 11, PublisherID = 6},
                new Book { BookID = 21, BookTitle = "General Chemistry" , ISBN = "123-35353-62" , NoOfPage = 230 , AuthorID = 17, PublisherID = 12},
                new Book { BookID = 22, BookTitle = "General Chemistry" , ISBN = "123-35353-62" , NoOfPage = 290 , AuthorID = 1, PublisherID = 5},
                new Book { BookID = 23, BookTitle = "General Chemistry" , ISBN = "123-35353-62" , NoOfPage = 200 , AuthorID = 16, PublisherID = 10},


            };

        

            Author[] authors = new Author[]
            {
                new Author { AuthorID = 1, AuthorName = "G.B.Shaw"},
                new Author { AuthorID = 2, AuthorName = "William Shakespere"},
                new Author { AuthorID = 3, AuthorName = "Rabindranath Tagor"},
                new Author { AuthorID = 4, AuthorName = "F W Taylor"},
                new Author { AuthorID = 5, AuthorName = "Toni Morrison"},
                new Author { AuthorID = 6, AuthorName = "Aliki Greenwillow"},
                new Author { AuthorID = 7, AuthorName = "Kazi Nazrul Islam"},
                new Author { AuthorID = 8, AuthorName = "Ahsan Habib"},
                new Author { AuthorID = 9, AuthorName = "Enlert"},
                new Author { AuthorID = 10, AuthorName = "Arnosky"},
                new Author { AuthorID = 11, AuthorName = "Grey Egan"},
                new Author { AuthorID = 12, AuthorName = "Charles E. Menifield"},
                new Author { AuthorID = 13, AuthorName = "Richard Templar"},
                new Author { AuthorID = 14, AuthorName = "Jerry J. Keygandt"},
                new Author { AuthorID = 15, AuthorName = "Robert S. Witte & John E. Wittte"},
            };

									
            Publisher[] publishers = new Publisher[]
            {
                new Publisher { PublisherID = 1, PublisherName = "Somoy Prokashon"},
                new Publisher { PublisherID = 2, PublisherName = "Agamee Prakshani"},
                new Publisher { PublisherID = 3, PublisherName = "Lyall Publication"},
                new Publisher { PublisherID = 4, PublisherName = "Anyaprokash"},
                new Publisher { PublisherID = 5, PublisherName = "Kakoli Prokashoni"},
                new Publisher { PublisherID = 6, PublisherName = "Clarlon Books"},
                new Publisher { PublisherID = 7, PublisherName = "Lippincott"},
                new Publisher { PublisherID = 8, PublisherName = "Oboshor"},
                new Publisher { PublisherID = 9, PublisherName = "Anupam Prokashoni"},
                new Publisher { PublisherID = 10, PublisherName = "Shuchipotro"},


            };

           

            var result = from bBook in books
                         join aAuthor in authors
                         on bBook.AuthorID equals aAuthor.AuthorID
                         join pPublisher in publishers
                         on bBook.PublisherID equals pPublisher.PublisherID 

                         select new
                         {
                             BookID = bBook.BookID,
                             BookTitle = bBook.BookTitle,
                             AuthorName = aAuthor.AuthorName,
                             ISBN = bBook.ISBN,
                             NoOfPage = bBook.NoOfPage,
                             PublishersName = pPublisher.PublisherName
                         };
                     
            foreach (var b in result)
            {
                Console.WriteLine(b.ToString().Replace("{ ", "").Replace(" }", ""));
            }

            Console.ReadLine();
        }   


    }
}
