using System;

namespace Week1_Ex1._7
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Profesor prof1= new Profesor("Popescu","Andrei", "18765432");
           

            Student student1= new Student("Chiriac","Corina", "284678021");
            Student student2 = new Student("Stan", "Mihai", "1997362");
            Student student3 = new Student("Chirila", "Daniela", "67020745");
            Student student4 = new Student("Barbu", "Bianca", "2810204746");
            Student student5 = new Student("Ionescu", "Gabriel", "5272023746");

            Curs curs1= new Curs();
            curs1.DurataCurs = 2;
            curs1.DenumireCurs = "Matematici speciale";
            curs1.NumarLocuri = 3;
            curs1.Profesor = prof1;
            curs1.AdaugaStudent(student1);
            curs1.AdaugaStudent(student2,student3,student4);
            curs1.AfiseazaDetaliiCurs();

            curs1.ModificaNota(student2, 10);
            curs1.ModificaNota(student1 , 10);
            curs1.ModificaNota(student4, 8);
            curs1.AfiseazaDetaliiCurs();

            Console.WriteLine(student1);

        }
    }
}
