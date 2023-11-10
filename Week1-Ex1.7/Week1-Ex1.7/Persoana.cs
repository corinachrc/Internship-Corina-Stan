using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Ex1._7
{
    public abstract class Persoana
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get
                ; set; }

        public Persoana() { }
        public Persoana(string nume, string prenume, string cnp)
        {
            Nume = nume;
            Prenume = prenume;                
            CNP = cnp;
        }

        public override string ToString()
        {
            return this.Nume+" "+this.Prenume;
        }
    }
}
