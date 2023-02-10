using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Du måste vara mellan 16 och 19 år för att delta i tävlingen.\n" +
                              "Hur gammal är du?");
            int ålder = Convert.ToInt32(Console.ReadLine());

            if (ålder >= 16 && ålder <= 19)
                Console.WriteLine("Du får delta i tävlingen.");

            else if (ålder > 19)
                Console.WriteLine("Du är för gammal");

            else if (ålder < 16)
                Console.WriteLine("Du är för ung");

        }
    }
}
