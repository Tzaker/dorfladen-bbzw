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
    public partial class Details : System.Web.UI.Page
    {
        public Product prod { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;

            if (!string.IsNullOrEmpty(Request.QueryString["prodId"]))
            {
                var p = new ProductsPersistency();
                prod = p.GetById(Request.QueryString["prodId"]);

            }

            DetailPicture.ImageUrl = "assets/img/" + prod.ImageName;

        }

        protected void AddToBasket_Click(object sender, EventArgs e)
        {

        }
    }
}