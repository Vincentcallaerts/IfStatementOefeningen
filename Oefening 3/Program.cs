using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1;

            Console.Write("Geef een getal in: ");
            getal1 = Convert.ToInt32(Console.ReadLine());

            if (getal1 % 2 == 0)
            {
                Console.WriteLine("Dit is een even getal");
            }
            else
            {
                Console.WriteLine("Dit is een oneven getal");
            }
            Console.ReadLine();
        }
    }
}
