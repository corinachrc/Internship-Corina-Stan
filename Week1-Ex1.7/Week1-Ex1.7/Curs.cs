using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Ex1._7
{
    public class Curs
    {
        public string DenumireCurs {  get; set; }
        public int DurataCurs {  get; set; }

        public Profesor Profesor { get; set; }
        private Dictionary<Student,int> Students =new Dictionary<Student,int>();

        public int NumarLocuri { get; set; }

        public Dictionary<Student,int> AdaugaStudent(params Student[] student)
        {
            if ((NumarLocuri > 0) && Students!=null)
            {
                foreach (Student st in student)
                {
                    if (Students.Count < NumarLocuri)
                    {
                        Students.Add(st, 0);
                        Console.WriteLine("Studentul " + st.Nume + " " + st.Prenume +" a fost adaugat!");
                    }
                    else
                    {
                        Console.WriteLine("! ! ! Nu mai sunt locuri disponibile la acest curs! Studentul "+st.Nume+" "+st.Prenume+" nu a putut fi adaugat.");

                    }
                    Console.WriteLine();
                }
            }
            
            return Students;
        }

        public Dictionary<Student,int> ModificaNota(Student student,int nota)
        {
            
            if (Students.Keys.Contains(student))
            {
                Students[student]   = nota;
                Console.WriteLine("Ati modificat nota studentului "+student);
            }
            else
            {
                Console.WriteLine("! ! ! Ati incercat sa modificati nota studentului " + student.Nume + " " + student.Prenume + " , dar acesta nu este inscris la curs!!");
            }
            Console.WriteLine();
            return Students;
        }

        public int AfiseazaNota(Student st)
        {
            int nota = Students[st];
            return nota;
        }

        public void AfiseazaDetaliiCurs()
        {
            Console.WriteLine("Denumire curs: "+DenumireCurs+"\t "+NumarLocuri+" locuri");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("\tProfesor: "+Profesor.ToString());
            Console.WriteLine("Studenti: ");
            foreach(Student student in Students.Keys)
            {
                Console.WriteLine("\t"+student.Nume+" "+student.Prenume+" "+Students[student]);
            }
        }


    }
}
