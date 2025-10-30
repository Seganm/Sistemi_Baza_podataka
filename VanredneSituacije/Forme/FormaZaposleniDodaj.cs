using System;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    public partial class FormaZaposleniDodaj : Form
    {
        public FormaZaposleniDodaj()
        {
            InitializeComponent();
        }

        private void FormaZaposleniDodaj_Load(object sender, EventArgs e)
        {
        }

        private void btnOperativni_Click(object sender, EventArgs e)
        {
            new FormaUpravljajOperativnim().ShowDialog();
            Close();
        }

        private void btnKoordinator_Click(object sender, EventArgs e)
        {
            new FormaUpravljajKoordinatorom().ShowDialog();
            Close();
        }

        private void btnAnaliticar_Click(object sender, EventArgs e)
        {
            new FormaUpravljajAnaliticarom().ShowDialog();
            Close();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}