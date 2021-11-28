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
    public partial class UpdateBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                String id = Request["ID"];
                Book updateBook = BookHandler.FindById(id);

                txtName.Text = updateBook.Name.ToString();
                txtDescription.Text = updateBook.Description.ToString();
                txtStock.Text = updateBook.Stock.ToString();
                txtPrice.Text = updateBook.Price.ToString();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            String updateId = Request["ID"];
            String updateName = txtName.Text.ToString();
            String updateDescription = txtDescription.Text.ToString();
            String updateStock = txtStock.Text.ToString();
            String updatePrice = txtPrice.Text.ToString();

            lblError.Text = ControllerValidation.CheckBook(updateName, updateDescription, updateStock, updatePrice, "update");
            if(lblError.Text.Equals(""))
            {
                Book updateBook = BookHandler.FindById(updateId);
                BookHandler.UpdateBook(updateBook, updateName, updateDescription, Convert.ToInt32(updateStock), Convert.ToInt32(updatePrice));

                Response.Redirect("ViewBooks.aspx");
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}