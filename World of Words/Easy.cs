using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace World_of_Words
{
    public class Easy
    {
        public Easy()
        {
            Console.Clear();
            DisplayInterface headerPhoto = new DisplayInterface();

            Random wordIndex = new Random();

            string[] allWords = File.ReadAllLines(@"Words.txt");
            string[,] viewWords = new string[3, 4];
            string lineToPrint = string.Empty;

            for (int i = 0; i < 4; i++)
            {
                int wordNumber = wordIndex.Next(0, allWords.Length);
                string word = allWords[wordNumber];

                lineToPrint += word + " ";
            }

            viewWords[0, 0] = 1.ToString();
            viewWords[0, 1] = 2.ToString();
            viewWords[0, 2] = 3.ToString();
            viewWords[0, 3] = 4.ToString();

            viewWords[1, 0] = lineToPrint;
            viewWords[1, 1] = lineToPrint;
            viewWords[1, 2] = lineToPrint;
            viewWords[1, 3] = lineToPrint;

            viewWords[2, 0] = lineToPrint;
            viewWords[2, 1] = lineToPrint;
            viewWords[2, 2] = lineToPrint;
            viewWords[2, 3] = lineToPrint;

            static void displayArray(string[,] viewWords)
            {
                for (int k = 0; k < viewWords.GetLength(0); k++)
                {
                    for (int l = 0; l < viewWords.GetLength(1); l++)
                    {
                        Console.Write(viewWords[k, l]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            displayArray(viewWords);
        }
    }
}
