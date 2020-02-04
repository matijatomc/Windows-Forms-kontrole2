namespace tomcMatijaFormaProgram
{
    partial class Text
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
            this.grbKontrola = new System.Windows.Forms.GroupBox();
            this.txtOpisPrograma = new System.Windows.Forms.TextBox();
            this.lblOpisPrograma = new System.Windows.Forms.Label();
            this.txtImePrograma = new System.Windows.Forms.TextBox();
            this.lblImePrograma = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.grbKontrola.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKontrola
            // 
            this.grbKontrola.Controls.Add(this.txtOpisPrograma);
            this.grbKontrola.Controls.Add(this.lblOpisPrograma);
            this.grbKontrola.Controls.Add(this.txtImePrograma);
            this.grbKontrola.Controls.Add(this.lblImePrograma);
            this.grbKontrola.Location = new System.Drawing.Point(27, 29);
            this.grbKontrola.Name = "grbKontrola";
            this.grbKontrola.Size = new System.Drawing.Size(326, 181);
            this.grbKontrola.TabIndex = 3;
            this.grbKontrola.TabStop = false;
            this.grbKontrola.Text = "Kontrola programa";
            // 
            // txtOpisPrograma
            // 
            this.txtOpisPrograma.Location = new System.Drawing.Point(112, 76);
            this.txtOpisPrograma.Multiline = true;
            this.txtOpisPrograma.Name = "txtOpisPrograma";
            this.txtOpisPrograma.Size = new System.Drawing.Size(141, 71);
            this.txtOpisPrograma.TabIndex = 3;
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
            // txtImePrograma
            // 
            this.txtImePrograma.Location = new System.Drawing.Point(112, 27);
            this.txtImePrograma.Name = "txtImePrograma";
            this.txtImePrograma.Size = new System.Drawing.Size(141, 20);
            this.txtImePrograma.TabIndex = 1;
            this.txtImePrograma.TextChanged += new System.EventHandler(this.txtImePrograma_TextChanged);
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
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(27, 235);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 21);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(253, 235);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 21);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 283);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grbKontrola);
            this.Name = "Text";
            this.Text = "Text";
            this.grbKontrola.ResumeLayout(false);
            this.grbKontrola.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKontrola;
        private System.Windows.Forms.TextBox txtOpisPrograma;
        private System.Windows.Forms.Label lblOpisPrograma;
        private System.Windows.Forms.TextBox txtImePrograma;
        private System.Windows.Forms.Label lblImePrograma;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnOdustani;
    }
}