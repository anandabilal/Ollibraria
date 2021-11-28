using Ollibraria.Factory;
using Ollibraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ollibraria.Repository
{
    public class DetailTransactionRepository
    {
        private static OllibrariaDBEntities db = DatabaseSingleton.GetInstance();

        public static List<DetailTransaction> CreateList()
        {
            return db.DetailTransactions.ToList();
        }

        public static void AddNewDT(String transactionId, String bookId, int quantity)
        {
            DetailTransaction dt = OllibrariaFactory.CreateDT(transactionId, bookId, quantity);
            db.DetailTransactions.Add(dt);
            db.SaveChanges();
        }

        public static List<DetailTransaction> CreateListByUserId(String userId)
        {
            return (from DetailTransaction
                    in db.DetailTransactions
                    where DetailTransaction.HeaderTransaction.UserId.Equals(userId)
                    select DetailTransaction).ToList();
        }
    }
}