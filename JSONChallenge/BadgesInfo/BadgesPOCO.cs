using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge.BadgesInfo
{
    class BadgesPOCO
    {
        public int BadgeId { get; set; }
        public List<string> ListOfDoors { get; set; }
        public bool HasSecurityClearance { get; set; }
        public string EmployeeId { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
