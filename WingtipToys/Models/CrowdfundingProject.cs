using System.ComponentModel.DataAnnotations;

namespace WingtipToys.Models
{
    public class CrowdfundingProject
    {
        [ScaffoldColumn(false)]
        public int CFProjectID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string ProjectName { get; set; }

        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }


        [Display(Name = "Donation")]
        public double Donation { get; set; }

        [Display(Name = "Deadline")]
        public string Deadline { get; set; }
    }
}