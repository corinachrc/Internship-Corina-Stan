using System;
using System.Collections.Generic;

namespace Week1_Ex2._1
{
    internal class Shelter
    {
        
            public string Name { get; set; }
            public string Adress { get; set; }
            public int NumberOfPlaces { get; set; }

            private List<Animal> _listOfAnimals = new List<Animal>();

            public Shelter() { }

            public List<Animal> AddToShelter(Animal animal)
            {
                Console.WriteLine("==================================");
                if (_listOfAnimals.Count < NumberOfPlaces)
                {
                    _listOfAnimals.Add(animal);
                    Console.WriteLine(animal.Name + " was placed in shelter.");
                    return _listOfAnimals;
                }
                else
                {
                    Console.WriteLine("There are no more free rooms for " + animal.Name);
                    return _listOfAnimals;
                }
            }
            public List<Animal> AdoptFromShelter(Animal animal)
            {
                if (_listOfAnimals.Contains(animal))
                {
                    Console.WriteLine("==================================");
                    _listOfAnimals.Remove(animal);
                    Console.WriteLine(animal.Name + " was adopted");
                }
                else
                {
                    Console.WriteLine("==================================");
                    Console.WriteLine("The pet you requested is not available in shelter " + Name);
                }
                return _listOfAnimals;
            }

            public void FreeSpaces()
            {
                Console.WriteLine("==================================");
                int occupied = _listOfAnimals.Count;
                int free = NumberOfPlaces - occupied;
                if (free > 0)

                {

                    Console.WriteLine("In shelter " + Name + " there are " + free + " free spaces from " + NumberOfPlaces + " (total)");
                }
                else
                {
                    Console.WriteLine("The shelter if full!!");
                }
            }

            public void DisplayAnimalsFromShelter()
            {
                Console.WriteLine("==================================");
                Console.WriteLine("Animals in shelter " + Name);
                foreach (Animal animal in _listOfAnimals)
                {
                    if (animal.GetType() == typeof(Dog))
                    {
                        Console.WriteLine("Dog: ID " + animal.Id + ", " + animal.Name);
                    }
                    else if (animal.GetType() == typeof(Cat))
                    {
                        Console.WriteLine("Cat: ID " + animal.Id + ", " + animal.Name);
                    }
                }
            }
        }
    }


