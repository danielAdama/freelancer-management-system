using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMMVC.Infrastructure.Data
{
    public class Freelancer : BaseEntity
    {
#nullable disable
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string Name { get; set; }
        //[DisplayName("Profile Picture")]
        public string? ImageUrl { get; set; }
        public string? City { get; set; }
        public int Age { get; set; }
        public string Header { get; set; }
        public long SkillId { get; set; }
        public SkillCategory Skill { get; set; }
        public long GenderId { get; set; }
        [ForeignKey("GenderId")]
        public GenderCategory Gender { get; set; }
        public long? HubbyId { get; set; }
        public HubbyCategory Hubby { get; set; }
        // A freelancer can have multiple or a project
        public ICollection<Project> Projects { get; set; }
        public string? Biography { get; set; }
    }
}
