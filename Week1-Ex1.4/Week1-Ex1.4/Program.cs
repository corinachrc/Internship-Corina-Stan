using System;
using System.Collections.Generic;
using System.Transactions;
using System.Xml.Linq;

namespace Week1_Ex1._4
{
    internal class Program
    {
        static void CountCharacterOccurrences(string input)
        {
            char currectCharacter = input[0];
            int count = 1;
            for (int i = 1; i < input.Length; i++)
            {                
                if (input[i] == input[i - 1])
                {                    
                    count++;
                }
                else
                {
                    Console.Write(currectCharacter);
                    if (currectCharacter!=' ')
                    {                        
                        Console.Write(count);
                    }             
                    currectCharacter = input[i];
                    count = 1;
                }
            }
            Console.Write(currectCharacter);
            if (currectCharacter != ' ')
            {
                Console.Write(count);
            }

        }

        static void Main(string[] args)
        {
            string input = "aaanna issss attt ssschhooooolll";
            Console.Write("Input: " + input + "\nOutput: ");
            CountCharacterOccurrences(input);
        }
    }
}
