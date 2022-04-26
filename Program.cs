using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        class Zaposleni
        {
            public string ime, prezime, jmbg;
            public void Ispis()
            {
                Console.WriteLine("Srecan rad, {0} {1}!", ime, prezime);
            }
        }

        class Profesor : Zaposleni
        {
            /*private*/
            List<string> p = new List<string>();
            public Profesor(string i, string p, string j, List<string> pr)
            {
                this.ime = i;
                this.prezime = p;
                this.jmbg = j;
                this.p = pr;
            }
            public void IspisP()
            {
                Console.WriteLine("Ime: {0} Prezime: {1} JMBG: {2}", ime, prezime, jmbg);
                foreach (string x in p)
                {
                    Console.WriteLine(x);
                }
            }
        }

        static void Main(string[] args)
        {
            Zaposleni s = new Zaposleni();
            s.ime = "Ana";
            s.prezime = "Antonic";
            s.jmbg = "097609453732";
            s.Ispis();
            List<string> l = new List<string>();
            l.Add("Matematika");
            l.Add("Fizika");
            Profesor k = new Profesor("Janko", "Ilic", "939203569826", l);
            k.IspisP();
            k.Ispis();
            Console.ReadKey();
        }
    }
}
