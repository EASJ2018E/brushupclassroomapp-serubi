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
