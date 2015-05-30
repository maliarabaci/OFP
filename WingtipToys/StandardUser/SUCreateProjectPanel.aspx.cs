using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WingtipToys.StandardUser
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            AddCrowdfundingProject addProject = new AddCrowdfundingProject();
            addProject.AddCrowdfundingProjects(this.TextBox1.Text, this.TextBox2.Text, this.TextBox3.Text, this.TextBox4.Text);

        }
    }
}