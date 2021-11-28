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
    public partial class ViewUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<User> user = UserHandler.CreateList();

            gridUser.DataSource = user;
            gridUser.DataBind();
        }

        protected void gridUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gridUser.Rows[e.RowIndex];
            String selectedUsername = row.Cells[0].Text.ToString();
            var deleteUser = UserHandler.FindByUsername(selectedUsername);

            UserHandler.DeleteUser(deleteUser);

            gridUser.DataSource = UserHandler.CreateList();
            gridUser.DataBind();
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}