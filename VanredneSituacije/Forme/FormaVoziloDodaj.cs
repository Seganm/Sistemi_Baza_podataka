using System;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    public partial class FormaVoziloDodaj : Form
    {
        public FormaVoziloDodaj()
        {
            InitializeComponent();
        }

        private void btnSanitetsko_Click(object sender, EventArgs e)
        {
            new FormaUpravljajSanitetskim().ShowDialog();
            Close();
        }

        private void btnSpecijalnoVozilo_Click(object sender, EventArgs e)
        {
            new FormaUpravljajSpecijalnim().ShowDialog();
            Close();
        }

        private void btnDzipVozilo_Click(object sender, EventArgs e)
        {
            new FormaUpravljajDzipom().ShowDialog();
            Close();
        }

        private void btnKamionVozilo_Click(object sender, EventArgs e)
        {
            new FormaUpravljajKamionom().ShowDialog();
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Da li zaista želiš da izađeš iz ove forme?",
                "Potvrda zatvaranja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Close();
        }

        private void FormaVoziloDodaj_Load(object sender, EventArgs e)
        {
        }
    }
}