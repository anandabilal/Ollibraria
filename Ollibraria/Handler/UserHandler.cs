using Ollibraria.Model;
using Ollibraria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ollibraria.Handler
{
    public class UserHandler
    {
        public static User FindById(String id)
        {
            return UserRepository.FindById(id);
        }

        public static User FindByCookie(String cookie)
        {
            return UserRepository.FindByCookie(cookie);
        }

        public static String FindLastUserId()
        {
            return UserRepository.FindLastUserId();
        }

        public static User FindByUsername(String username)
        {
            return UserRepository.FindByUsername(username);
        }

        public static void AddNewUser(String id, String roleId, String username, String password, String name, String gender, String phoneNumber, String address)
        {
            UserRepository.AddNewUser(id, roleId, username, password, name, gender, phoneNumber, address);
        }

        public static List<User> CreateList()
        {
            return UserRepository.CreateList();
        }

        public static void DeleteUser(User user)
        {
            UserRepository.DeleteUser(user);
        }

        public static List<User> CreateListByUsername(String username)
        {
            return UserRepository.CreateListByUsername(username);
        }

        public static void updateUser(User user, String name, String gender, String phoneNumber, String address)
        {
            UserRepository.updateUser(user, name, gender, phoneNumber, address);
        }

        public static void updatePassword(User user, String password)
        {
            UserRepository.updatePassword(user, password);
        }

        public static User FindUserByUsernamePassword(String username, String password)
        {
            return UserRepository.FindUserByUsernamePassword(username, password);
        }
    }
}