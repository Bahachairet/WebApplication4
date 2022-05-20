namespace WebApplication4.Models
{
    public class Freelancer_Categorie
    {
        public int CategId { get; set; }
        public Categories Categories { get; set; }
        public int FreelancerId { get; set; }
        public Freelancers Freelancers { get; set; }
    }
}
