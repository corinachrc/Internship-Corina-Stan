using System;
using System.Collections.Generic;
using System.Linq;

namespace Week1_Ex1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> listaNumeElevi = new List<String>
            { "Mihai", "Gabriel", "Denisa", "Alina", "Viorel", "Ana","Daniela", "Alina", "Cristian", "Alina", "Daniel", "Xavier","Eugen","Alin" };

            //a. Alfabetic toate numele ce contin cel putin o data litera a.
            List<string> numeCuA = listaNumeElevi.Where(nume => nume.ToLower().Contains("a"))
                                                .OrderBy(nume=>nume)
                                                .ToList();
            Console.WriteLine("a. Numele care contin 'a' in ordine alfabetica");
            foreach (string nume in numeCuA)
            {
                Console.WriteLine(nume);
            }
            Console.WriteLine("========================");

            //b. Toate numele care au cel putin 5 litere.
            List<string> numeMaiLungiDeCinci = listaNumeElevi.Where(nume => nume.Length >= 5)
                                                            .ToList();
            Console.WriteLine("b. Nume care au cel putin 5 litere: ");
            foreach (string nume in numeMaiLungiDeCinci)
            {
                Console.WriteLine(nume);
            }
            Console.WriteLine("========================");

            //c. Numele cel mai scurt din lista.
            string numeScurt = listaNumeElevi.OrderBy(nume => nume.Length)
                                            .First();
            Console.WriteLine("c. Numele cel mai scurt din lista: "+numeScurt);
            Console.WriteLine("========================");

            //d. Numele cel mai lung din lista
            string numeLung=listaNumeElevi.OrderByDescending(nume=>nume.Length)
                                        .First();
            Console.WriteLine("d. Numele cel mai lung din lista: " + numeLung);
            Console.WriteLine("========================");

            //e. Numarul de aparitii al numelui Alina in lista data.
            int aparitiiAlina=listaNumeElevi.Where(nume=>nume=="Alina")
                                            .Count();
            Console.WriteLine("e. Numarul de aparitii al numelui Alina in lista: "+aparitiiAlina);
        }
    }
}
