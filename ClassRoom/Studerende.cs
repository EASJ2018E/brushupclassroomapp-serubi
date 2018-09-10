using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        private string _navn;
        private int _fødselsmåned;
        private int _fødselsdag;

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            _navn = navn;
            _fødselsmåned = fødselsmåned;
            _fødselsdag = fødselsdag;
        }

        public string årstid()
        {
            switch (_fødselsmåned)
            {
                case 12: case 1: case 2:
                    return "Vinter";
                    break;
                case 3: case 4: case 5:
                    return "Forår";
                    break;
                case 6: case 7: case 8:
                    return "Sommer";
                    break;
                case 9: case 10: case 11:
                    return "Efterår";
                    break;
                default:
                    return "Unknown";
                    break;
            }
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public int Fødselsmåned
        {
            get { return _fødselsmåned; }
            set { _fødselsmåned = value; }
        }

        public int Fødselsdag
        {
            get { return _fødselsdag; }
            set { _fødselsdag = value; }
        }
    }
}
