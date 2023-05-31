using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_II___Sklep_spożywczy
{
    [Serializable]
    internal class PracownikDzieńRoboczy
    {
        internal static List<PracownikDzieńRoboczy> planPracy = new List<PracownikDzieńRoboczy>();
        internal DzieńRoboczy DzieńRoboczy { get; set; }
        internal Pracownik Pracownik { get; set; }
        internal int LiczbaGodzinZaplanowanych { get; set; }
        internal int LiczbaGodzinPrzepracowanych { get; set; }
    }
}  
