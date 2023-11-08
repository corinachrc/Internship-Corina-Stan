using System;

namespace Week1_Ex1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int sum1=Calculator.Sum(3, 4);
            int sum2=Calculator.SumWithoutPlusOperator(3, 4);
            int sum3=Calculator.Sum(1, 2, 3);
            int sum4=Calculator.Sum(1,2,3,4,5,6,7,8);
            Console.WriteLine("a. Suma celor 2 numere: "+sum1);
            Console.WriteLine("b. Suma celor 2 numere fara a folosi operatorul '+': " + sum2);
            Console.WriteLine("c. Suma celor 3 numere (overloading): " + sum3);
            Console.WriteLine("d. Suma tuturor numerelor: " + sum4);
            
        }
    }
}
