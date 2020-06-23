using System;

namespace Lab_3_5DotNetContainsSpamChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Updated and works but needs refactoring!
            // - More words in BlackList
            // - Resolve Uppercase/Lowercase issue with words
            // - Use external db or flatefile that is easy to update
            //      without having to update the code.
            // Added by th 0623200
            Console.WriteLine("Hello World Lab 3_5DotNetContainsSpamChecker!");

            string blackListWord = "fudge";
            bool isSpam = false;

            string message = Console.ReadLine();

            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("The message is spam.");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("The message is not spam.");
            }

        }
    }
}
