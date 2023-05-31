using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_II___Sklep_spożywczy
{
    public partial class Raporty : Form
    {
        public Raporty()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Raport1 godzinyPracyCzyPrawidlowe = new Raport1();
            godzinyPracyCzyPrawidlowe.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Raport2 pracownikNiezgodnaLiczbaGodzin = new Raport2();
            pracownikNiezgodnaLiczbaGodzin.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Raport3 wypłata = new Raport3();
            wypłata.ShowDialog();
        }
    }
}
