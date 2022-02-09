using System;
using System.IO;

namespace World_of_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            HeaderPhoto headerPhoto = new HeaderPhoto();

            string choice;
            string fileName = @"Words.txt";

            if (File.Exists(fileName))
            {
                Console.WriteLine("Hello! Please choose level ;)\nLight - 4 words and 10 chances (L) " +
                                  "\nHard - 8 words and 15 chances (H)\n\n");
                choice = Console.ReadLine();

                if (choice == "l")
                {
                    Light light = new Light();
                }

                else if (choice == "h")
                {
                    Hard hard = new Hard();
                }

                else
                    Console.WriteLine("Wrong choice. Please select 'l' or ' h'");
            }

            else if (!File.Exists(fileName))
            {
                Console.WriteLine("Where is the file with words?! You lost it? Oh no, we can't play now :(");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
