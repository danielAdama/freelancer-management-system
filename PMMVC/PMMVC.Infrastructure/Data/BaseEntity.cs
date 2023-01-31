using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMMVC.Infrastructure.Data
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public DateTimeOffset TimeCreated { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset TimeUpdated { get; set; }
    }
}
