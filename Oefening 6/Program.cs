using System;


namespace Oefening_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string antwoord;
            int teller = 0;

            Console.Write("Is er iemand thuis?  ");
            antwoord = Console.ReadLine();
            if (antwoord.Equals("ja") || antwoord.Equals("Ja"))
            {
                teller++;
            }
            Console.Write("Is er iemand thuis?  ");
            antwoord = Console.ReadLine();
            if (antwoord.Equals("ja") || antwoord.Equals("Ja"))
            {
                teller++;
            }
            Console.Write("Is er iemand thuis?  ");
            antwoord = Console.ReadLine();
            if (antwoord.Equals("ja") || antwoord.Equals("Ja"))
            {
                teller++;
            }
            Console.Write("Is er iemand thuis?  ");
            antwoord = Console.ReadLine();
            if (antwoord.Equals("ja") || antwoord.Equals("Ja"))
            {
                teller++;
            }
            Console.Write("Is er iemand thuis?  ");
            antwoord = Console.ReadLine();
            if (antwoord.Equals("ja") || antwoord.Equals("Ja"))
            {
                teller++;
            }

            if (teller >=3)
            {
                Console.WriteLine("Ah oke duidelijk er is iemand thuis");
            }
            else
            {
                Console.WriteLine("Oei toch niemand thuis dan");
            }


            Console.ReadLine();
        }
    }
}
