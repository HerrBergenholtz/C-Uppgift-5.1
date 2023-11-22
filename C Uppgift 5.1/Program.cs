using System;

namespace Uppgift_5._3
{
    class Program
    {
        public static void Main()
        {
            string[] meningar = { 
                "Hejsan, jag heter Zacharias!",
                "Du heter Ameen.",
                "Trevligt att du är här idag.",
                "Hur är det med dig?" 
            };
            foreach (string mening in meningar) 
            {
                Console.WriteLine(mening);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}