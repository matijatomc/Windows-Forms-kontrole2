namespace tomcMatijaKlasaProcess
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
            this.buttonExplorer = new System.Windows.Forms.Button();
            this.buttonStartInfo = new System.Windows.Forms.Button();
            this.buttonWord = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExplorer
            // 
            this.buttonExplorer.Location = new System.Drawing.Point(52, 59);
            this.buttonExplorer.Name = "buttonExplorer";
            this.buttonExplorer.Size = new System.Drawing.Size(150, 41);
            this.buttonExplorer.TabIndex = 0;
            this.buttonExplorer.Text = "Pokreni Internet Explorer";
            this.buttonExplorer.UseVisualStyleBackColor = true;
            this.buttonExplorer.Click += new System.EventHandler(this.buttonExplorer_Click);
            // 
            // buttonStartInfo
            // 
            this.buttonStartInfo.Location = new System.Drawing.Point(237, 124);
            this.buttonStartInfo.Name = "buttonStartInfo";
            this.buttonStartInfo.Size = new System.Drawing.Size(150, 41);
            this.buttonStartInfo.TabIndex = 1;
            this.buttonStartInfo.Text = "Start info";
            this.buttonStartInfo.UseVisualStyleBackColor = true;
            this.buttonStartInfo.Click += new System.EventHandler(this.buttonStartInfo_Click);
            // 
            // buttonWord
            // 
            this.buttonWord.Location = new System.Drawing.Point(52, 124);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(150, 41);
            this.buttonWord.TabIndex = 2;
            this.buttonWord.Text = "Pokreni Word";
            this.buttonWord.UseVisualStyleBackColor = true;
            this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(237, 59);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(150, 41);
            this.D.TabIndex = 3;
            this.D.Text = "Pokreni Exel";
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 203);
            this.Controls.Add(this.D);
            this.Controls.Add(this.buttonWord);
            this.Controls.Add(this.buttonStartInfo);
            this.Controls.Add(this.buttonExplorer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExplorer;
        private System.Windows.Forms.Button buttonStartInfo;
        private System.Windows.Forms.Button buttonWord;
        private System.Windows.Forms.Button D;
    }
}

