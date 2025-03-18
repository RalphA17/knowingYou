using System;
using System.Xml.Linq;

namespace MyApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            int x;
            x = 2025;

            Console.WriteLine("Please answer the questions below");

            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What year were you born?");
            int age = Convert.ToInt32(Console.ReadLine());
            age = 2025 - age;

            Console.WriteLine("How many siblings do you have?");
            int sib = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your hobby?");
            string hob = Console.ReadLine();

            Console.WriteLine("Your name is " + name + ". You are " + age +" years old.");
            Console.WriteLine("You have " + sib + " siblings and your hobby is " + hob + ".");


        }
    }
}