using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace tomcMatijaFormaProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chbPrikazi_CheckedChanged(object sender, EventArgs e)
        {
            if (grbKontrola.Visible == false)
                grbKontrola.Visible = true;
            else
                grbKontrola.Visible = false;
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            
            string odabir = cmbPokreni.SelectedItem.ToString();
            ///%windir%\system32\notepad.exe
            if (odabir == "Paint")
            {
                Process.Start("mspaint.exe");
            }

            if (odabir == "Notepad")
            {
                Process.Start("notepad.exe");
            }
        }

        private void cmbPokreni_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            txtImePrograma.Clear();
            txtOpisPrograma.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void otvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void izađiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Želite li izač.", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (odgovor == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void tekstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text form = new Text();
            form.Show();
        }

        private void porukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Izaberite jedan gumb.", "Obavjest", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        }
    }
}
