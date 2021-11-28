using Ollibraria.Controller;
using Ollibraria.Factory;
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
    public partial class AddToCart : System.Web.UI.Page
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
            String id = Request["ID"];
            List<Book> book = BookHandler.CreateListById(id);

            gridBook.DataSource = book;
            gridBook.DataBind();
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            String bookId = Request["ID"];
            Book selectedBook = BookHandler.FindById(bookId);
            String quantity = txtQuantity.Text.ToString();

            lblError.Text = ControllerValidation.CheckQuantity(quantity, selectedBook.Stock.ToString());
            if(lblError.Text.Equals(""))
            {
                int qty = Convert.ToInt32(quantity);
                User currentUser = GetUserFromSession();
                Cart searchCart = CartHandler.FindByUserAndBookID(currentUser.UserId, selectedBook.BookId);

                if (searchCart != null)
                {
                    searchCart.Quantity += qty;
                    selectedBook.Stock -= qty;
                }
                else
                {
                    CartHandler.AddNewCart(currentUser.UserId, bookId, qty);
                    BookHandler.UpdateStock(selectedBook, qty);
                }
                Response.Redirect("ViewCart.aspx?ID="+currentUser.UserId);
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}