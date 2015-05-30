using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToys.Models;
using WingtipToys.Logic;

namespace WingtipToys.StandardUser
{
  public partial class StandardUserPanel : System.Web.UI.Page
  {

    protected void ViewButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("/StandardUser/SUViewPanel.aspx");
    }

    protected void CreateProjectButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("/StandardUser/SUCreateProjectPanel.aspx");

    }

    protected void MessageButton_Click(object sender, EventArgs e)
    {
    }
  }
}