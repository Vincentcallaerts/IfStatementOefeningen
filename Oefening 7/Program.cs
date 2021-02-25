using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_7
{
    class Program
    {
        static void Main(string[] args)
        {

            int getal1,getal2,getal3;
            int temp;
            string antwoord;

            Console.Write("Eerste getal: ");
            getal1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Tweede getal: ");
            getal2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Derde getal: ");
            getal3 = Convert.ToInt32(Console.ReadLine());

            temp = Math.Min(getal1, Math.Min(getal2, getal3));
            antwoord = $"{temp}";
            temp = Math.Max(Math.Min(getal1, getal2), Math.Min(Math.Max(getal1, getal2), getal3));
            antwoord = antwoord + $"-{temp}";
            temp = Math.Max(getal1, Math.Max(getal2, getal3));
            antwoord = antwoord + $"-{temp}";

            Console.WriteLine(antwoord);
            Console.ReadLine();

        }
    }
}
