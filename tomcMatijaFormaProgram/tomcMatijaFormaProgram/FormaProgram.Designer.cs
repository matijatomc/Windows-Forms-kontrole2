namespace tomcMatijaFormaProgram
{
    partial class Form1
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
            this.grbRun = new System.Windows.Forms.GroupBox();
            this.cmbPokreni = new System.Windows.Forms.ComboBox();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.chbPrikazi = new System.Windows.Forms.CheckBox();
            this.grbKontrola = new System.Windows.Forms.GroupBox();
            this.lblImePrograma = new System.Windows.Forms.Label();
            this.txtImePrograma = new System.Windows.Forms.TextBox();
            this.lblOpisPrograma = new System.Windows.Forms.Label();
            this.txtOpisPrograma = new System.Windows.Forms.TextBox();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izađiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbRun.SuspendLayout();
            this.grbKontrola.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRun
            // 
            this.grbRun.Controls.Add(this.btnPokreni);
            this.grbRun.Controls.Add(this.cmbPokreni);
            this.grbRun.Location = new System.Drawing.Point(12, 49);
            this.grbRun.Name = "grbRun";
            this.grbRun.Size = new System.Drawing.Size(326, 115);
            this.grbRun.TabIndex = 0;
            this.grbRun.TabStop = false;
            this.grbRun.Text = "Pokreni Program";
            // 
            // cmbPokreni
            // 
            this.cmbPokreni.FormattingEnabled = true;
            this.cmbPokreni.Items.AddRange(new object[] {
            "Notepad",
            "Paint"});
            this.cmbPokreni.Location = new System.Drawing.Point(6, 43);
            this.cmbPokreni.Name = "cmbPokreni";
            this.cmbPokreni.Size = new System.Drawing.Size(155, 21);
            this.cmbPokreni.TabIndex = 0;
            this.cmbPokreni.SelectedIndexChanged += new System.EventHandler(this.cmbPokreni_SelectedIndexChanged);
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(199, 42);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(100, 21);
            this.btnPokreni.TabIndex = 1;
            this.btnPokreni.Text = "Pokreni program";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // chbPrikazi
            // 
            this.chbPrikazi.AutoSize = true;
            this.chbPrikazi.Location = new System.Drawing.Point(18, 194);
            this.chbPrikazi.Name = "chbPrikazi";
            this.chbPrikazi.Size = new System.Drawing.Size(152, 17);
            this.chbPrikazi.TabIndex = 1;
            this.chbPrikazi.Text = "Prikaži aktivnosti programa";
            this.chbPrikazi.UseVisualStyleBackColor = true;
            this.chbPrikazi.CheckedChanged += new System.EventHandler(this.chbPrikazi_CheckedChanged);
            // 
            // grbKontrola
            // 
            this.grbKontrola.Controls.Add(this.btnIzbrisi);
            this.grbKontrola.Controls.Add(this.txtOpisPrograma);
            this.grbKontrola.Controls.Add(this.lblOpisPrograma);
            this.grbKontrola.Controls.Add(this.txtImePrograma);
            this.grbKontrola.Controls.Add(this.lblImePrograma);
            this.grbKontrola.Location = new System.Drawing.Point(12, 241);
            this.grbKontrola.Name = "grbKontrola";
            this.grbKontrola.Size = new System.Drawing.Size(326, 181);
            this.grbKontrola.TabIndex = 2;
            this.grbKontrola.TabStop = false;
            this.grbKontrola.Text = "Kontrola programa";
            this.grbKontrola.Visible = false;
            // 
            // lblImePrograma
            // 
            this.lblImePrograma.AutoSize = true;
            this.lblImePrograma.Location = new System.Drawing.Point(17, 30);
            this.lblImePrograma.Name = "lblImePrograma";
            this.lblImePrograma.Size = new System.Drawing.Size(74, 13);
            this.lblImePrograma.TabIndex = 0;
            this.lblImePrograma.Text = "Ime programa:";
            // 
            // txtImePrograma
            // 
            this.txtImePrograma.Location = new System.Drawing.Point(20, 45);
            this.txtImePrograma.Name = "txtImePrograma";
            this.txtImePrograma.Size = new System.Drawing.Size(141, 20);
            this.txtImePrograma.TabIndex = 1;
            // 
            // lblOpisPrograma
            // 
            this.lblOpisPrograma.AutoSize = true;
            this.lblOpisPrograma.Location = new System.Drawing.Point(17, 79);
            this.lblOpisPrograma.Name = "lblOpisPrograma";
            this.lblOpisPrograma.Size = new System.Drawing.Size(78, 13);
            this.lblOpisPrograma.TabIndex = 2;
            this.lblOpisPrograma.Text = "Opis programa:";
            // 
            // txtOpisPrograma
            // 
            this.txtOpisPrograma.Location = new System.Drawing.Point(20, 95);
            this.txtOpisPrograma.Multiline = true;
            this.txtOpisPrograma.Name = "txtOpisPrograma";
            this.txtOpisPrograma.Size = new System.Drawing.Size(141, 71);
            this.txtOpisPrograma.TabIndex = 3;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(199, 45);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(100, 21);
            this.btnIzbrisi.TabIndex = 4;
            this.btnIzbrisi.Text = "Izbrisi";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otvoriToolStripMenuItem,
            this.spremiToolStripMenuItem,
            this.izađiToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tekstToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.opcijeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porukaToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNamaToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // otvoriToolStripMenuItem
            // 
            this.otvoriToolStripMenuItem.Name = "otvoriToolStripMenuItem";
            this.otvoriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otvoriToolStripMenuItem.Text = "Otvori";
            this.otvoriToolStripMenuItem.Click += new System.EventHandler(this.otvoriToolStripMenuItem_Click);
            // 
            // spremiToolStripMenuItem
            // 
            this.spremiToolStripMenuItem.Name = "spremiToolStripMenuItem";
            this.spremiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spremiToolStripMenuItem.Text = "Spremi";
            // 
            // izađiToolStripMenuItem
            // 
            this.izađiToolStripMenuItem.Name = "izađiToolStripMenuItem";
            this.izađiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izađiToolStripMenuItem.Text = "Izađi";
            this.izađiToolStripMenuItem.Click += new System.EventHandler(this.izađiToolStripMenuItem_Click);
            // 
            // tekstToolStripMenuItem
            // 
            this.tekstToolStripMenuItem.Name = "tekstToolStripMenuItem";
            this.tekstToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tekstToolStripMenuItem.Text = "Tekst";
            this.tekstToolStripMenuItem.Click += new System.EventHandler(this.tekstToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // opcijeToolStripMenuItem
            // 
            this.opcijeToolStripMenuItem.Name = "opcijeToolStripMenuItem";
            this.opcijeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opcijeToolStripMenuItem.Text = "Opcije";
            // 
            // porukaToolStripMenuItem
            // 
            this.porukaToolStripMenuItem.Name = "porukaToolStripMenuItem";
            this.porukaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porukaToolStripMenuItem.Text = "Poruka";
            this.porukaToolStripMenuItem.Click += new System.EventHandler(this.porukaToolStripMenuItem_Click);
            // 
            // oNamaToolStripMenuItem
            // 
            this.oNamaToolStripMenuItem.Name = "oNamaToolStripMenuItem";
            this.oNamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oNamaToolStripMenuItem.Text = "O nama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 496);
            this.Controls.Add(this.grbKontrola);
            this.Controls.Add(this.chbPrikazi);
            this.Controls.Add(this.grbRun);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Program";
            this.grbRun.ResumeLayout(false);
            this.grbKontrola.ResumeLayout(false);
            this.grbKontrola.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRun;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.ComboBox cmbPokreni;
        private System.Windows.Forms.CheckBox chbPrikazi;
        private System.Windows.Forms.GroupBox grbKontrola;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.TextBox txtOpisPrograma;
        private System.Windows.Forms.Label lblOpisPrograma;
        private System.Windows.Forms.TextBox txtImePrograma;
        private System.Windows.Forms.Label lblImePrograma;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izađiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNamaToolStripMenuItem;
    }
}

