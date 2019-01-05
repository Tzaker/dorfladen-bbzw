using DorfladenBBZW.Formatters;
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
    public partial class Basket : System.Web.UI.Page
    {
        public double Total { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var allp = new ProductsPersistency();
            IEnumerable<Product> AllProducts = allp.GetAll();

            BasketTable.CssClass = "table-basket";

            TableRow r = new TableRow();
            r.CssClass = "titlerow-basket";

            TableCell tc1 = new TableCell();
            tc1.Text = "Produkt";
            r.Cells.Add(tc1);

            TableCell tc2 = new TableCell();
            tc2.Text = "Preis";
            r.Cells.Add(tc2);

            BasketTable.Rows.Add(r);

            foreach (string pid in this.Session)
            {

                foreach(Product p in AllProducts)
                {
                    if(p.Id == this.Session[pid].ToString())
                    {
                        TableRow row = new TableRow();

                        TableCell c1 = new TableCell();
                        c1.Text = p.Name;
                        row.Cells.Add(c1);

                        TableCell c2 = new TableCell();
                        c2.Text = DecimalExtensionMethods.AsChf(p.SpecialOffer);
                        row.Cells.Add(c2);

                        BasketTable.Rows.Add(row);

                        Total += (double)p.SpecialOffer;
                    }
                }
                
            }

            TotalPrice.Text = "Total: " + Total.ToString() + " CHF";
        }
    }
}