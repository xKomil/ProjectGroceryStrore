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
    public partial class Raport1 : Form
    {
        public Raport1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (DzieńRoboczy dzieńRoboczy in DzieńRoboczy.dniRobocze)
            {
                int sumaGodzin = 0;
                int ZaplanowaneGodziny = dzieńRoboczy.LiczbaGodzinZaplanowanych;
                foreach (PracownikDzieńRoboczy pracownikDzieńRoboczy in PracownikDzieńRoboczy.planPracy)
                {
                    if (pracownikDzieńRoboczy.DzieńRoboczy.Data == dzieńRoboczy.Data)
                    {
                        sumaGodzin += pracownikDzieńRoboczy.LiczbaGodzinPrzepracowanych;
                    }
                }
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = dzieńRoboczy.Data;
                row.Cells[1].Value = sumaGodzin;
                row.Cells[2].Value = dzieńRoboczy.LiczbaGodzinZaplanowanych;
                if (sumaGodzin == ZaplanowaneGodziny)
                {
                    row.Cells[3].Value = "Zgodna liczba godzin";
                }
                else if (sumaGodzin < ZaplanowaneGodziny)
                {
                    row.Cells[3].Value = "Niedostatek godzinowy";
                }
                else if (sumaGodzin > ZaplanowaneGodziny)
                {
                    row.Cells[3].Value = "Nadwyżka godzinowa";
                }
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
