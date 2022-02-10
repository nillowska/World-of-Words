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

            for (int i = 0; i < 8; i++)
            {
                int wordNumber = wordIndex.Next(0, allWords.Length);
                string word = allWords[wordNumber];

                Console.WriteLine(wordNumber + word);

            }
        }
    }
}
