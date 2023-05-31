using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_II___Sklep_spożywczy
{
    public partial class Raport3 : Form
    {
        public Raport3()
        {
            InitializeComponent();


        }

        private void Wypłata_Load(object sender, EventArgs e)
        {
            foreach (Pracownik pracownik in Pracownik.pracownicy)
            {
                comboBox1.Items.Add(pracownik);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać pracownika!");
                return;
            }

            Pracownik pracownik = (Pracownik)comboBox1.SelectedItem;
            string wybranyPracownik = comboBox1.SelectedItem.ToString();
            decimal wynagrodzenie = 0;
            decimal sumaGodzin = 0;
            decimal należnośćGodzinowa = 0;
            decimal sumaGodzinDodatkowych = 0;
            decimal należnośćGodzinowaDodatkowa = 0;
            decimal sumaGodzinNieprzepracowanych = 0;
            decimal karaGodzinowa = 0;

            foreach (PracownikDzieńRoboczy prac in PracownikDzieńRoboczy.planPracy)
            {
                if (prac.Pracownik == pracownik)
                {
                    sumaGodzin += prac.LiczbaGodzinPrzepracowanych;
                    sumaGodzinDodatkowych += prac.LiczbaGodzinPrzepracowanych * pracownik.WysokośćStawkiGodzinowej;
                    if (prac.LiczbaGodzinPrzepracowanych > prac.LiczbaGodzinZaplanowanych)
                    {
                        sumaGodzinDodatkowych += (prac.LiczbaGodzinPrzepracowanych - prac.LiczbaGodzinZaplanowanych);
                        należnośćGodzinowa += (prac.LiczbaGodzinPrzepracowanych - prac.LiczbaGodzinZaplanowanych) * pracownik.WysokośćStawkiGodzinowej * 3;
                    }
                    else if (prac.LiczbaGodzinPrzepracowanych < prac.LiczbaGodzinZaplanowanych)
                    {
                        sumaGodzinNieprzepracowanych += (prac.LiczbaGodzinZaplanowanych - prac.LiczbaGodzinPrzepracowanych);
                        karaGodzinowa += (prac.LiczbaGodzinZaplanowanych - prac.LiczbaGodzinPrzepracowanych) * pracownik.WysokośćStawkiGodzinowej * 3;
                    }
                    wynagrodzenie = należnośćGodzinowa + sumaGodzinDodatkowych - karaGodzinowa;
                }
            }

            dataGridView1.Rows.Add(wybranyPracownik, sumaGodzin, sumaGodzinDodatkowych, karaGodzinowa, wynagrodzenie);
            dataGridView1.Refresh();
        }
    }
}
