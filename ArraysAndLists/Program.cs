using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ArraysAndLists
{
    class Program
    {
        public static string Indent(int count)
        {
            return "".PadLeft(count);
        }
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numbers = {1,2,3,4,5,6,7,8,9,10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                { 
                    evens.Add(number);
                }
                else
                {
                    odds.Add(number);
                }
            }
            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------EVENS----------\n");
            foreach (var number in evens)
            {

                if (number == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Indent(4) + number);
                }
                if (number == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Indent(8) + number);
                }
                if (number == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(Indent(12) + number);
                }
                if (number == 8)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Indent(16) + number);
                }
                if (number == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(Indent(20) + number);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------ODDS----------\n");
            foreach (var number in odds)
            {

                if (number == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(Indent(20) + number);
                }
                if (number == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(Indent(16) + number);
                }
                if (number == 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(Indent(12) + number);
                }
                if (number == 7)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(Indent(8) + number);
                }
                if (number == 9)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(Indent(4) + number);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}
