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
    public partial class Home : System.Web.UI.Page
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
            if(!IsPostBack)
            {
                btnViewCart.Visible = false;
                btnTransactionHistory.Visible = false;
                btnInsertBook.Visible = false;
                btnViewUsers.Visible = false;
                btnTransactionReport.Visible = false;

                if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    User user = GetUserFromSession();
                    User updatedUser = UserHandler.FindById(user.UserId);

                    if(user != updatedUser)
                    {
                        user = updatedUser;
                    }
                    lblWelcome.Text = "Welcome " + user.Name + "!".ToString();

                    if (user.RoleId.Equals("RO001"))
                    {
                        btnInsertBook.Visible = true;
                        btnViewUsers.Visible = true;
                        btnTransactionReport.Visible = true;
                    }
                    else
                    {
                        btnViewCart.Visible = true;
                        btnTransactionHistory.Visible = true;
                    }
                }
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            string[] cookies = Request.Cookies.AllKeys;
            foreach(string cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }
            Session.Remove("user");
            Response.Redirect("Login.aspx");
        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBooks.aspx");
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void btnViewCart_Click(object sender, EventArgs e)
        {
            User currentUser = GetUserFromSession();
            Response.Redirect("ViewCart.aspx?ID="+currentUser.UserId);
        }

        protected void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            User userId = GetUserFromSession();
            Response.Redirect("ViewTransactionHistory.aspx?ID=" + userId.UserId);
        }

        protected void btnInsertBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertBook.aspx");
        }

        protected void btnViewUsers_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUsers.aspx");
        }

        protected void btnTransactionReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransactionReport.aspx");
        }

    }
}