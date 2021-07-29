using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge.Bonus
{
    class Transaction
    {
        public string OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<LineItems> LineItems { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
