using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_II___Sklep_spożywczy
{
    [Serializable]
    internal class DzieńRoboczy
    {
        internal static List<DzieńRoboczy> dniRobocze = new List<DzieńRoboczy>();
        internal DateTime Data { get; set; }
        internal int LiczbaGodzin { get; set; }
        internal int LiczbaGodzinZaplanowanych { get; set; }

        public override string ToString()
        {
            return $"{Data.ToShortDateString()} ({LiczbaGodzinZaplanowanych}h)";
        }

    }
}
