using System;

namespace BytPlats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programmet kommer att byta plats på variablerna x och y.");
            Console.Write("Skriv värdet på x: ");
            string xString = Console.ReadLine();
            Console.Write("Skriv värdet på y: ");
            string yString = Console.ReadLine();
            int x = int.Parse(xString);
            int y = int.Parse(yString);
            
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);

            SwitchPlace(ref x, ref y);

            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
        }

        static void SwitchPlace (ref int a, ref int b)
        {
            Console.WriteLine("Byter plats...");
            a += b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Platser bytta!");
        }
    }
}
