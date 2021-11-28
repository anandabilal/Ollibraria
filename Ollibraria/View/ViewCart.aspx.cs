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
    public partial class ViewCart : System.Web.UI.Page
    {
        public List<Cart> cart = new List<Cart>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                String id = Request["ID"];
                cart = CartHandler.CreateListByUserId(id);
            }
        }

        protected string generateTransactionId()
        {
            String nextId = "";
            String lastId = HeaderTransactionHandler.FindLastHTId();

            if (lastId == null)
            {
                nextId = "TR001";
            }
            else
            {
                int id = Convert.ToInt32(lastId.Substring(2));
                id++;
                nextId = String.Format("TR{0:000}", id);
            }
            return nextId;
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            String userId = Request["ID"];
            var currentCart = CartHandler.FindByUserId(userId);

            lblError.Text = ControllerValidation.CheckCart(currentCart);
            if(lblError.Text.Equals(""))
            {
                String transactionId = generateTransactionId();
                String transactionDate = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");

                List<String> bookId = CartHandler.CreateBookListByUserId(userId);

                String[] arrBookId = bookId.ToArray();

                HeaderTransactionHandler.AddNewHT(transactionId, userId, transactionDate);
                
                for (int i = 0; i < arrBookId.Length; i++)
                {
                    String medId = arrBookId[i];
                    int qty = CartHandler.GetBookQuantity(userId, medId);

                    DetailTransactionHandler.AddNewDT(transactionId, medId, qty);

                }
                CartHandler.RemoveAllByUserId(userId);
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnViewBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBooks.aspx");
        }
    }
}