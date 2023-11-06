using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BadgeWatch.Models.Views
{
    [Table("AllRecords")]
    public class RecordsView
    {
        [Key]
        public int Id { get; set; }
        public string? IaNumber { get; set; }
        public int OfficerId { get; set; }
        public string DisciplinaryHistory { get; set; }
        public string? Discipline { get; set; }
        public DateTime DisciplinaryDate { get; set; }
    }
}
