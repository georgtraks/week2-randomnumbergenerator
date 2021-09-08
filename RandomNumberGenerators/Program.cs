using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int myrandomnumber = rnd.Next(1, 10);
            //programm genereerib juhusliku nubrit 1-10
            //programm kontrollib, kas genereeritud number on 
            //suurem, kui 5.
            //kui number on suurem, kui 5, siiskonsool kuvab
            //"juhuslik number on{myrandomnumber}, see on suurem,
            //kui 5";
            //kui number on 5, siis konsool kuvab "juhuslik number on 5"

            Console.WriteLine($"arvuti genereeris: {myrandomnumber}");


            if (myrandomnumber < 5)
            {
                Console.WriteLine($"juhuslik number on {myrandomnumber}, see on väiksem, kui 5");
            }
            else if (myrandomnumber > 5)
            {
                Console.WriteLine($"juhuslik number on {myrandomnumber}, see on suurem, kui 5");
            }
            else
            {
                Console.WriteLine("juhuslik number on 5");
            }







        }
    }
}
