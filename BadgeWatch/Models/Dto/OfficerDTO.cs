using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BadgeWatch.Models.Dto
{

    public class OfficerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
        public int BadgeNumber { get; set; }
        public string City { get; set; }
        public string Precinct { get; set; }
        public string Division { get; set; }
        public int Arrests { get; set; }
        public int IsActive { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime AssignmentDate { get; set; }
    }
}
