using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    public class PlaneTicket
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int Cost { get; set; }
        public string Currency { get; set; }

        public void PrintSummary()
        {
            Console.WriteLine("Origin: {0}", Origin);
            Console.WriteLine("Destination: {0}", Destination);
            if (Currency == "1")
            {
                Console.WriteLine("Cost: ${0}", Cost);
                Console.WriteLine("Convert to Rupiah: Rp{0}", Cost * 15000);
            }
            else if (Currency == "2")
            {
                Console.WriteLine("Cost: Rp{0}", Cost);
                Console.WriteLine("Convert to Dollar: ${0}", Cost / 15000);
            }
            else
            {
                Console.WriteLine("Invalid Currency");
            }
        }
    }
}
