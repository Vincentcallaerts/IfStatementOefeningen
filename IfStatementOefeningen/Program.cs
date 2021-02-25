using System;


namespace IfStatementOefeningen
{
    class Program
    {
        static void Main(string[] args)
        {

            int getal1, getal2;

            Console.Write("Geef je eerste getal in: ");
            getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef je twwede getal in: ");
            getal2 = Convert.ToInt32(Console.ReadLine());

            if (getal1 >= getal2)
            {
                Console.WriteLine($"Het grootste getal is: {getal1}");
            }
            else
            {
                Console.WriteLine($"Het grootste getal is: {getal2}");
            }
        }
    }
}
