using Ollibraria.Model;
using Ollibraria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ollibraria.Handler
{
    public class HeaderTransactionHandler
    {
        public static void AddNewHT(String transactionId, String userId, String transactionDate)
        {
            HeaderTransactionRepository.AddNewHT(transactionId, userId, transactionDate);
        }

        public static void DeleteAllHTByUser(User user)
        {
            HeaderTransactionRepository.DeleteAllHTByUser(user);
        }

        public static String FindLastHTId()
        {
            return HeaderTransactionRepository.FindLastHTId();
        }
    }
}