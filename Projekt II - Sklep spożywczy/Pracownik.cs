using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_II___Sklep_spożywczy
{
    [Serializable]
    internal class Pracownik
    {
        internal static List<Pracownik> pracownicy = new List<Pracownik>();
        internal string Imię { get; set; }
        internal string Nazwisko { get; set; }
        internal DateTime DataUrodzenia { get; set; }
        internal string AdresZamieszkania { get; set; }
        internal string UrządSkarbowy { get; set; }
        internal DateTime DataRozpoczęciaPracy { get; set; }
        internal decimal WysokośćStawkiGodzinowej { get; set; }
        internal string TelefonKontaktowy { get; set; }

        public override string ToString()
        {
            return Imię + " " + Nazwisko;
        }

        static public bool operator ==(Pracownik right, Pracownik left)
        {
            return left.Imię == right.Imię && left.Nazwisko == right.Nazwisko;
        }
        static public bool operator !=(Pracownik right, Pracownik left)
        {
            return !(left == right);
        }
        
    }
}
