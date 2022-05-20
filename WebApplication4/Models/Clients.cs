using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Clients
    {
        [Key]
        public int ClientId { get; set; }
        [Display(Name = "Clientfirstname")]
        public string Clientfirstname { get; set; }
        [Display(Name = "Clientlastname")]
        public string Clientlastname { get; set; }
        [Display(Name = "Clientemail")]
        public string Clientemail { get; set; }
        [Display(Name = "Clientpassword")]
        public string Clientpassword { get; set; }
    }
}
