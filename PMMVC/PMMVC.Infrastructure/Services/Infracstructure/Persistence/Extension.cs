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

            modelBuilder.Entity<Freelancer>()
               .HasData(
               new Freelancer
               {
                   Id = 1,
                   FirstName = "John",
                   LastName = "Doe",
                   Age = 25,
                   City = "Abuja",
                   SkillId = 1,
                   HubbyId = 2,
                   GenderId = 1,
                   Project = "Retail Analytics",
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
                   Project = "Ecommerce",
                   TimeUpdated = DateTimeOffset.UtcNow,
                   TimeCreated = DateTimeOffset.UtcNow
               });
        }
    }
}
