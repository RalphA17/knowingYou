using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentYear = 2025;

            Console.WriteLine("Please answer the questions below");

            string name = GetInput("What is your name?");
            int birthYear = GetValidatedIntInput("What year were you born?");
            int age = currentYear - birthYear;

            int siblings = GetValidatedIntInput("How many siblings do you have?");
            string hobby = GetInput("What is your hobby?");

            Console.WriteLine($"Your name is {name}. You are {age} years old.");
            Console.WriteLine($"You have {siblings} siblings and your hobby is {hobby}.");
        }

        static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        static int GetValidatedIntInput(string prompt)
        {
            int result;
            while (true)
            {
                Console.WriteLine(prompt);
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            return result;
        }
    }
}