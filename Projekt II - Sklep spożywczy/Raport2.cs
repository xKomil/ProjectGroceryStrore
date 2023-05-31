using System;
using System.Windows.Forms;

namespace Projekt_II___Sklep_spożywczy
{
    public partial class Raport2 : Form
    {
        public Raport2()
        {
            InitializeComponent();
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

            Pracownik p = comboBox1.SelectedItem as Pracownik;
            int liczbaBrakujacychDni = 0;
            int liczbaDodatkowychDni = 0;
            int liczbaBrakujacychGodzin = 0;
            int liczbaDodatkowychGodzin = 0;

            foreach (PracownikDzieńRoboczy pr in PracownikDzieńRoboczy.planPracy)
            {
                if (pr.Pracownik == p)
                {
                    int liczbaZaplanowanychGodzin = pr.DzieńRoboczy.LiczbaGodzinZaplanowanych;
                    int liczbaPrzepracowanychGodzin = pr.LiczbaGodzinPrzepracowanych;
                    if (liczbaPrzepracowanychGodzin < liczbaZaplanowanychGodzin)
                    {
                        liczbaBrakujacychDni++;
                        liczbaBrakujacychGodzin += liczbaZaplanowanychGodzin - liczbaPrzepracowanychGodzin;
                    }
                    else if (liczbaPrzepracowanychGodzin > liczbaZaplanowanychGodzin)
                    {
                        liczbaDodatkowychDni++;
                        liczbaDodatkowychGodzin += liczbaPrzepracowanychGodzin - liczbaZaplanowanychGodzin;
                    }
                }
            }

            dataGridView1.Rows.Add(p, liczbaBrakujacychDni, liczbaBrakujacychGodzin, liczbaDodatkowychDni, liczbaDodatkowychGodzin);
        }

        private void PracownikNiezgodnaLiczbaGodzin_Load(object sender, EventArgs e)
        {
            foreach (Pracownik p in Pracownik.pracownicy)
            {
                comboBox1.Items.Add(p);
            }
        }
        

    }
}
