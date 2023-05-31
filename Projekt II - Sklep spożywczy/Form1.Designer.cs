namespace Projekt_II___Sklep_spożywczy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1_Przejdź = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5_Przyjścia_Do_Pracy = new System.Windows.Forms.Button();
            this.button4_Dni_Robocze = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6_Raport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1_Przejdź);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pracownicy";
            // 
            // button1_Przejdź
            // 
            this.button1_Przejdź.Location = new System.Drawing.Point(0, 21);
            this.button1_Przejdź.Name = "button1_Przejdź";
            this.button1_Przejdź.Size = new System.Drawing.Size(221, 42);
            this.button1_Przejdź.TabIndex = 4;
            this.button1_Przejdź.Text = "Dodaj Pracownika";
            this.button1_Przejdź.UseVisualStyleBackColor = true;
            this.button1_Przejdź.Click += new System.EventHandler(this.button1_Przejdź_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5_Przyjścia_Do_Pracy);
            this.groupBox2.Controls.Add(this.button4_Dni_Robocze);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 129);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odniesienia";
            // 
            // button5_Przyjścia_Do_Pracy
            // 
            this.button5_Przyjścia_Do_Pracy.Location = new System.Drawing.Point(6, 81);
            this.button5_Przyjścia_Do_Pracy.Name = "button5_Przyjścia_Do_Pracy";
            this.button5_Przyjścia_Do_Pracy.Size = new System.Drawing.Size(221, 42);
            this.button5_Przyjścia_Do_Pracy.TabIndex = 4;
            this.button5_Przyjścia_Do_Pracy.Text = "Przyjścia Do Pracy";
            this.button5_Przyjścia_Do_Pracy.UseVisualStyleBackColor = true;
            this.button5_Przyjścia_Do_Pracy.Click += new System.EventHandler(this.button5_Przyjścia_Do_Pracy_Click);
            // 
            // button4_Dni_Robocze
            // 
            this.button4_Dni_Robocze.Location = new System.Drawing.Point(6, 21);
            this.button4_Dni_Robocze.Name = "button4_Dni_Robocze";
            this.button4_Dni_Robocze.Size = new System.Drawing.Size(221, 42);
            this.button4_Dni_Robocze.TabIndex = 3;
            this.button4_Dni_Robocze.Text = "Dni Robocze";
            this.button4_Dni_Robocze.UseVisualStyleBackColor = true;
            this.button4_Dni_Robocze.Click += new System.EventHandler(this.button4_Dni_Robocze_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6_Raport);
            this.groupBox3.Location = new System.Drawing.Point(12, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 70);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Raporty";
            // 
            // button6_Raport
            // 
            this.button6_Raport.Location = new System.Drawing.Point(6, 21);
            this.button6_Raport.Name = "button6_Raport";
            this.button6_Raport.Size = new System.Drawing.Size(221, 42);
            this.button6_Raport.TabIndex = 3;
            this.button6_Raport.Text = "Raporty";
            this.button6_Raport.UseVisualStyleBackColor = true;
            this.button6_Raport.Click += new System.EventHandler(this.button6_Raport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = ".sklep";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "sklep";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 307);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5_Przyjścia_Do_Pracy;
        private System.Windows.Forms.Button button4_Dni_Robocze;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6_Raport;
        private System.Windows.Forms.Button button1_Przejdź;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

