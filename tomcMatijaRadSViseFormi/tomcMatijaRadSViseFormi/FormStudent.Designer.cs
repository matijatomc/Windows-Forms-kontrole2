namespace tomcMatijaRadSViseFormi
{
    partial class FormStudent
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
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.listBoxStudenti = new System.Windows.Forms.ListBox();
            this.buttonObrisiSve = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(12, 12);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(146, 31);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj novog studenta";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // listBoxStudenti
            // 
            this.listBoxStudenti.FormattingEnabled = true;
            this.listBoxStudenti.Location = new System.Drawing.Point(12, 66);
            this.listBoxStudenti.Name = "listBoxStudenti";
            this.listBoxStudenti.Size = new System.Drawing.Size(470, 264);
            this.listBoxStudenti.TabIndex = 1;
            // 
            // buttonObrisiSve
            // 
            this.buttonObrisiSve.Location = new System.Drawing.Point(12, 359);
            this.buttonObrisiSve.Name = "buttonObrisiSve";
            this.buttonObrisiSve.Size = new System.Drawing.Size(146, 31);
            this.buttonObrisiSve.TabIndex = 2;
            this.buttonObrisiSve.Text = "Obriši sve studente";
            this.buttonObrisiSve.UseVisualStyleBackColor = true;
            this.buttonObrisiSve.Click += new System.EventHandler(this.buttonObrisiSve_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(540, 171);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(146, 29);
            this.buttonObrisi.TabIndex = 3;
            this.buttonObrisi.Text = "Obriši studenta";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonObrisiSve);
            this.Controls.Add(this.listBoxStudenti);
            this.Controls.Add(this.buttonDodaj);
            this.Name = "FormStudent";
            this.Text = "Studenti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.ListBox listBoxStudenti;
        private System.Windows.Forms.Button buttonObrisiSve;
        private System.Windows.Forms.Button buttonObrisi;
    }
}

