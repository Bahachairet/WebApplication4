using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class AppDbContext :DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Freelancer_Categorie>().HasKey(am => new
            {
                am.FreelancerId,
                am.CategId
            });
            modelBuilder.Entity<Freelancer_Categorie>().HasOne(m => m.Categories).WithMany
                (am => am.Freelancer_Categorie).HasForeignKey(am => am.FreelancerId);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Freelancer_Categorie>().HasOne(m => m.Freelancers).WithMany
              (am => am.Freelancer_Categorie).HasForeignKey(am => am.CategId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Freelancers> Freelancer { get; set; }
        public DbSet<Categories> Categorie { get; set; }
        public DbSet<Freelancer_Categorie> Freelancer_Categories { get; set; }
        public DbSet<Clients> Client { get; set; }
        public DbSet<Gigs> Gig { get; set; }

    }
}
