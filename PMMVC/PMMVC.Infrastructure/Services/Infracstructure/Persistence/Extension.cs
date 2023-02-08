using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PMMVC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PMMVC.Infrastructure.Services.Infracstructure.Persistence
{
    public static class Extensions
    {
        public static IServiceCollection RegisterPersistence(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<FreelanceDbContext>(option =>
            {
                option.UseNpgsql(configuration.GetConnectionString("Freelance"));
                //option.EnableSensitiveDataLogging();
            });

            return services;
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GenderCategory>()
               .HasData(
               new GenderCategory
               {
                   Id = 1,
                   Name = "Male",
                   TimeUpdated = DateTimeOffset.UtcNow,
                   TimeCreated = DateTimeOffset.UtcNow
               },
               new GenderCategory
               {
                   Id = 2,
                   Name = "Female",
                   TimeUpdated = DateTimeOffset.UtcNow,
                   TimeCreated = DateTimeOffset.UtcNow
               });
            modelBuilder.Entity<HubbyCategory>()
               .HasData(
               new HubbyCategory
               {
                   Id = 1,
                   Name = "Music",
                   TimeUpdated = DateTimeOffset.UtcNow,
                   TimeCreated = DateTimeOffset.UtcNow
               },
               new HubbyCategory
               {
                   Id = 2,
                   Name = "Games",
                   TimeUpdated = DateTimeOffset.UtcNow,
                   TimeCreated = DateTimeOffset.UtcNow
               });
            modelBuilder.Entity<SkillCategory>()
               .HasData(
               new SkillCategory
               {
                   Id = 1,
                   Name = "Machine Learning",
                   TimeUpdated = DateTimeOffset.UtcNow,
                   TimeCreated = DateTimeOffset.UtcNow
               },
               new SkillCategory
               {
                   Id = 2,
                   Name = "Software Engineer",
                   TimeUpdated = DateTimeOffset.UtcNow,
                   TimeCreated = DateTimeOffset.UtcNow
               });

            modelBuilder.Entity<Project>()
                .HasData(
                new Project
                {
                    Id = 1,
                    Name = "Retail Analytics",
                    Documentation = "Retail analytics is the process of providing analytical data on inventory levels, supply chain movement, consumer demand, sales, etc. that are crucial for making marketing, and procurement decisions",
                    FreelancerId = 1
                },
                new Project
                {
                    Id = 2,
                    Name = "Data Analytics",
                    Documentation = "Analytics of the sales of XYZ company",
                    FreelancerId = 1
                },
                new Project
                {
                    Id = 3,
                    Name = "Ecommerce",
                    Documentation = "E-commerce (electronic commerce) is the buying and selling of goods and services, or the transmitting of funds or data, over an electronic network, primarily the internet. These business transactions occur either as business-to-business (B2B), business-to-consumer (B2C), consumer-to-consumer or consumer-to-business.",
                    FreelancerId = 2
                });
            modelBuilder.Entity<Freelancer>()
               .HasData(
               new Freelancer
               {
                   Id = 1,
                   FirstName = "John",
                   LastName = "Doe",
                   Age = 25,
                   City = "Abuja",
                   Header = "Machine Learning Engineer",
                   SkillId = 1,
                   HubbyId = 2,
                   GenderId = 1,
                   TimeUpdated = DateTimeOffset.UtcNow,
                   TimeCreated = DateTimeOffset.UtcNow
               },
               new Freelancer
               {
                   Id = 2,
                   FirstName = "Jane",
                   LastName = "Doe",
                   Age = 22,
                   City = "Lagos",
                   SkillId = 2,
                   HubbyId = 1,
                   GenderId = 2,
                   TimeUpdated = DateTimeOffset.UtcNow,
                   TimeCreated = DateTimeOffset.UtcNow
               });
        }
    }
}
