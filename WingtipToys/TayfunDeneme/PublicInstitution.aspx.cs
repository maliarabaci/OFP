using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WingtipToys.TayfunDeneme
{
    public partial class PublicInstitution : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Customer> list = new List<Customer>();
            Customer p1 = new Customer();
            p1.ContactName = "Tayfun";
            p1.Country = "Ali";
            p1.CustomerId = "1";
            p1.City = "Turkey";

            Customer p2 = new Customer();
            p2.ContactName = "Tayfun";
            p2.Country = "Ali";
            p2.CustomerId = "1";
            p2.City = "Turkey";

            list.Add(p1);
            list.Add(p2);

            this.gvCustomers.DataSource = list;
            this.gvCustomers.DataBind();
          

        }

        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {

        }
    }
}