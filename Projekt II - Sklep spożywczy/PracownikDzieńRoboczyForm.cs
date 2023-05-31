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
    public partial class PracownikDzieńRoboczyForm : Form
    {

        public PracownikDzieńRoboczyForm()
        {
            InitializeComponent();
            RefreshDataGridView();

            foreach (Pracownik p in Pracownik.pracownicy)
            {
                comboBox2.Items.Add(p);
            }

            foreach (DzieńRoboczy d in DzieńRoboczy.dniRobocze)
            {
                comboBox3.Items.Add(d);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać pracownika!");
                return;
            }

            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać dzień roboczy!");
                return;
            }

            PracownikDzieńRoboczy pracownikDzieńRoboczy = new PracownikDzieńRoboczy();
            pracownikDzieńRoboczy.Pracownik = (Pracownik)comboBox2.SelectedItem;
            pracownikDzieńRoboczy.DzieńRoboczy = (DzieńRoboczy)comboBox3.SelectedItem;
            pracownikDzieńRoboczy.LiczbaGodzinZaplanowanych = (int)numericUpDown1.Value;
            pracownikDzieńRoboczy.LiczbaGodzinPrzepracowanych = (int)numericUpDown2.Value;
            PracownikDzieńRoboczy.planPracy.Add(pracownikDzieńRoboczy);
            RefreshDataGridView();
        }

        void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach(PracownikDzieńRoboczy p in PracownikDzieńRoboczy.planPracy) 
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = p.Pracownik;
                row.Cells[1].Value = p.DzieńRoboczy;
                row.Cells[2].Value = p.LiczbaGodzinZaplanowanych;
                row.Cells[3].Value = p.LiczbaGodzinPrzepracowanych;
                row.Tag = p;
                dataGridView1.Rows.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Zaznacz jeden wiersz ");
                return;
            }
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            comboBox2.SelectedItem = row.Cells[0].Value.ToString();
            comboBox3.SelectedItem = row.Cells[1].Value.ToString();
            numericUpDown1.Value = (int)row.Cells[2].Value;
            numericUpDown2.Value = (int)row.Cells[3].Value;
            RefreshDataGridView();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                row.Cells[0].Value = comboBox2.SelectedItem;
                row.Cells[1].Value = comboBox3.SelectedItem;
                row.Cells[2].Value = numericUpDown1.Value;
                row.Cells[3].Value = numericUpDown2.Value;
                int ind = dataGridView1.Rows.IndexOf(row);
                PracownikDzieńRoboczy.planPracy[ind].Pracownik = (Pracownik)comboBox2.SelectedItem;
                PracownikDzieńRoboczy.planPracy[ind].DzieńRoboczy = (DzieńRoboczy)comboBox3.SelectedItem;
                PracownikDzieńRoboczy.planPracy[ind].LiczbaGodzinZaplanowanych = (int)numericUpDown1.Value;
                PracownikDzieńRoboczy.planPracy[ind].LiczbaGodzinPrzepracowanych = (int)numericUpDown2.Value;
                RefreshDataGridView();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 1) 
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                PracownikDzieńRoboczy.planPracy.Remove(row.Tag as PracownikDzieńRoboczy);
                dataGridView1.Rows.Remove(row);
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Zaznacz jeden wiersz do usunięcia ");
            }
        }
    }
}
