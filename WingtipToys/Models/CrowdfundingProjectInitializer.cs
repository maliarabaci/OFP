using System.Collections.Generic;
using System.Data.Entity;

namespace WingtipToys.Models
{
    public class CrowdfundingProjectDatabaseInitializer : DropCreateDatabaseIfModelChanges<CrowdfundingProjectContext>
  {
      protected override void Seed(CrowdfundingProjectContext context)
    {

        GetCrowdfundingProject().ForEach(p => context.CrowdfundingProject.Add(p));
    }



    private static List<CrowdfundingProject> GetCrowdfundingProject()
    {
        var CrowdfundingProject = new List<CrowdfundingProject> {
                new CrowdfundingProject
                {
                    CFProjectID = 1,
                    ProjectName = "asdasd",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + 
                                  "Power it up and let it go!", 
                    ImagePath="carconvert.png",
                    Donation = 100,
                    Deadline = "yarın"
               },
                new CrowdfundingProject 
                {
                   CFProjectID = 2,
                    ProjectName = "asdasdfewrwer",
                    Description = "This convertible cawerwerwerwerwerr is fast! The engine is powered by a neutrino based battery (not included)." + 
                                  "Power it up and let it go!", 
                    ImagePath="carconvert.png",
                    Donation = 150,
                    Deadline = "öbürsügün"
               },
              
            };

        return CrowdfundingProject;
    }
  }
}