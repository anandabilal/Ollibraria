using Ollibraria.Controller;
using Ollibraria.Handler;
using Ollibraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ollibraria.View
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        User GetUserFromSession()
        {
            User findUser;
            if (Session["user"] == null)
            {
                var id = Request.Cookies["user_cookie"].Value;
                findUser = UserHandler.FindById(id);

                Session["user"] = findUser;
            }
            else
            {
                findUser = (User)Session["user"];
            }
            return findUser;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Text = "";

            String oldPassword = txtOldPassword.Text.ToString();
            String newPassword = txtNewPassword.Text.ToString();
            String confirmPassword = txtConfirmPassword.Text.ToString();

            User user = GetUserFromSession();
            User updatedUser = UserHandler.FindById(user.UserId);

            if (user != updatedUser)
            {
                user = updatedUser;
            }

            lblError.Text = ControllerValidation.UpdatePassword(user, oldPassword, newPassword, confirmPassword);
            if (lblError.Text.Equals(""))
            {
                User changePassword = UserHandler.FindById(user.UserId);
                UserHandler.updatePassword(changePassword, newPassword);

                lblError.ForeColor = System.Drawing.Color.Green;
                lblError.Text = "Password changed successfully!";
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}