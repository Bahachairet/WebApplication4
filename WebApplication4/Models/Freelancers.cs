using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Freelancers
    {
        [Key]
        public int FreelancerId { get; set; }
        [Display(Name = "Freelancername")]
        public string Freelancername { get; set; }
        [Display(Name = "Freelanceremail")]

        public string Freelanceremail { get; set; }
        [Display(Name = "Freelancerpassword")]
        public string Freelancerpassword { get; set; }
        [Display(Name = "Freelancerdescription")]
        public string Freelancerdescription { get; set; }
        [Display(Name = "Freelanceroccup")]
        public string Freelanceroccup { get; set; }

        //relation between freelancer and gigs

        public List<Gigs> Gigs { get; set; }

        public List<Freelancer_Categorie> Freelancer_Categorie { get; set; }

    }
}
