using System;

namespace HomeWorkMetods
{
    class Task1
    {
        public static void Main(string[] args)
        {
            SplitText(InputLine());
            Console.ReadLine();
        }

        private static string[] SplitText(string text)
        {
            string[] allText = { text };
            allText = text.Split(' ');

            foreach (var findText in allText)
            {
                Console.WriteLine($"Sybstring: {findText}");
            }

            return allText;
        }

        private static string InputLine()
        {
            Console.Write("Введите строку: ");
            string line = Console.ReadLine();
            return line;
        }
    }
}
