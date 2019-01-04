using DorfladenBBZW.Models;
using DorfladenBBZW.Persistency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DorfladenBBZW
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        public Product prod { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;

            if (!string.IsNullOrEmpty(Request.QueryString["pId"]))
            {
                GetProduct(Request.QueryString["pId"]);

            }
        }

        public void GetProduct(string id)
        {
            var p = new ProductsPersistency();
            prod = p.GetById(id);
        }
    }
}