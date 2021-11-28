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
    public partial class ViewTransactionReport : System.Web.UI.Page
    {
        public List<DetailTransaction> dt = new List<DetailTransaction>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dt = DetailTransactionHandler.CreateList();
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}