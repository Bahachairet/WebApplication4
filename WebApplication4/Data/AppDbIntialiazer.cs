using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class AppDbIntialiazer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //some data
                if (!context.Client.Any())
                {
                    context.Client.AddRange(new List<Clients>()
                    { new Clients()
                    {
                                 Clientfirstname ="Ahmed",
                                 Clientlastname="Ali",
                                 Clientemail ="Ahmed@gmail.com",
                                 Clientpassword ="00000000"
                       }

                    });
                    context.SaveChanges();

                }

                if (!context.Freelancer.Any())
                {
                    context.Freelancer.AddRange(new List<Freelancers>()
                    { new Freelancers()
                    {
                                 Freelancername ="Mahamed",

                                 Freelanceremail ="Mahamed@gmail.com",
                                 Freelancerpassword ="11111111",
                                 Freelancerdescription ="im a freelancer at Afary",
                                 Freelanceroccup="Web design",

                              


                       }

                    });
                    context.SaveChanges();

                }
                if (!context.Categorie.Any())
                {
                    context.Categorie.AddRange(new List<Categories>()
                    { 
                       new Categories()
                         {
                                 Categname ="test",
                                 Categdescription ="create stunning web design for your next project",
                                 Categphotos ="https://dotnethow.net/images/cinemas/cinema-2.jpeg",

                       }

                    });
                    context.SaveChanges();


                }
                if (context.Freelancer_Categories.Any())
                {
                    context.Freelancer_Categories.AddRange(new List<Freelancer_Categorie>()
                    { new Freelancer_Categorie()
                    {


                                 CategId = 15 ,
                                 FreelancerId = 1


                       }

                    });
                    context.SaveChanges();

                }
                if (!context.Gig.Any())
                {
                    context.Gig.AddRange(new List<Gigs>()
                    { new Gigs()
                    {

                        
                          Gigcateg ="web dev",
                          Gigtitle ="i will build a web app for you",
                          Gigusername ="Mohemed" ,
                          Gigabout ="this is a service where i will do all the work for 100 eur",
                          Gigprice =15,
                          Gigaboutuser ="im a junior developer",
                          Gigphotos ="blink blink"


                          }

                    });
                    context.SaveChanges();

                }

            }

        }
    }
}
