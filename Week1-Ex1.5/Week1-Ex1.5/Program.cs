using System;
using System.Linq;

namespace Week1_Ex1._5
{
    internal class Program
    {        
        static void IsWinner(int[] guesses)
        {
           //   int[] winningNumbers = { 1, 2, 3, 4, 5, 6 } ;
            int[] winningNumbers = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Random rand = new Random();
                winningNumbers[i] = rand.Next(1, 49);
            }
         
            bool winner=false;            
            foreach (int guess in guesses)
            {
                if (winningNumbers.Contains(guess)){
                    winner = true;
                }
                else
                {
                    winner = false;
                }
            }
           

            if(winner)
            {
                Console.WriteLine("Biletul tau este castigator!!! Felicitari");
            }
            else
            {
                Console.WriteLine("Biletul tau nu este castigator");
            }

        }

        static void Main(string[] args)
        {
            int[] userNumbers = new int[6];
            for (int i = 0;i<userNumbers.Length;i++)
            {
                Console.Write("Introduceti un numar intre 1 si 49: ");
                userNumbers[i] = Int32.Parse(Console.ReadLine());
            }
            IsWinner(userNumbers);
        }
    }
}
