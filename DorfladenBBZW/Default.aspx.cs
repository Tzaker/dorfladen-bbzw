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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IEnumerable<Product> AllProducts = GetProducts();


                
        }

        public IEnumerable<Product> GetProducts()
        {
            var allproducts = new ProductsPersistency();
            return allproducts.GetAll();
        }
    }
}