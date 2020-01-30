using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomcMatijaDialogResult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string poruka = "Odaberite Yes / No / Cancel";
        string naslov = "Naslovna linija Dijaloga za poruke";
        MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
        MessageBoxIcon ikona = MessageBoxIcon.Information;
        

        private void buttonOtvori_Click(object sender, EventArgs e)
        {
            // MessageBox.Show() vraća vrijednost tipa DialogResult
            // tu vrijednost dodjeljujemo varijabli rez
             DialogResult rezultat = MessageBox.Show(poruka, naslov, buttons, ikona);
            switch (rezultat)
            {
                case DialogResult.Yes:
                    textBoxRezultat.Text = "Izabrali ste dugme YES";
                    break;
                case DialogResult.No:
                    textBoxRezultat.Text = "Izabrali ste dugme NO";
                    break;
                case DialogResult.Cancel:
                    textBoxRezultat.Text = "Izabrali ste dugme Cancel";
                    break;
            }
        }

        private void textBoxRezultat_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
