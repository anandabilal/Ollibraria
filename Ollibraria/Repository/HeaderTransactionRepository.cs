using Ollibraria.Factory;
using Ollibraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ollibraria.Repository
{
    public class HeaderTransactionRepository
    {
        private static OllibrariaDBEntities db = DatabaseSingleton.GetInstance();

        public static void AddNewHT(String transactionId, String userId, String transactionDate)
        {
            HeaderTransaction ht = OllibrariaFactory.CreateHT(transactionId, userId, transactionDate);
            db.HeaderTransactions.Add(ht);
            db.SaveChanges();
        }

        public static void DeleteAllHTByUser(User user)
        {
            var ht = (from HeaderTransaction
                      in db.HeaderTransactions
                      where HeaderTransaction.UserId.Equals(user.UserId)
                      select HeaderTransaction);

            db.HeaderTransactions.RemoveRange(ht);
            db.SaveChanges();
        }

        public static String FindLastHTId()
        {
            return (from HeaderTransaction
                    in db.HeaderTransactions
                    select HeaderTransaction.TransactionId).ToList().LastOrDefault();
        }
    }
}