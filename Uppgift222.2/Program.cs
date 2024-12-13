using System;
using System.Globalization;

namespace Uppgift222._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett heltal");
            String str = Console.ReadLine();
            int tal=int.Parse(str); 
            while (tal!=0)
            {
                Console.WriteLine("skriv igen (skriv in 0 för att avsluta");
                str = Console.ReadLine();
                tal = int.Parse(str);
            }
            Console.WriteLine("Du har avslutat programet");






        }

    }
}
    