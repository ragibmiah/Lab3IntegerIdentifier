using System;

namespace Lab3Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer Identifier!");

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

        start:
            Console.Write($"{name} please enter an integer between 1 and 100: ");
            string input = Console.ReadLine();

            int num;
            bool reply = int.TryParse(input, out num);


            if (reply)
            {
                if (num <= 0 || num > 100)
                {
                    Console.WriteLine($"{name} the number {num} is not on the scale");
                    goto start;
                }

                if (num % 2 == 0 && num >= 2 && num <= 25)
                {
                    Console.WriteLine($"{name} the number {num} is even and less than 25");
                }
                if (num % 2 == 0 && num >= 26 && num <= 60)
                {
                    Console.WriteLine("Even");
                }
                else if (num % 2 == 0 && num >= 60)
                {
                    Console.WriteLine($"{name} the number {num} is even");
                }
            }
            if (num % 2 == 1)
            {
                Console.WriteLine($"{name} the number {num} is odd");
                {
                    if (num > 60 && num % 2 == 1)
                    {
                        Console.WriteLine($"{name} the number {num} is odd");
                    }
                }
            }
            else
            {
                Console.WriteLine("That is not an integer.");
            }
            Console.ReadKey();

            Console.WriteLine("Do you want to try again? (Y or N) ");
            string response;
            response = Console.ReadLine();
            if (response == "y" || response == "Y")
            {
                Console.WriteLine("");
                goto start;
            }
            else { };
        }

    }
}
