using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_zad1_w62952
{
    public class Student
    {
        public string imie { get; set; }

        public string nazwisko { get; set; }

        public int NrIndeksu { get; set; }

        public string wydział { get; set; }

        public Student(string imie, string nazwisko, int NrIndeksu, string wydział)
        {
            //NrIndeksu = Convert.ToString(NrIndeksu);
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.NrIndeksu = NrIndeksu;
            this.wydział = wydział;
        }

        public Student()
            : this("", "", 0, "")
        { }

    }

}
