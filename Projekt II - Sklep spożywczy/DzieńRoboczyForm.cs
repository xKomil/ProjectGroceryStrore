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
    public partial class DzieńRoboczyForm : Form
    {
        
        public DzieńRoboczyForm()
        {
            InitializeComponent();
            refreshDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DzieńRoboczy dzieńRoboczy = new DzieńRoboczy();
            dzieńRoboczy.LiczbaGodzinZaplanowanych = Convert.ToInt32(numericUpDown1.Value);
            dzieńRoboczy.Data = monthCalendar1.SelectionStart;
            DzieńRoboczy.dniRobocze.Add(dzieńRoboczy);
            refreshDataGridView();
        }

        public void refreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (DzieńRoboczy d in DzieńRoboczy.dniRobocze)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = d.Data;
                row.Cells[1].Value = d.LiczbaGodzinZaplanowanych;
                row.Tag = d;
                dataGridView1.Rows.Add(row);
            }
        }

        private void button1_Edytuj_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                numericUpDown1.Value = (int)row.Cells["ZaplanowanaLiczbaGodzin"].Value;
                DateTime data = DateTime.Parse(row.Cells["Data"].Value.ToString());
                monthCalendar1.SetDate(data);
            }
            else
            {
                MessageBox.Show("Wybierz jeden wiersz ");
            }
        }

        

        private void button3_Usuń_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                DzieńRoboczy.dniRobocze.Remove(row.Tag as DzieńRoboczy);
                dataGridView1.Rows.Remove(row);
                refreshDataGridView();
            }
            else
            {
                MessageBox.Show("Zaznacz jeden wiersz do usunięcia ");
            }


        }

        private void button1_Zatwierdź_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int index = dataGridView1.Rows.IndexOf(row);
                DzieńRoboczy.dniRobocze[index].LiczbaGodzinZaplanowanych = Convert.ToInt32(numericUpDown1.Value);
                DzieńRoboczy.dniRobocze[index].Data = monthCalendar1.SelectionStart;
                refreshDataGridView();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
