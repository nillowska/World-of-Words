using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace World_of_Words
{
    public class Hard
    {
        public Hard()
        {
            Console.Clear();
            DisplayInterface headerPhoto = new DisplayInterface();

            Random wordIndex = new Random();

            string[] allWords = File.ReadAllLines(@"Words.txt");
            string[,] viewWords = new string[3, 8];
            string lineToPrint = string.Empty;

            for (int i = 0; i < 8; i++)
            {
                int wordNumber = wordIndex.Next(0, allWords.Length);
                string word = allWords[wordNumber];

                lineToPrint += word + " ";
            }

            viewWords[0, 0] = 1.ToString();
            viewWords[0, 1] = 2.ToString();
            viewWords[0, 2] = 3.ToString();
            viewWords[0, 3] = 4.ToString();
            viewWords[0, 4] = 5.ToString();
            viewWords[0, 5] = 6.ToString();
            viewWords[0, 6] = 7.ToString();
            viewWords[0, 7] = 8.ToString();

            viewWords[1, 0] = lineToPrint;
            viewWords[1, 1] = lineToPrint;
            viewWords[1, 2] = lineToPrint;
            viewWords[1, 3] = lineToPrint;
            viewWords[1, 4] = lineToPrint;
            viewWords[1, 5] = lineToPrint;
            viewWords[1, 6] = lineToPrint;
            viewWords[1, 7] = lineToPrint;

            viewWords[2, 0] = lineToPrint;
            viewWords[2, 1] = lineToPrint;
            viewWords[2, 2] = lineToPrint;
            viewWords[2, 3] = lineToPrint;
            viewWords[2, 4] = lineToPrint;
            viewWords[2, 5] = lineToPrint;
            viewWords[2, 6] = lineToPrint;
            viewWords[2, 7] = lineToPrint;


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
