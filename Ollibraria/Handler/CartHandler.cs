using Ollibraria.Model;
using Ollibraria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ollibraria.Handler
{
    public class CartHandler
    {
        public static List<Cart> CreateListByUserId(String userId)
        {
            return CartRepository.CreateListByUserId(userId);
        }

        public static Cart FindByUserId(String userId)
        {
            return CartRepository.FindByUserId(userId);
        }

        public static List<String> CreateBookListByUserId(String userId)
        {
            return CartRepository.CreateBookListByUserId(userId);
        }

        public static int GetBookQuantity(String userId, String bookId)
        {
            return CartRepository.GetBookQuantity(userId, bookId);
        }

        public static void RemoveAllByUserId(String userId)
        {
            CartRepository.RemoveAllByUserId(userId);
        }

        public static Cart FindByUserAndBookID(String userId, String bookId)
        {
            return CartRepository.FindByUserAndBookID(userId, bookId);
        }

        public static void AddNewCart(String userId, String bookId, int quantity)
        {
            CartRepository.AddNewCart(userId, bookId, quantity);
        }
    }
}