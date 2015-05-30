using System.Data.Entity;
namespace WingtipToys.Models
{
  public class CrowdfundingProjectContext : DbContext
  {
    public CrowdfundingProjectContext()
      : base("WingtipToys")
    {
    }
    public DbSet<CrowdfundingProject> CrowdfundingProject { get; set; } 
  }
}