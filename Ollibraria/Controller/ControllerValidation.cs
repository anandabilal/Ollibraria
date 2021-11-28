using Ollibraria.Handler;
using Ollibraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Ollibraria.Controller
{
    public class ControllerValidation
    {
        public static String CheckUsername(String username)
        {
            String error = "";
            if (username.Equals(""))
            {
                error = "Username cannot be empty!";
            }
            return error;
        }

        public static String CheckPassword(String password)
        {
            String error = "";
            if (password.Equals(""))
            {
                error = "Password cannot be empty!";
            }
            return error;
        }

        public static String Login(String username, String password)
        {
            String error = "";
            error = CheckUsername(username);
            if (!error.Equals("Username cannot be empty!"))
            {
                error = CheckPassword(password);
                if (!error.Equals("Password cannot be empty!"))
                {
                    var user = UserHandler.FindByUsername(username);
                    if (user != null)
                    {
                        if (UserHandler.FindUserByUsernamePassword(username, password) != null)
                        {
                            error = "";
                        }
                        else
                        {
                            error = "Password is incorrect!";
                        }
                    }
                    else
                    {
                        error = "Username doesn't exist!";
                    }
                }
            }
            return error;
        }

        public static String Register(String username, User user, String password, String confirmPassword, String name, bool genderChecked, String phoneNumber, String address)
        {
            String error = "";
            if (username == "")
            {
                error = CheckUsername(username);
            }
            else if (username.Length < 3)
            {
                error = "Username must contain more than 3 characters!";
            }
            else if (user != null && username == user.Username)
            {
                error = "Username already exist, please enter a different one!";
            }
            else if (password == "")
            {
                error = CheckPassword(password);
            }
            else if (password.Length < 8)
            {
                error = "Password must contain more than 8 characters!";
            }
            else if (confirmPassword == "")
            {
                error = "Confirm Password cannot be empty!";
            }
            else if (confirmPassword != password)
            {
                error = "Confirm Password must be the same as Password!";
            }
            else if (name == "")
            {
                error = "Name cannot be empty!";
            }
            else if (!genderChecked)
            {
                error = "Please choose your genders!";
            }
            else if (phoneNumber == "")
            {
                error = "Phone Number cannot be empty!";
            }
            //Check if phone number is numeric
            else if (!Regex.IsMatch(phoneNumber, @"^\d+$"))
            {
                error = "Phone Number must be numeric!";
            }
            else if (address == "")
            {
                error = "Address cannot be empty!";
            }
            else if (!address.Contains("Street"))
            {
                //Case sensitive
                error = "Address must contain the word 'Street' in it!";
            }
            return error;
        }

        public static String CheckBook(String name, String description, String stock, String price, String mode)
        {
            String error = "";
            if (name == "")
            {
                error = "Name cannot be empty!";
            }
            //Not required, but just in case, to prevent same Book.Name error
            else if (mode.Equals("insert") && BookHandler.FindByName(name) != null)
            {
                error = "Name already exist!";
            }
            else if (description == "")
            {
                error = "Description cannot be empty!";
            }
            else if (description.Length <= 10)
            {
                error = "Description must contain more than 10 characters!";
            }
            else if (stock == "")
            {
                error = "Stock cannot be empty!";
            }
            else if (!Regex.IsMatch(stock, @"^\d+$"))
            {
                error = "Stock must be numeric!";
            }
            else if (Convert.ToInt32(stock) <= 0)
            {
                error = "Stock must be more than 0!";
            }
            else if (price == "")
            {
                error = "Price cannot be empty!";
            }
            else if (!Regex.IsMatch(price, @"^\d+$"))
            {
                error = "Price must be numeric!";
            }
            else if (Convert.ToInt32(price) <= 0)
            {
                error = "Price must be more than 0!";
            }
            return error;
        }

        public static String UpdateProfile(String name, bool genderChecked, String phoneNumber, String address)
        {
            String error = "";
            if (name == "")
            {
                error = "Name cannot be empty!";
            }
            else if (!genderChecked)
            {
                error = "Please choose your genders!";
            }
            else if (phoneNumber == "")
            {
                error = "Phone Number cannot be empty!";
            }
            //Check if phone number is numeric
            else if (!Regex.IsMatch(phoneNumber, @"^\d+$"))
            {
                error = "Phone Number must be numeric!";
            }
            else if (address == "")
            {
                error = "Address cannot be empty!";
            }
            else if (!address.Contains("Street"))
            {
                //Case sensitive
                error = "Address must contain the word 'Street' in it!";
            }
            return error;
        }

        public static String UpdatePassword(User user, String oldPassword, String newPassword, String confirmPassword)
        {
            String error = "";
            if (oldPassword == "")
            {
                error = "Old password cannot be empty!";
            }
            else if (oldPassword != user.Password)
            {
                error = "Please enter your old password correctly!";
            }
            else if (newPassword == "")
            {
                error = "New password cannot be empty!";
            }
            else if (newPassword.Length <= 5)
            {
                error = "Your new password must contain more than 5 characters!";
            }
            else if (confirmPassword == "")
            {
                error = "Confirm Password cannot be empty!";
            }
            else if (confirmPassword != newPassword)
            {
                error = "Confirm Password must be the same as Password!";
            }
            return error;
        }

        public static String CheckCart(Cart cart)
        {
            String error = "";
            if (cart == null)
            {
                error = "You can't checkout if you don't have any items in the cart!";
            }
            return error;
        }

        public static String CheckQuantity(String quantity, String bookStock)
        {
            String error = "";
            if (quantity == "")
            {
                error = "Quantity cannot be empty!";
            }
            else if (!Regex.IsMatch(quantity, @"^\d+$"))
            {
                error = "Quantity must be numeric!";
            }
            else if (Convert.ToInt32(quantity) <= 0)
            {
                error = "Quantity must be more than 0!";
            }
            else if (Convert.ToInt32(quantity) > Convert.ToInt32(bookStock))
            {
                error = "Quantity must be less than or equal to the current stock!";
            }
            return error;
        }
    }
}