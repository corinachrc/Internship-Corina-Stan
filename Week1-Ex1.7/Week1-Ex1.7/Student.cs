using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Ex1._7
{
    public class Student: Persoana
    {
        

        public Student() { }
        public Student(string nume, string prenume, string cnp):base(nume,prenume,cnp) { }

        public override string ToString()
        {
            return this.Nume + " " + this.Prenume + " " + this.CNP;
        }
    }
}
