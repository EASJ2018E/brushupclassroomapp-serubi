using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        private string _klasseNavn;
        private List<Studerende> _klasseliste;
        private DateTime _semesterstart;

        public KlasseRum()
        {
            
        }

        public KlasseRum(string KlasseNavn, List<Studerende> Klasseliste, DateTime SemesterStart)
        {
            _klasseNavn = KlasseNavn;
            _klasseliste = Klasseliste;
            _semesterstart = SemesterStart;
        }

        public void FødselÅrstid()
        {
            int studentForår = _klasseliste.Where(s => s.Årstid() == "Forår").Select(s => s).Distinct().Count();
            int studentSommer = _klasseliste.Where(s => s.Årstid() == "Sommer").Select(s => s).Distinct().Count();
            int studentEfterår = _klasseliste.Where(s => s.Årstid() == "Efterår").Select(s => s).Distinct().Count();
            int studentVinter = _klasseliste.Where(s => s.Årstid() == "Vinter").Select(s => s).Distinct().Count();
            Console.WriteLine("Fødselsdag i hver årstid:");
            Console.WriteLine($"Forår: {studentForår}");
            Console.WriteLine($"Sommer: {studentSommer}");
            Console.WriteLine($"Efterår: {studentEfterår}");
            Console.WriteLine($"Vinter: {studentVinter}");
        }

        public string KlasseNavn
        {
            get { return _klasseNavn; }
            set { _klasseNavn = value; }
        }

        public List<Studerende> Klasseliste
        {
            get { return _klasseliste; }
            set { _klasseliste = value; }
        }

        public DateTime SemesterStart
        {
            get { return _semesterstart; }
            set { _semesterstart = value; }
        }
    }
}
