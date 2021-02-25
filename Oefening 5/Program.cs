using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string antwoord;

            Console.Write("Is er iemand thuis?  ");
            antwoord = Console.ReadLine();


            if (antwoord.Equals("ja") || antwoord.Equals("Ja"))
            {

                Console.Write("Is de situatie onder controle?  ");
                antwoord = Console.ReadLine();

                if (antwoord.Equals("ja") || antwoord.Equals("Ja"))
                {
                    Console.Write("Het alarm wordt uitgeschakeld");
                }
                else
                {
                    Console.Write("De brandweer wordt verwittigd");
                }
            }
            else
            {
                Console.WriteLine("De brandweer wordt verwittigd");
            }
            Console.ReadLine();
        }
    }
}
