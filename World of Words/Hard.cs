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
            string[] lines = File.ReadAllLines(@"Words.txt");
            Random randomFirst = new Random();
            Random randomSecond = new Random();
            Random randomThird = new Random();
            Random randomFourth = new Random();
            Random randomFifth = new Random();
            Random randomSixth = new Random();
            Random randomSeventh = new Random();
            Random randomEighth = new Random();


            Console.WriteLine("This is hard level! \nYou have to finds two same words.\n");
            Console.WriteLine(lines[randomFirst.Next(lines.Length)]);
            Console.WriteLine(lines[randomSecond.Next(lines.Length)]);
            Console.WriteLine(lines[randomThird.Next(lines.Length)]);
            Console.WriteLine(lines[randomFourth.Next(lines.Length)]);
            Console.WriteLine(lines[randomFifth.Next(lines.Length)]);
            Console.WriteLine(lines[randomSixth.Next(lines.Length)]);
            Console.WriteLine(lines[randomSeventh.Next(lines.Length)]);
            Console.WriteLine(lines[randomFourth.Next(lines.Length)]);
        }
    }
}
