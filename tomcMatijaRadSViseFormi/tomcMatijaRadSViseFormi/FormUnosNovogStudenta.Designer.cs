namespace tomcMatijaRadSViseFormi
{
    partial class FormUnosNovogStudenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIndeks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSmjer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(12, 25);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(249, 20);
            this.textBoxIme.TabIndex = 1;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(12, 80);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(249, 20);
            this.textBoxPrezime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // textBoxIndeks
            // 
            this.textBoxIndeks.Location = new System.Drawing.Point(331, 25);
            this.textBoxIndeks.Name = "textBoxIndeks";
            this.textBoxIndeks.Size = new System.Drawing.Size(249, 20);
            this.textBoxIndeks.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj indeksa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Smjer:";
            // 
            // comboBoxSmjer
            // 
            this.comboBoxSmjer.FormattingEnabled = true;
            this.comboBoxSmjer.Items.AddRange(new object[] {
            "Programer",
            "Sistem administrator",
            "Mrežni administrator"});
            this.comboBoxSmjer.Location = new System.Drawing.Point(12, 135);
            this.comboBoxSmjer.Name = "comboBoxSmjer";
            this.comboBoxSmjer.Size = new System.Drawing.Size(249, 21);
            this.comboBoxSmjer.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum rodjenja:";
            // 
            // dateTimePickerDatumRodjenja
            // 
            this.dateTimePickerDatumRodjenja.Location = new System.Drawing.Point(331, 80);
            this.dateTimePickerDatumRodjenja.Name = "dateTimePickerDatumRodjenja";
            this.dateTimePickerDatumRodjenja.Size = new System.Drawing.Size(249, 20);
            this.dateTimePickerDatumRodjenja.TabIndex = 9;
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(12, 180);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(64, 23);
            this.buttonSpremi.TabIndex = 10;
            this.buttonSpremi.Text = "Snimi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Location = new System.Drawing.Point(516, 180);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(64, 23);
            this.buttonOtkazi.TabIndex = 11;
            this.buttonOtkazi.Text = "Otkaži";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // FormUnosNovogStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 219);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonSpremi);
            this.Controls.Add(this.dateTimePickerDatumRodjenja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxSmjer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIndeks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label1);
            this.Name = "FormUnosNovogStudenta";
            this.Text = "Unos Novog Studenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIndeks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSmjer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumRodjenja;
        private System.Windows.Forms.Button buttonSpremi;
        private System.Windows.Forms.Button buttonOtkazi;
    }
}