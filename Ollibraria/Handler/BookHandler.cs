using Ollibraria.Model;
using Ollibraria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ollibraria.Handler
{
    public class BookHandler
    {
        public static List<Book> CreateList()
        {
            return BookRepository.CreateList();
        }

        public static Book FindByName(String name)
        {
            return BookRepository.FindByName(name);
        }

        public static void Remove(Book book)
        {
            BookRepository.Remove(book);
        }

        public static List<Book> CreateListByKeyword(String keyword)
        {
            return BookRepository.CreateListByKeyword(keyword);
        }

        public static String FindLastBookId()
        {
            return BookRepository.FindLastBookId();
        }

        public static void AddNewBook(String id, String name, String description, int stock, int price)
        {
            BookRepository.AddNewBook(id, name, description, stock, price);
        }

        public static Book FindById(String id)
        {
            return BookRepository.FindById(id);
        }

        public static void UpdateBook(Book book, String name, String description, int stock, int price)
        {
            BookRepository.UpdateBook(book, name, description, stock, price);
        }

        public static List<Book> CreateListById(String id)
        {
            return BookRepository.CreateListById(id);
        }

        public static void UpdateStock(Book book, int quantity)
        {
            BookRepository.UpdateStock(book, quantity);
        }

    }
}