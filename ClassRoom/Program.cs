using System;
using System.Collections.Generic;
using System.Globalization;
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
            students.Add(new Studerende("Thomas", 11, 14));
            students.Add(new Studerende("Rasmus", 7, 16));

            klasse.Klasseliste = students;

            Console.WriteLine($"Navn: {klasse.KlasseNavn}");
            Console.WriteLine($"Semesterstart: {klasse.SemesterStart.ToString()}");
            Console.WriteLine();
            Console.WriteLine("Students:");

            foreach (Studerende student in klasse.Klasseliste)
            {
                Console.WriteLine($"Navn: {student.Navn}, Fødselsdag: {student.Fødselsdag}. {new DateTime(2018, student.Fødselsmåned, 1).ToString("MMM", CultureInfo.CreateSpecificCulture("da")) }, Årstid: {student.Årstid()}");
            }

            Console.WriteLine();

            klasse.FødselÅrstid();

            Console.WriteLine();
        }
    }
}
