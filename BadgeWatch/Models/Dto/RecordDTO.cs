using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BadgeWatch.Models.Dto
{
    public class RecordDto
    {
        public int Id { get; set; }
        public int OfficerId { get; set; }
        public string DisciplinaryHistory { get; set; }
        public DateTime DisciplinaryDate { get; set; }
    }
}
