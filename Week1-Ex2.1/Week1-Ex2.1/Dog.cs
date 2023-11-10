using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Ex2._1
{
    internal class Dog : Animal
    {

        public bool IsPuppy { get; set; }
        public bool IsChildFriendly { get; set; }

        public Dog() { }

        public Dog(string name, string breed, double weight, bool ispuppy, bool ischildfriendly) : base(name, breed, weight)
        {
            IsPuppy = ispuppy;
            IsChildFriendly = ischildfriendly;

        }




        public void DisplayAllDetails()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Breed: " + Breed);
            Console.WriteLine("Weight (kg): " + Weight);
            Console.WriteLine("It is baby? " + IsPuppy);
            Console.WriteLine("It is agressive? " + IsChildFriendly);
            Woff();
            Console.WriteLine("");
        }

        public void Woff()
        {

            Console.WriteLine(Name + " says: WOOOFFFF");
        }

    }
}
