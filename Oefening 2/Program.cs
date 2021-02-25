using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1;

            Console.Write("Hoeveel heb je gehaald: ");
            getal1 = Convert.ToInt32(Console.ReadLine());

            if (getal1 >= 5)
            {
                Console.WriteLine("Geslaagd!!");
            }
            else
            {
                Console.WriteLine("Gefaald!!");
            }
            Console.ReadLine();
        }
    }
}
