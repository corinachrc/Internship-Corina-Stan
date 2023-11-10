using System;

namespace Week1_Ex2._1
{
    internal class Cat : Animal
    {
        public bool IsKitten { get; set; }
        public bool IsAgressive { get; set; }

        public Cat() { }

        public Cat(string name, string breed, double weight, bool iskitten, bool isagressive) : base(name, breed, weight)
        {
            IsKitten = iskitten;
            IsAgressive = isagressive;

        }




        public void DisplayAllDetails()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Breed: " + Breed);
            Console.WriteLine("Weight (kg): " + Weight);
            Console.WriteLine("It is baby? " + IsKitten);
            Console.WriteLine("It is agressive? " + IsAgressive);
            Meow();
            Console.WriteLine("");
        }

        public void Meow()
        {

            Console.WriteLine(Name + " says: MEOOOOWWW");
        }
    }
}
