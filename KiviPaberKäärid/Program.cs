using System;

namespace KiviPaberKäärid
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int number = rnd.Next(1, 3);
            int number2 = rnd.Next(1, 3);

            Console.WriteLine($"arvuti genereeris: {number}");
            Console.WriteLine($"arvuti genereeris: {number2}");


            if (1 > 2)
            {
                Console.WriteLine("paber katab kivi.");
            }
            else if (2 < 3)
            {
                Console.WriteLine("kivi nürib käärid.");
            }
            else 
            {
                Console.WriteLine("käärid lõikavad paberit.");
            }

        }
    }
}
