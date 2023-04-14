using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PlaneTicket ticket1 = new PlaneTicket();

            ticket1.Origin = "Jogja";
            ticket1.Destination = "Jakarta";
            ticket1.Cost = 100;
            ticket1.Currency = "1";

            PlaneTicket ticket2 = new PlaneTicket();

            ticket2.Origin = "Bali";
            ticket2.Destination = "Aceh";
            ticket2.Cost = 750000;
            ticket2.Currency = "2";

            ticket1.PrintSummary();

            Console.WriteLine();

            ticket2.PrintSummary();

            Console.ReadKey();
        }
    }
}
