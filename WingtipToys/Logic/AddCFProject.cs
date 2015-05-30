using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WingtipToys.Models;

namespace WingtipToys.Logic
{
    public class AddCrowdfundingProject
    {
        public bool AddCrowdfundingProjects(string ProjectName, string ProjectDesc, string DonationAmount, string Deadline)
        {
            var myProject = new CrowdfundingProject();
            myProject.ProjectName = ProjectName;
            myProject.Description = ProjectDesc;
            myProject.Donation = Convert.ToDouble(DonationAmount);
            myProject.Deadline = Deadline;

            using (CrowdfundingProjectContext _db = new CrowdfundingProjectContext())
            {
                // Add product to Database
                _db.CrowdfundingProject.Add(myProject);
                _db.SaveChanges();
            }

            // Success.
            return true;
        }
    }
}