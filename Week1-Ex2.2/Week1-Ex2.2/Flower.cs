using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Ex2._2
{
    public class Flower:Product
    {        

        public Flower(string name)
        {
            Name=name;
            switch (name)
            {
                case "rose":
                    Price = 10; 
                    break;
                case "gladiola":
                    Price = 15;
                    break;
                case "hydrangea": 
                    Price= 30;
                    break;
                default:
                    Console.WriteLine(name +" is not in the lists of products accepted!!");
                    break;
            }
        }
    }
}
