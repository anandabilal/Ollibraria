using Ollibraria.Factory;
using Ollibraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ollibraria.Repository
{
    public class BookRepository
    {
        private static OllibrariaDBEntities db = DatabaseSingleton.GetInstance();

        public static List<Book> CreateList()
        {
            return db.Books.ToList();
        }

        public static Book FindByName(String name)
        {
            return (from Book
                    in db.Books
                    where Book.Name.Equals(name)
                    select Book).FirstOrDefault();
        }

        public static void Remove(Book book)
        {
            db.Books.Remove(book);
            db.SaveChanges();
        }

        public static List<Book> CreateListByKeyword(String keyword)
        {
            return (from Book
                    in db.Books
                    where Book.Name.Contains(keyword) || Book.Description.Contains(keyword)
                    select Book).ToList();
        }

        public static String FindLastBookId()
        {
            return (from Book
                    in db.Books
                    select Book.BookId).ToList().LastOrDefault();
        }

        public static void AddNewBook(String id, String name, String description, int stock, int price)
        {
            Book book = OllibrariaFactory.CreateBook(id, name, description, stock, price);
            db.Books.Add(book);
            db.SaveChanges();
        }

        public static Book FindById(String id)
        {
            return db.Books.Find(id);
        }

        public static void UpdateBook(Book book, String name, String description, int stock, int price)
        {
            book.Name = name;
            book.Description = description;
            book.Stock = stock;
            book.Price = price;
            db.SaveChanges();
        }

        public static List<Book> CreateListById(String id)
        {
            return (from Book
                    in db.Books
                    where Book.BookId.Equals(id)
                    select Book).ToList();
        }

        public static void UpdateStock(Book book, int quantity)
        {
            book.Stock -= quantity;
            db.SaveChanges();
        }

    }
}