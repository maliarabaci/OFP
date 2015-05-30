using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToys.Models;

namespace WingtipToys
{
  public partial class _Default : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void Page_Error(object sender, EventArgs e)
    {
      // Get last error from the server.
      Exception exc = Server.GetLastError();

      // Handle specific exception.
      if (exc is InvalidOperationException)
      {
        // Pass the error on to the error page.
        Server.Transfer("ErrorPage.aspx?handler=Page_Error%20-%20Default.aspx",
            true);
      }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            int? CFProjectID = 1;
            string ProjectName = "qwerty";
            var _db = new WingtipToys.Models.CrowdfundingProjectContext();
            IQueryable<CrowdfundingProject> query = _db.CrowdfundingProject;

            if (CFProjectID.HasValue && CFProjectID > 0)
            {
                query = query.Where(p => p.CFProjectID == CFProjectID);
            }
            else if (!String.IsNullOrEmpty(ProjectName))
            {
                query = query.Where(p =>
                          String.Compare(p.ProjectName, ProjectName) == 0);
            }
            else
            {
                query = null;
            }
        }
        catch (Exception ex) { }
    }
  }
}