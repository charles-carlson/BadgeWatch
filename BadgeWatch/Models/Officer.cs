using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace BadgeWatch.Models
{
    public class Officer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Rank { get; set; }
        [Required]
        public int BadgeNumber { get; set; }
        public string Division { get; set; }
        [Required]
        public string City { get; set; }
        public string Precinct { get; set; }
        public int? Arrests { get; set; }
        public int IsActive { get; set; }
        [Required]
        public DateTime AppointmentDate { get; set; }
        public DateTime? AssignmentDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
