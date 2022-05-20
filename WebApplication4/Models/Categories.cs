using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Categories
    {
        [Key]
        public int CategId { get; set; }
        [Display(Name = "Categname")]
        public string Categname { get; set; }
        [Display(Name = "Categdescription")]
        public string Categdescription { get; set; }
        [Display(Name = "Categphotos")]
        public string Categphotos { get; set; }

        //relation between categorie and freelancers

        public List<Freelancer_Categorie> Freelancer_Categorie { get; set; }

    }
}
