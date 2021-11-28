using Ollibraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ollibraria.Factory
{
    public class OllibrariaFactory
    {
        public static User CreateUser(String id, String roleId, String username, String password, String name, String gender, String phoneNumber, String address)
        {
            User user = new User()
            {
                UserId = id,
                RoleId = roleId,
                Username = username,
                Password = password,
                Name = name,
                Gender = gender,
                PhoneNumber = phoneNumber,
                Address = address
            };
            return user;
        }

        public static Book CreateBook(String id, String name, String description, int stock, int price)
        {
            Book book = new Book()
            {
                BookId = id,
                Name = name,
                Description = description,
                Stock = stock,
                Price = price
            };
            return book;
        }

        public static Cart CreateCart(String userId, String bookId, int quantity)
        {
            Cart cart = new Cart()
            {
                UserId = userId,
                BookId = bookId,
                Quantity = quantity
            };
            return cart;
        }

        public static HeaderTransaction CreateHT(String id, String userId, String date)
        {
            HeaderTransaction ht = new HeaderTransaction()
            {
                TransactionId = id,
                UserId = userId,
                TransactionDate = date
            };
            return ht;
        }

        public static DetailTransaction CreateDT(String transactionId, String bookId, int quantity)
        {
            DetailTransaction dt = new DetailTransaction()
            {
                TransactionId = transactionId,
                BookId = bookId,
                Quantity = quantity
            };
            return dt;
        }
    }
}