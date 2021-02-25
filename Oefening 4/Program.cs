using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_4
{
    class Program
    {
        static void Main(string[] args)
        {

            double getal1;

            Console.Write("Hoeveel kost de fiets: ");
            getal1 = Convert.ToDouble(Console.ReadLine());

            if (getal1 >= 400)
            {
                Console.WriteLine($"Prijs na korting: {getal1*0.8} ");
            }
            else
            {
                Console.WriteLine($"Korting pas vanaf 400 euro, fiets blijft {getal1} kosten");
            }
            Console.ReadLine();

        }
    }
}
