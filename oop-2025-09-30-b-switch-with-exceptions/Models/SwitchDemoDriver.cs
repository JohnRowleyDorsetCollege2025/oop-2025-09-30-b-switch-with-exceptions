using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_09_30_b_switch_with_exceptions.Models
{
     public class SwitchDemoDriver
    {
        public static void Run()
        {

            Console.WriteLine("Switch Expressions");

            // generate a random number between 1 and 10
            Random random = new Random();
            int number = random.Next(1, 5);

            Console.WriteLine($"Generated number: {number}");

            //output the number in words using a switch statement
            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                default:
                    throw new Exception("Number is out of range");
            }

            string result = number switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                _ => "Number not recognized"
            };

            Console.WriteLine($"Switch Expression: {result}");

            Console.Write("Enter a color: ");
            string colour = Console.ReadLine().ToLower(); // Normalize input

            switch (colour)
            {
                case "red":
                case "orange":
                case "yellow":
                case "green":
                case "blue":
                case "indigo":
                case "violet":
                    Console.WriteLine($"{colour} is a color in the rainbow.");
                    break;

                default:
                    Console.WriteLine($"{colour} is NOT a color in the rainbow.");
                    break;
            }
        }
    }
}
