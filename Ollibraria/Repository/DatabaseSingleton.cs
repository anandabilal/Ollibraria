using Ollibraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ollibraria.Repository
{
    public class DatabaseSingleton
    {
        private static OllibrariaDBEntities db = null;

        private DatabaseSingleton()
        {

        }

        public static OllibrariaDBEntities GetInstance()
        {
            if (db == null)
            {
                db = new OllibrariaDBEntities();
            }
            return db;
        }
    }
}