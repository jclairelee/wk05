using System;

namespace lab_wk05
{
    internal class Program
    {
        static void Main(string[] args)
        {

         // Generate a random number between 0 and 100

        int randomNumber = new Random().Next(0, 100);

        int guessCount = 0;

        while(true){
            // Ask user to enter an input
            Console.WriteLine("Guess a number between 0 and 100");
            int guess = Convert.ToInt32(Console.ReadLine());

            guessCount++;

            if(guess  == randomNumber)
            {
                Console.Write($"Congrates! you one!");
                Console.Write($"It took you {guessCount} guesses");
                break;
              
            } else if (guess < randomNumber){
                Console.WriteLine("⬆ ⬆ ⬆ UP ⬆ ⬆ ⬆");
            } else {
                Console.WriteLine("⬇ ⬇ ⬇ DOWN ⬇ ⬇ ⬇");
            }
        }
        }
    }
}
