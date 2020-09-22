using System;
using System.Text;

namespace Word_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user to enter two words
            Console.WriteLine("Please enter a word");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Please enter a second word");
            string secondWord = Console.ReadLine();

            // convert to ASCII
            byte [] asciiFirstWord = Encoding.ASCII.GetBytes(firstWord);
            byte[] asciiSecondWord = Encoding.ASCII.GetBytes(secondWord);
            int[] asciiSubtracted = new int[firstWord.Length];

            // Loop through and do the subtraction
            for (int i = 0; i < asciiFirstWord.Length; i++)
            {
                asciiSubtracted[i] = asciiFirstWord[i] - asciiSecondWord[i];
            }

            for(int i = 0; i < asciiSubtracted.Length; i++)
            {
                Console.WriteLine(asciiSubtracted[i]);
            }

            Console.ReadLine();



        }
    }
}
