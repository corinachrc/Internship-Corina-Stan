using System;

namespace Week1_Ex1._2
{
    
    internal class Program
    {
        static bool IsHoloalfabetic(string input)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";           
            input = input.ToLower();
            
            foreach (char letter in alphabet)
            {
                if (!input.Contains(letter))
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Introduceti propozitia: ");
            string sentence = Console.ReadLine();

            if (IsHoloalfabetic(sentence))
            {
                Console.WriteLine("Propozitia este holoalfabetica.");
            }
            else
            {
                Console.WriteLine("Propozitia nu este holoalfabetica.");
            }
        }
    }
}
