using System;
using System.IO;

namespace World_of_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayInterface headerPhoto = new DisplayInterface();

            string choice;
            string fileName = @"Words.txt";

            if (File.Exists(fileName))
            {
                Console.WriteLine("Hello! Please choose level ;)\nEasy - 4 words and 10 chances (E) " +
                                  "\nHard - 8 words and 15 chances (H)\n\n");
                choice = Console.ReadLine();
                string choiceUpper = choice.ToUpper();

                if (choiceUpper == "E")
                {
                    Easy easy = new Easy();
                }

                else if (choiceUpper == "H")
                {
                    Hard hard = new Hard();
                }

                else
                    Console.WriteLine("Wrong choice. Please select 'e' or ' h'");
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
