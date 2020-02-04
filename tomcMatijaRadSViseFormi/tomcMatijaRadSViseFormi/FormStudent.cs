using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomcMatijaRadSViseFormi
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            if (!(listBoxStudenti.SelectedIndex < 0))
                listBoxStudenti.Items.RemoveAt(listBoxStudenti.SelectedIndex);
        }

        private void buttonObrisiSve_Click(object sender, EventArgs e)
        {
            listBoxStudenti.Items.Clear();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormUnosNovogStudenta frm = new FormUnosNovogStudenta();
            DialogResult rez = frm.ShowDialog();
            // unos novog studenta u listBox
            if (rez == System.Windows.Forms.DialogResult.OK)
                listBoxStudenti.Items.Add(frm.Student1.ToString());
        }
    }
}
