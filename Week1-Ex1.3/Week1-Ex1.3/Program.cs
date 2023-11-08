using System;

namespace Week1_Ex1._3
{
    internal class Program
    {  

        static void SwapVariables(ref string a, ref string b)
        {
            a = a+b;
            b=a.Substring(0, a.Length-b.Length);
            a = a.Substring(b.Length);
        }

        static void Main(string[] args)

        {
            
            Console.Write("Introduceti prima variabila: ");
            string variable1=Console.ReadLine();

            Console.Write("Introduceti a doua variabila: ");
            string variable2 = Console.ReadLine();

            Console.WriteLine("Variables before swap: a= "+variable1+"\t b= "+variable2);

            SwapVariables(ref variable1, ref variable2);
            Console.WriteLine("Variables after swap: a= "+variable1+"\t b= "+variable2);
        }
    }
}
