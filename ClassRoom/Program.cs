using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum klasse = new KlasseRum();

            klasse.KlasseNavn = "3B";
            klasse.SemesterStart = DateTime.Parse("4-9-2018");
            
            List<Studerende> students = new List<Studerende>();
            students.Add(new Studerende("Lucas", 9, 7));
            students.Add(new Studerende("Rasmus", 7, 16));

            klasse.Klasseliste = students;
        }
    }
}
