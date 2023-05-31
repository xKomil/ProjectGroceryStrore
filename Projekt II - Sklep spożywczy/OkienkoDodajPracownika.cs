using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_II___Sklep_spożywczy
{
    public partial class OkienkoDodajPracownika : Form
    {
        
        public OkienkoDodajPracownika()
        {
            InitializeComponent();
            RefreshDataGridView();
        }
        private void button1_OK_Click(object sender, EventArgs e)
        {
            Pracownik nowyPracownik = new Pracownik();
            nowyPracownik.Imię = textBox1.Text;
            nowyPracownik.Nazwisko = textBox2.Text;
            nowyPracownik.DataUrodzenia = dateTimePicker1.Value;
            nowyPracownik.AdresZamieszkania = textBox3.Text;
            nowyPracownik.UrządSkarbowy = textBox4.Text;
            nowyPracownik.DataRozpoczęciaPracy = dateTimePicker2.Value;
            nowyPracownik.WysokośćStawkiGodzinowej = numericUpDown2.Value;
            nowyPracownik.TelefonKontaktowy = textBox5.Text;
            Pracownik.pracownicy.Add(nowyPracownik);
            RefreshDataGridView();

        }
        public void RefreshDataGridView()
        {
            
            dataGridView1.Rows.Clear();
            foreach (Pracownik p in Pracownik.pracownicy)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = p.Imię;
                row.Cells[1].Value = p.Nazwisko;
                row.Cells[2].Value = p.DataUrodzenia;
                row.Cells[3].Value = p.AdresZamieszkania;
                row.Cells[4].Value = p.UrządSkarbowy;
                row.Cells[5].Value = p.DataRozpoczęciaPracy;
                row.Cells[6].Value = p.WysokośćStawkiGodzinowej;
                row.Cells[7].Value = p.TelefonKontaktowy;
                row.Tag = p;
                dataGridView1.Rows.Add(row);
            }
        }

        private void button2_Wróć_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        public void button3_Edytuj_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                textBox1.Text = row.Cells["Imię"].Value.ToString();
                textBox2.Text = row.Cells["Nazwisko"].Value.ToString();
                dateTimePicker1.Value = (DateTime)row.Cells["DataUrodzenia"].Value;
                textBox3.Text = row.Cells["AdresZamieszkania"].Value.ToString();
                textBox4.Text = row.Cells["UrządSkarbowy"].Value.ToString();
                dateTimePicker2.Value = (DateTime)row.Cells["DataRozpoczęciaPracy"].Value;
                numericUpDown2.Value = (decimal)row.Cells["WysokośćStawkiGodzinowej"].Value;
                textBox5.Text = row.Cells["TelefonKontaktowy"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Zaznacz jeden wiersz ");
            }
        }

        private void button4_Usuń_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                Pracownik.pracownicy.Remove(row.Tag as Pracownik);
                dataGridView1.Rows.Remove(row);
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Zaznacz jeden wiersz do usunięcia ");
            }
        }
        private void button2_Zatwierdź_Edycję_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                row.Cells["Imię"].Value = textBox1.Text;
                row.Cells["Nazwisko"].Value = textBox2.Text;
                row.Cells["DataUrodzenia"].Value = dateTimePicker1.Value;
                row.Cells["AdresZamieszkania"].Value = textBox3.Text;
                row.Cells["UrządSkarbowy"].Value = textBox4.Text;
                row.Cells["DataRozpoczęciaPracy"].Value = dateTimePicker2.Value;
                row.Cells["WysokośćStawkiGodzinowej"].Value = numericUpDown2.Value;
                row.Cells["TelefonKontaktowy"].Value = textBox5.Text;

                // aktualizacja danych w liście pracowników
                int index = dataGridView1.Rows.IndexOf(row);
                Pracownik.pracownicy[index].Imię = textBox1.Text;
                Pracownik.pracownicy[index].Nazwisko = textBox2.Text;
                Pracownik.pracownicy[index].DataUrodzenia = dateTimePicker1.Value;
                Pracownik.pracownicy[index].AdresZamieszkania = textBox3.Text;
                Pracownik.pracownicy[index].UrządSkarbowy = textBox4.Text;
                Pracownik.pracownicy[index].DataRozpoczęciaPracy = dateTimePicker2.Value;
                Pracownik.pracownicy[index].WysokośćStawkiGodzinowej = numericUpDown2.Value;
                Pracownik.pracownicy[index].TelefonKontaktowy = textBox5.Text;

                RefreshDataGridView();
            }
            
        }

    }
}
