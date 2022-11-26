using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWorkMetods
{
    class Task2
    {
        public static void Main()
        {
            RewersWords(Reverse());
            Console.ReadLine();
        }

        public static string RewersWords(string inputPhrase)
        {
            string[] allText = { inputPhrase };
            allText = inputPhrase.Split(' ');

            return inputPhrase;
        }

        public static string Reverse()
        {
            Console.Write("Введите текст: ");
            var words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(" ", words.Reverse()));
            return RewersWords(Reverse());
        }
    }
}
