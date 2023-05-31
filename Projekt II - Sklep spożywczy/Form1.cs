using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_II___Sklep_spożywczy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Przejdź_Click(object sender, EventArgs e)
        {
            OkienkoDodajPracownika okienkoDodajPracownika = new OkienkoDodajPracownika();
            okienkoDodajPracownika.ShowDialog();
        }

        private void button4_Dni_Robocze_Click(object sender, EventArgs e)
        {
            DzieńRoboczyForm dzienRoboczyForm = new DzieńRoboczyForm();
            dzienRoboczyForm.ShowDialog();
        }

        private void button5_Przyjścia_Do_Pracy_Click(object sender, EventArgs e)
        {
            PracownikDzieńRoboczyForm pracownikDzieńRoboczyForm = new PracownikDzieńRoboczyForm();
            pracownikDzieńRoboczyForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                if (openFileDialog1.ShowDialog() != DialogResult.OK)
                    return;

                using (Stream stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    Pracownik.pracownicy = (List<Pracownik>)formatter.Deserialize(stream);
                    PracownikDzieńRoboczy.planPracy = (List<PracownikDzieńRoboczy>)formatter.Deserialize(stream);
                    DzieńRoboczy.dniRobocze = (List<DzieńRoboczy>)formatter.Deserialize(stream);
                }

                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Raport_Click(object sender, EventArgs e)
        {
            Raporty raporty = new Raporty();
            raporty.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Czy zapisać dane przed opuszczeniem aplikacji?", "Zamykanie aplikacji", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.No)
                    return;
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }

                IFormatter formatter = new BinaryFormatter();
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    e.Cancel = true;
                    return;
                }

                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, Pracownik.pracownicy);
                    formatter.Serialize(stream, PracownikDzieńRoboczy.planPracy);
                    formatter.Serialize(stream, DzieńRoboczy.dniRobocze);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                e.Cancel = true;
            }
        }
    }
}
