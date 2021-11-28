using Ollibraria.Factory;
using Ollibraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ollibraria.Repository
{
    public class CartRepository
    {
        private static OllibrariaDBEntities db = DatabaseSingleton.GetInstance();

        public static List<Cart> CreateListByUserId(String userId)
        {
            return (from Cart
                    in db.Carts
                    where Cart.UserId.Equals(userId)
                    select Cart).ToList();
        }

        public static Cart FindByUserId(String userId)
        {
            return (from Cart
                    in db.Carts
                    where Cart.UserId.Equals(userId)
                    select Cart).FirstOrDefault();
        }

        public static List<String> CreateBookListByUserId(String userId)
        {
            return (from Cart
                    in db.Carts
                    where Cart.UserId.Equals(userId)
                    select Cart.BookId).ToList();
        }

        public static int GetBookQuantity(String userId, String bookId)
        {
            return Convert.ToInt32((from Cart
                                    in db.Carts
                                    where Cart.UserId.Equals(userId) && Cart.BookId.Equals(bookId)
                                    select Cart.Quantity).FirstOrDefault());
        }

        public static void RemoveAllByUserId(String userId)
        {
            var currentUserCarts = (from Cart
                                    in db.Carts
                                    where Cart.UserId.Equals(userId)
                                    select Cart);

            db.Carts.RemoveRange(currentUserCarts);
            db.SaveChanges();
        }
        
        public static Cart FindByUserAndBookID(String userId, String bookId)
        {
            return db.Carts.Find(userId, bookId);
        }

        public static void AddNewCart(String userId, String bookId, int quantity)
        {
            Cart newCart = OllibrariaFactory.CreateCart(userId, bookId, quantity);
            db.Carts.Add(newCart);
            db.SaveChanges();
        }
    }
}