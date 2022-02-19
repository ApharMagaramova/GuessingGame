using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int WinNumber = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess the number.");

                int number = Int32.Parse(Console.ReadLine());

                if (number < WinNumber)
                {
                    Console.WriteLine("To Low. Guess higher...");
                }

                else if (number > WinNumber)
                {
                    Console.WriteLine("To high. Guess lower..");
                }

                else if (number == WinNumber)
                {
                    Console.WriteLine("You Win!");
                    win = true;
                }

                Console.WriteLine();

            } while (win == false);

            Console.WriteLine("Thank you for playing guessing game!");
            Console.WriteLine("Press twice any key to finish");
            Console.ReadKey(true);
        }
    }
}
