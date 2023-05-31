namespace Projekt_II___Sklep_spożywczy
{
    partial class DzieńRoboczyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1_Dodaj = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1_Zaplanowana_Liczba_Godzin_Roboczych = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZaplanowanaLiczbaGodzin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1_Edytuj = new System.Windows.Forms.Button();
            this.button3_Usuń = new System.Windows.Forms.Button();
            this.button1_Zatwierdź = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_Dodaj
            // 
            this.button1_Dodaj.Location = new System.Drawing.Point(18, 290);
            this.button1_Dodaj.Name = "button1_Dodaj";
            this.button1_Dodaj.Size = new System.Drawing.Size(350, 32);
            this.button1_Dodaj.TabIndex = 0;
            this.button1_Dodaj.Text = "Dodaj";
            this.button1_Dodaj.UseVisualStyleBackColor = true;
            this.button1_Dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(19, 253);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(349, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // label1_Zaplanowana_Liczba_Godzin_Roboczych
            // 
            this.label1_Zaplanowana_Liczba_Godzin_Roboczych.AutoSize = true;
            this.label1_Zaplanowana_Liczba_Godzin_Roboczych.Location = new System.Drawing.Point(56, 234);
            this.label1_Zaplanowana_Liczba_Godzin_Roboczych.Name = "label1_Zaplanowana_Liczba_Godzin_Roboczych";
            this.label1_Zaplanowana_Liczba_Godzin_Roboczych.Size = new System.Drawing.Size(247, 16);
            this.label1_Zaplanowana_Liczba_Godzin_Roboczych.TabIndex = 3;
            this.label1_Zaplanowana_Liczba_Godzin_Roboczych.Text = "Zaplanowana Liczba Godzin Roboczych";
            this.label1_Zaplanowana_Liczba_Godzin_Roboczych.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.ZaplanowanaLiczbaGodzin});
            this.dataGridView1.Location = new System.Drawing.Point(392, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(338, 452);
            this.dataGridView1.TabIndex = 4;
            // 
            // Data
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.Width = 125;
            // 
            // ZaplanowanaLiczbaGodzin
            // 
            this.ZaplanowanaLiczbaGodzin.HeaderText = "Zaplanowana Liczba Godzin";
            this.ZaplanowanaLiczbaGodzin.MinimumWidth = 6;
            this.ZaplanowanaLiczbaGodzin.Name = "ZaplanowanaLiczbaGodzin";
            this.ZaplanowanaLiczbaGodzin.Width = 125;
            // 
            // button1_Edytuj
            // 
            this.button1_Edytuj.Location = new System.Drawing.Point(19, 342);
            this.button1_Edytuj.Name = "button1_Edytuj";
            this.button1_Edytuj.Size = new System.Drawing.Size(156, 36);
            this.button1_Edytuj.TabIndex = 5;
            this.button1_Edytuj.Text = "Edytuj";
            this.button1_Edytuj.UseVisualStyleBackColor = true;
            this.button1_Edytuj.Click += new System.EventHandler(this.button1_Edytuj_Click);
            // 
            // button3_Usuń
            // 
            this.button3_Usuń.Location = new System.Drawing.Point(19, 391);
            this.button3_Usuń.Name = "button3_Usuń";
            this.button3_Usuń.Size = new System.Drawing.Size(349, 32);
            this.button3_Usuń.TabIndex = 7;
            this.button3_Usuń.Text = "Usuń";
            this.button3_Usuń.UseVisualStyleBackColor = true;
            this.button3_Usuń.Click += new System.EventHandler(this.button3_Usuń_Click);
            // 
            // button1_Zatwierdź
            // 
            this.button1_Zatwierdź.Location = new System.Drawing.Point(212, 342);
            this.button1_Zatwierdź.Name = "button1_Zatwierdź";
            this.button1_Zatwierdź.Size = new System.Drawing.Size(156, 36);
            this.button1_Zatwierdź.TabIndex = 8;
            this.button1_Zatwierdź.Text = "Zatwierdź";
            this.button1_Zatwierdź.UseVisualStyleBackColor = true;
            this.button1_Zatwierdź.Click += new System.EventHandler(this.button1_Zatwierdź_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DzieńRoboczyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button1_Zatwierdź);
            this.Controls.Add(this.button3_Usuń);
            this.Controls.Add(this.button1_Edytuj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1_Zaplanowana_Liczba_Godzin_Roboczych);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1_Dodaj);
            this.Name = "DzieńRoboczyForm";
            this.Text = "DzieńRoboczyForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Dodaj;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1_Zaplanowana_Liczba_Godzin_Roboczych;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1_Edytuj;
        private System.Windows.Forms.Button button3_Usuń;
        private System.Windows.Forms.Button button1_Zatwierdź;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaplanowanaLiczbaGodzin;
        private System.Windows.Forms.Button button1;
    }
}