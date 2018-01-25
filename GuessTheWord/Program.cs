using System;

namespace GuessTheWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Whatever";
            int guessLimit = 5;
            int guessesUsed = 0;
            string maskedWord = "";

            for (int i = 0; i < word.Length; i++)
            {
                maskedWord = maskedWord + "*";
            }

            Console.WriteLine("Welcome to guess the word!");

            while (guessesUsed <= guessLimit)
            {
                Console.Clear();
                Console.WriteLine("You have " + (guessLimit - guessesUsed).ToString() + " guesses left.");
                Console.WriteLine(maskedWord);
                Console.WriteLine("Please choose a character.");
                char currentGuess = Console.ReadKey().KeyChar;

                bool guessedCorrectly = false;

                for (int i = 0; i < word.Length; i++)
                {
                    char currentCharacter = word[i];

                    if (currentGuess == currentCharacter)
                    {
                        var maskedWordArray = maskedWord.ToCharArray();
                        maskedWordArray[i] = currentCharacter;
                        maskedWord = new string(maskedWordArray);
                        guessedCorrectly = true;

                    }
                }

                if (guessedCorrectly == false)
                {
                    guessesUsed++;
                }

                if (maskedWord == word)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("YOU WIN!!!");
                    Console.ResetColor();
                }

                if (guessesUsed == guessLimit)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU LOSE!!!");
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
