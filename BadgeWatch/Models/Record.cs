using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BadgeWatch.Models
{
    public class Record
    {
        public int Id { get; set; }
        public int OfficerId { get; set; }
        public string IaNumber { get; set; }
        public string DisciplinaryHistory { get; set; }
        public string AllegationDisposition { get; set; }
        public string Discipline { get; set; }
        public DateTime DisciplinaryDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
