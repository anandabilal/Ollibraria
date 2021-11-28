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
    public partial class ViewBooks : System.Web.UI.Page
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
            btnInsert.Visible = false;
            gridBook.Columns[4].Visible = false;
            gridBook.Columns[5].Visible = false;
            List<Book> book = BookHandler.CreateList();

            gridBook.DataSource = book;
            gridBook.DataBind();

            User user = GetUserFromSession();

            if (user.RoleId.Equals("RO001"))
            {
                gridBook.Columns[5].Visible = true;
                btnInsert.Visible = true;
            }
            else
            {
                gridBook.Columns[4].Visible = true;
            }
        }

        protected void gridBook_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = gridBook.Rows[e.NewSelectedIndex];
            String selectedBook = row.Cells[0].Text.ToString();
            var searchBook = BookHandler.FindByName(selectedBook);

            Response.Redirect("AddToCart.aspx?ID="+searchBook.BookId);
        }

        protected void gridBook_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = gridBook.Rows[e.NewEditIndex];
            String selectedBook = row.Cells[0].Text.ToString();
            var searchBook = BookHandler.FindByName(selectedBook);

            Response.Redirect("UpdateBook.aspx?ID="+searchBook.BookId);
        }

        protected void gridBook_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gridBook.Rows[e.RowIndex];
            String selectedBook = row.Cells[0].Text.ToString();
            var deleteBook = BookHandler.FindByName(selectedBook);

            BookHandler.Remove(deleteBook);

            gridBook.DataSource = BookHandler.CreateList();
            gridBook.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertBook.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            gridBook.Columns[4].Visible = false;
            gridBook.Columns[5].Visible = false;
            String keyword = txtSearch.Text.ToString();
            List<Book> searchBook = BookHandler.CreateListByKeyword(keyword);

            gridBook.DataSource = searchBook;
            gridBook.DataBind();
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}