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
    public partial class InsertBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string generateBookId()
        {
            String nextId = "";
            String lastId = BookHandler.FindLastBookId();

            if(lastId == null)
            {
                nextId = "BO001";
            }
            else
            {
                int id = Convert.ToInt32(lastId.Substring(2));
                id++;
                nextId = String.Format("BO{0:000}", id);
            }
            return nextId;
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Text = "";

            String newBookId = generateBookId();
            String newName = txtName.Text.ToString();
            String newDescription = txtDescription.Text.ToString();
            String newStock = txtStock.Text.ToString();
            String newPrice = txtPrice.Text.ToString();

            lblError.Text = ControllerValidation.CheckBook(newName, newDescription, newStock, newPrice, "insert");
            if (lblError.Text.Equals(""))
            {
                BookHandler.AddNewBook(newBookId, newName, newDescription, Convert.ToInt32(newStock), Convert.ToInt32(newPrice));

                lblError.ForeColor = System.Drawing.Color.Green;
                lblError.Text = "Book inserted successfully!";
                txtName.Text = "";
                txtDescription.Text = "";
                txtStock.Text = "";
                txtPrice.Text = "";
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}