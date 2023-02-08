using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PMMVC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PMMVC.Infrastructure.Services.Infracstructure.Persistence
{
    public class FreelanceDbContext : IdentityDbContext<AppUser, AppRole, long>
    {
#nullable disable
        public FreelanceDbContext(DbContextOptions<FreelanceDbContext> options) : base(options)
        { }
        public DbSet<Freelancer> Freelancers { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<GenderCategory> GenderCategories { get; set; }
        public DbSet<HubbyCategory> HubbyCategories { get; set; }
        public DbSet<SkillCategory> SkillCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add the Postgres Extension for UUID generation
            modelBuilder.HasPostgresExtension("uuid-ossp");
            modelBuilder.Seed();
        }
    }
}
