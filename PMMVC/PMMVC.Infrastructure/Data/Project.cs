using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMMVC.Infrastructure.Data
{
    public class Project
    {
#nullable disable
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public long? FreelancerId { get; set; }
        public Freelancer Freelancer { get; set; }
        public string Documentation { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}
