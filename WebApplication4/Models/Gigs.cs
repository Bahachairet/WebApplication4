using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Gigs
    {
        [Key]
        public int GigId { get; set; }
        [Display(Name = "Gigcateg")]
        public string Gigcateg { get; set; }
        [Display(Name = "Gigtitle")]

        public string Gigtitle { get; set; }
        [Display(Name = "Gigusername")]
        public string Gigusername { get; set; }
        [Display(Name = "Gigabout")]
        public string Gigabout { get; set; }
        [Display(Name = "Gigprice")]
        public int Gigprice { get; set; }
        [Display(Name = "Gigaboutuser")]
        public string Gigaboutuser { get; set; }
        [Display(Name = "Gigphotos")]
        public string Gigphotos { get; set; }
    }
}
