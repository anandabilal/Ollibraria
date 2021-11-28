using Ollibraria.Model;
using Ollibraria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ollibraria.Handler
{
    public class DetailTransactionHandler
    {
        public static List<DetailTransaction> CreateList()
        {
            return DetailTransactionRepository.CreateList();
        }

        public static void AddNewDT(String transactionId, String bookId, int quantity)
        {
            DetailTransactionRepository.AddNewDT(transactionId, bookId, quantity);
        }

        public static List<DetailTransaction> CreateListByUserId(String userId)
        {
            return DetailTransactionRepository.CreateListByUserId(userId);
        }
    }
}