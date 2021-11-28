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
    public partial class Profile : System.Web.UI.Page
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
                User currentUser = GetUserFromSession();
                List<User> user = UserHandler.CreateListByUsername(currentUser.Username);

                gridProfile.DataSource = user;
                gridProfile.DataBind();
            }
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}