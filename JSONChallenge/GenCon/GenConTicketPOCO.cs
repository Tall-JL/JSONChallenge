using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge.GenCon
{
    class GenConTicketPOCO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string EventTitle { get; set; }
        public string EventCapacity { get; set; }
        public decimal PriceOfAdmission { get; set; }

    }
}
