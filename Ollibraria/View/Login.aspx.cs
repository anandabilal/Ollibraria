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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["user_cookie"] != null)
            {
                User user;
                var loginCredential = Request.Cookies["user_cookie"].Value;
                user = UserHandler.FindByCookie(loginCredential);

                txtUsername.Text = user.Username;
                txtPassword.Text = user.Password;
                txtPassword.Attributes["value"] = txtPassword.Text;
                checkRememberMe.Checked = true;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            String username = txtUsername.Text;
            String password = txtPassword.Text;
            bool rememberMe = checkRememberMe.Checked;

            lblError.Text = ControllerValidation.Login(username, password);
            if (lblError.Text.Equals(""))
            {
                var user = UserHandler.FindByUsername(username);
                Session["user"] = user;
                if (rememberMe)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = user.UserId;
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("Home.aspx");
            }
        }

        protected void btnRedirectToRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}