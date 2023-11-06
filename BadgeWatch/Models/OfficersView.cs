using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace BadgeWatch.Models
{
    [Table("AllOfficers")]
    public class OfficersView
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Rank { get; set; }
        [Required]
        public int BadgeNumber { get; set; }
        public string Division { get; set; }
        [Required]
        public string City { get; set; }
        public string? Precinct { get; set; }
        public int? Arrests { get; set; }
        public int IsActive { get; set; }
        [Required]
        public DateTime AppointmentDate { get; set; }

    }
}
