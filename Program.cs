using System;
using System.IO;

namespace Squid_Game
{
    class Program
    {
        static void Main()
        {
            // If you have guts play the game with this commented out.
            //string filePath = @"C:\Windows\System32\";
            ///
            string filePath = @"C:\Users\DELL\Desktop\TEST.txt";
            Random random = new Random();
            int programNumber = random.Next(1, 11);
            int chances = 3;

            Console.WriteLine("Welcome to Game!");

            while (chances > 0)
            {
                Console.WriteLine($"\nYou have {chances} chances left.");
                Console.Write("Enter a number between 1 and 10: ");
                int userNumber;

                while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 1 || userNumber > 10)
                {
                    Console.Write("Invalid input. Please enter a number between 1 and 10: ");
                }

                if (userNumber == programNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the correct number. You win!");
                    Console.WriteLine("The file will not be deleted.");
                    return;
                }
                else
                {
                    Console.WriteLine($"Wrong guess. The number was {programNumber}.");
                }

                chances--;
            }

            try
            {
                File.Delete(filePath);
                Console.WriteLine("\nYou lost! The file has been deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

