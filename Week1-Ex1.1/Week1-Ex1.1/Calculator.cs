using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Ex1._1
{
    internal static class Calculator
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }


        public static int SumWithoutPlusOperator(int a, int b)
        {
            return a - (-b);
        }


        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }


        public static int Sum(params int[] numbers)
        {
            int result = 0;
            foreach(int number in numbers)
            {
                result += number;
            }
            return result;
        }
    }
}
