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

            string[] allWords = File.ReadAllLines(@"Words.txt");

            Random randWord = new Random();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(allWords[randWord.Next(allWords.Length)]);

            }
        }
    }
}
