using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using Ollibraria.Model;
using Ollibraria.Factory;
using Ollibraria.Handler;
using Ollibraria.Controller;

namespace Ollibraria.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string generateUserId()
        {
            String nextId = "";
            String lastId = UserHandler.FindLastUserId();

            if (lastId == null)
            {
                nextId = "US001";
            }
            else
            {
                int id = Convert.ToInt32(lastId.Substring(2));
                id++;
                nextId = String.Format("US{0:000}", id);
            }
            return nextId;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            String newUserId = generateUserId();
            String newRoleId = "RO002";
            String newUsername = txtUsername.Text.ToString();
            var findUser = UserHandler.FindByUsername(newUsername);
            String newPassword = txtPassword.Text.ToString();
            String confirmPassword = txtConfirmPassword.Text.ToString();
            String newName = txtName.Text.ToString();
            String newGender = "";
            bool genderChecked = true;
            if (radioMale.Checked)
            {
                newGender = "Male";
            }
            else if (radioFemale.Checked)
            {
                newGender = "Female";
            }
            else
            {
                genderChecked = false;
            }
            String newPhone = txtPhone.Text.ToString();
            String newAddress = txtAddress.Text.ToString();

            lblError.Text = ControllerValidation.Register(newUsername, findUser, newPassword, confirmPassword, newName, genderChecked, newPhone, newAddress);
            if(lblError.Text.Equals(""))
            {
                UserHandler.AddNewUser(newUserId, newRoleId, newUsername, newPassword, newName, newGender, newPhone, newAddress);
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnRedirectToLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}