using System;

namespace Week1_Ex2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shelter shelter1 = new Shelter();
            shelter1.Name = "A";
            shelter1.Adress = "Brasov City, Lunga Street, no 5";
            shelter1.NumberOfPlaces = 4;

            Cat cat1 = new Cat("pisi", "persian", 2, true, true);
            Cat cat2 = new Cat();
            cat2.Name = "Linda";
            cat2.Breed = "Ragdoll";
            cat2.Weight = 2.5;
            cat2.IsAgressive = false;
            cat2.IsKitten = false;
            Cat cat3 = new Cat("Bubu", "unknown", 1.5, false, true);

            Dog dog1 = new Dog("cutu", "french buldog", 5, false, true);
            Dog dog2 = new Dog();
            dog2.Name = "Kira";
            dog2.Breed = "unknown";
            dog2.Weight = 15;
            dog2.IsChildFriendly = false;
            dog2.IsPuppy = true;
            Dog dog3 = new Dog("Boy", "golden retriever", 10, true, true);



            cat1.DisplayAllDetails();
            cat2.DisplayAllDetails();
            cat3.DisplayAllDetails();
            dog1.DisplayAllDetails();
            dog2.DisplayAllDetails();
            dog3.DisplayAllDetails();



            shelter1.AddToShelter(cat1);
            shelter1.AddToShelter(dog1);
            shelter1.AdoptFromShelter(cat1);
            shelter1.AddToShelter(dog2);
            shelter1.AddToShelter(cat2);
            shelter1.AddToShelter(cat3);
            shelter1.AdoptFromShelter(dog3);
            shelter1.AddToShelter(dog3);


            shelter1.FreeSpaces();
            shelter1.DisplayAnimalsFromShelter();
        }
    }
}
