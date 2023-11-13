using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Ex2._2
{
    internal class Bouquet:Product
    {
               
        public Bouquet(string name, Flower[] flowers, int[] pieces)
        {
            Name = name;
            int totalPrice = 0;
            if (flowers.Length == pieces.Length) {
                for(int i=0; i<pieces.Length; i++)
                {
                    totalPrice += flowers[i].Price * pieces[i];
                }
            Price = totalPrice+2;
            }
            else
            {
                Console.WriteLine("Nu ati specificat numarul de bucati pentru fiecare tip de floare!");
            }
        }
        
    }
}
