﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication4.Data;

namespace WebApplication4.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220519001901_Intial")]
    partial class Intial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication4.Models.Categories", b =>
                {
                    b.Property<int>("CategId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categdescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Categname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Categphotos")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategId");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("WebApplication4.Models.Clients", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Clientemail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clientfirstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clientlastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clientpassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("WebApplication4.Models.Freelancer_Categorie", b =>
                {
                    b.Property<int>("FreelancerId")
                        .HasColumnType("int");

                    b.Property<int>("CategId")
                        .HasColumnType("int");

                    b.HasKey("FreelancerId", "CategId");

                    b.HasIndex("CategId");

                    b.ToTable("Freelancer_Categories");
                });

            modelBuilder.Entity("WebApplication4.Models.Freelancers", b =>
                {
                    b.Property<int>("FreelancerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Freelancerdescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Freelanceremail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Freelancername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Freelanceroccup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Freelancerpassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FreelancerId");

                    b.ToTable("Freelancer");
                });

            modelBuilder.Entity("WebApplication4.Models.Gigs", b =>
                {
                    b.Property<int>("GigId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FreelancersFreelancerId")
                        .HasColumnType("int");

                    b.Property<string>("Gigabout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gigaboutuser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gigcateg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gigphotos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gigprice")
                        .HasColumnType("int");

                    b.Property<string>("Gigtitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gigusername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GigId");

                    b.HasIndex("FreelancersFreelancerId");

                    b.ToTable("Gig");
                });

            modelBuilder.Entity("WebApplication4.Models.Freelancer_Categorie", b =>
                {
                    b.HasOne("WebApplication4.Models.Freelancers", "Freelancer")
                        .WithMany("Freelancer_Categorie")
                        .HasForeignKey("CategId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication4.Models.Categories", "Categories")
                        .WithMany("Freelancer_Categorie")
                        .HasForeignKey("FreelancerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("Freelancer");
                });

            modelBuilder.Entity("WebApplication4.Models.Gigs", b =>
                {
                    b.HasOne("WebApplication4.Models.Freelancers", null)
                        .WithMany("Gigs")
                        .HasForeignKey("FreelancersFreelancerId");
                });

            modelBuilder.Entity("WebApplication4.Models.Categories", b =>
                {
                    b.Navigation("Freelancer_Categorie");
                });

            modelBuilder.Entity("WebApplication4.Models.Freelancers", b =>
                {
                    b.Navigation("Freelancer_Categorie");

                    b.Navigation("Gigs");
                });
#pragma warning restore 612, 618
        }
    }
}
