using JSONChallenge.BadgesInfo;
using JSONChallenge.GenCon;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person someDude = new Person();
            someDude.FirstName = "Will";
            someDude.LastName = "Smith";
            someDude.DOB = new DateTime(1968, 3, 20);
            someDude.FavoriteFoods = new List<string> { "Turtle bread", "Powder sugar" };

            string json = JsonConvert.SerializeObject(someDude);
            Console.WriteLine(json);

            Console.ReadKey();

            //Chall one

            GenConTicketPOCO fullWeekEnd = new GenConTicketPOCO();
            fullWeekEnd.StartDate = new DateTime(2021, 07, 27);
            fullWeekEnd.EndDate = new DateTime(2021, 07, 31);
            fullWeekEnd.EventTitle = "Gen Con";
            fullWeekEnd.EventCapacity = "10000";
            fullWeekEnd.PriceOfAdmission = 325.50m;

            string json2 = JsonConvert.SerializeObject(fullWeekEnd);

            Console.WriteLine(json2);
            Console.ReadKey();

            //chall two

            BadgesPOCO badge1 = new BadgesPOCO();
            badge1.BadgeId = 12345;
            badge1.ListOfDoors = new List<string> { "A1", "B2", "B5", "G21" };
            badge1.HasSecurityClearance = true;
            badge1.EmployeeId = "F54G678HJ32321S";
            badge1.CreatedOn = new DateTime(2021, 07, 27, 17,35,42,345);

            string json3 = JsonConvert.SerializeObject(fullWeekEnd);
            Console.WriteLine(json3);
            Console.ReadKey();
        }
    }
}
