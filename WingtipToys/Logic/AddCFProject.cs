using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WingtipToys.Logic
{
    public class AddCrowdfundingProject
    {
        public bool AddCrowdfundingProject(string ProjectName, string ProjectDesc, string DonationAmount, string Deadline)
        {
            var myProject = new CrowdfundingProject();
            myProject.ProjectName = ProjectName;
            myProject.Description = ProjectDesc;
            myProject.Donation = Convert.ToDouble(DonationAmount);
            myProject.Deadline = Deadline;

            using (CrowdfundingProjectContext _db = new CrowdfundingProjectContext())
            {
                // Add product to DB.
                _db.Products.Add(myProject);
                _db.SaveChanges();
            }
            // Success.
            return true;
        }
    }
}