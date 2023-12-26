using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Rm_Assignment_3.Book;

namespace Rm_Assignment_3
{
    internal class Book
    {

        public int bookId;
        public string bookName;
        public string language;
        public int price;
        public string author;
        public string publisher;

    }

    class BookRepository
    {
        public Book[] bookobj = new Book[5];
        public int idx = 0;

        //Adding new Book details
        public void AddBook(Book book)
        {
            //add teacher details to array
            if (idx <= bookobj.Length)
            {
                bookobj[idx] = book;
                idx++;
            }
            else
            {
                Console.WriteLine("Book is Full!!!");
            }
        }


        //get book details with id
        public Book GetBook(int id)
        {
            foreach (Book book in bookobj)
            {
                if ((book != null))
                {
                    if (book.bookId == id)
                    {
                        return book;
                    }
                    //else
                    //    return null;

                }

            }
            return null; //when book not exist with given id
        }


        //Get Books by Name
        public Book[] GetBookByName(string bookNames)
        {
            Book[] bookNames_bookobj = new Book[bookobj.Length];
            int idx = 0;
            foreach (Book book in bookobj)
            {
                if (book != null)
                {
                    if (book.bookName == bookNames)
                    {
                        bookNames_bookobj[idx] = book;
                        idx++;
                    }
                }
            }
            return bookNames_bookobj;
        }










        //Get Books by Author
        public Book[] GetBookByAuthor(string authors)
        {
            Book[] authors_bookobj = new Book[bookobj.Length];
            int idx = 0;
            foreach (Book book in bookobj)
            {
                if (book != null)
                {
                    if (book.author == authors)
                    {
                        authors_bookobj[idx] = book;
                        idx++;
                    }
                }
            }
            return authors_bookobj;
        }

        //Get Books by publisher

        public Book[] GetBookByPublisher(string publishers)
        {
            Book[] publishers_bookobj = new Book[bookobj.Length];
            int idx = 0;
            foreach (Book book in bookobj)
            {
                if (book != null)
                {
                    if (book.publisher == publishers)
                    {
                        publishers_bookobj[idx] = book;
                        idx++;
                    }
                }
            }
            return publishers_bookobj;
        }


        //Get All Books
        public Book[] GetBooks()
        {
            return bookobj;
        }
    }

    class Book_Main
    {
        static void Main()
        {
            BookRepository bookRepository = new BookRepository();
            do
            {
                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Get Book By Name");
                Console.WriteLine("3.Get Book By Author");
                Console.WriteLine("4.Get Book By Publisher");
                Console.WriteLine("5.Get All Book");
                Console.WriteLine("Enter U r Choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1: //add new Book
                        {
                            Book book = new Book();
                            Console.WriteLine("Enter Book Name");
                            book.bookName = Console.ReadLine();
                            
                            Console.WriteLine("Enter Book Author");
                            book.author = Console.ReadLine();

                            Console.WriteLine("Enter Book Publisher");
                            book.publisher = Console.ReadLine();


                            book.bookId = new Random().Next(); //Random class return random value
                            bookRepository.AddBook(book);

                        }
                        break;
                    case 2: // Get Book By Name
                        {
                            Console.WriteLine("Enter Book Name");
                                string bookNames = Console.ReadLine();
                            Book[] bookobj = bookRepository.GetBookByAuthor(bookNames);
                            foreach (Book book in bookobj)
                            {
                                if (book != null)
                                {
                                    Console.WriteLine($"Id:{book.bookId} Name:{book.bookName} Author:{book.author} Publisher:{book.publisher}");
                                    Console.WriteLine("Classes handled");

                                }
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 3: //Get Books by Author
                        {
                            Console.WriteLine("Enter Author");
                            string authors = Console.ReadLine();
                            Book[] bookobj = bookRepository.GetBookByAuthor(authors);
                            foreach (Book book in bookobj)
                            {
                                if (book != null)
                                {
                                    Console.WriteLine($"Id:{book.bookId} Name:{book.bookName} Author:{book.author} Publisher:{book.publisher}");
                                    Console.WriteLine("Classes handled");

                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 4: //Get Book by Publisher
                        {
                            Console.WriteLine("Enter Publisher");
                            string publishers = Console.ReadLine();
                            Book[] bookobj = bookRepository.GetBookByPublisher(publishers);
                            foreach (Book book in bookobj)
                            {
                                if (book != null)
                                {
                                    Console.WriteLine($"Id:{book.bookId} Name:{book.bookName} Author:{book.author} Publisher:{book.publisher}");
                                    Console.WriteLine("Classes handled");

                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 5: //Get AllBooks
                        {
                            Book[] bookobj = bookRepository.GetBooks();
                            foreach (Book book in bookobj)
                            {
                                if (book != null)
                                {
                                    Console.WriteLine($"Id:{book.bookId} Name:{book.bookName} Author:{book.author} Publisher:{book.publisher}");
                                    Console.WriteLine("Classes handled");
                                    
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                }
            } while (true);
        }
    }

}


    









    