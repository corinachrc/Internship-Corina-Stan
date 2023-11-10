namespace Week1_Ex2._1
{
    internal class Animal
    {
    
            private static int ids;
            public int Id { get; set; }
            public string Name { get; set; }
            public string Breed { get; set; }
            public double Weight { get; set; }

            public Animal()
            {
                this.Id = System.Threading.Interlocked.Increment(ref ids);
            }
            public Animal(string name, string breed, double weight)
            {
                this.Id = System.Threading.Interlocked.Increment(ref ids);
                this.Name = name;
                this.Breed = breed;
                this.Weight = weight;
            }






        }
    }


