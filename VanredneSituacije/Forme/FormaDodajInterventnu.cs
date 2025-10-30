using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    public partial class FormaDodajInterventnu : Form
    {
        public FormaDodajInterventnu()
        {
            InitializeComponent();
        }

        private void dugmeOpsta_Click(object sender, EventArgs e)
        {
            var f = new FormaUpravljajOpstomInterventnom();
            f.ShowDialog();
            Close();
        }

        private void dugmeSpecijalna_Click(object sender, EventArgs e)
        {
            var f = new FormaUpravljajSpecijalnomInterventnom();
            f.ShowDialog();
            Close();
        }

        private void dugmeZatvori_Click(object sender, EventArgs e)
        {
            DialogResult ok = MessageBox.Show(
                "Zatvaram formu?",
                "info",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ok == DialogResult.Yes)
                Close();
        }

        private void FormaDodajInterventnu_Load(object sender, EventArgs e)
        {
          
        }
    }
}
