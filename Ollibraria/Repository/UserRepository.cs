using Ollibraria.Factory;
using Ollibraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ollibraria.Repository
{
    public class UserRepository
    {
        private static OllibrariaDBEntities db = DatabaseSingleton.GetInstance();

        public static User FindById(String id)
        {
            return db.Users.Find(id);
        }

        public static User FindByCookie(String cookie)
        {
            return (from User
                    in db.Users
                    where User.UserId.Equals(cookie)
                    select User).FirstOrDefault();
        }

        public static String FindLastUserId()
        {
            return (from User
                    in db.Users
                    select User.UserId).ToList().LastOrDefault();
        }

        public static User FindByUsername(String username)
        {
            return (from User
                    in db.Users
                    where User.Username.Equals(username)
                    select User).FirstOrDefault();
        }

        public static void AddNewUser(String id, String roleId, String username, String password, String name, String gender, String phoneNumber, String address)
        {
            User user = OllibrariaFactory.CreateUser(id, roleId, username, password, name, gender, phoneNumber, address);
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static List<User> CreateList()
        {
            return db.Users.ToList();
        }

        public static void DeleteUser(User user)
        {
            HeaderTransactionRepository.DeleteAllHTByUser(user);
            db.Users.Remove(user);
            db.SaveChanges();
        }

        public static List<User> CreateListByUsername(String username)
        {
            return (from User
                    in db.Users
                    where User.Username.Equals(username)
                    select User).ToList();
        }

        public static void updateUser(User user, String name, String gender, String phoneNumber, String address)
        {
            user.Name = name;
            user.Gender = gender;
            user.PhoneNumber = phoneNumber;
            user.Address = address;
            db.SaveChanges();
        }

        public static void updatePassword(User user, String password)
        {
            user.Password = password;
            db.SaveChanges();
        }

        public static User FindUserByUsernamePassword(String username, String password)
        {
            return (from User
                    in db.Users
                    where User.Username.Equals(username) && User.Password.Equals(password)
                    select User).FirstOrDefault();
        }
    }
}