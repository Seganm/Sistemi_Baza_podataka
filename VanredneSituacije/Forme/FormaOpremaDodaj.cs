using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    public partial class FormaOpremaDodaj : Form
    {
        public FormaOpremaDodaj()
        {
            InitializeComponent();
        }

        private void buttonOpsta_Click(object sender, EventArgs e)
        {
            FormaUpravljajZalihama forma = new FormaUpravljajZalihama();
            forma.ShowDialog();
            Close();
        }

        private void buttonSpec_Click(object sender, EventArgs e)
        {
            FormaUpravljajMedicinskom forma = new FormaUpravljajMedicinskom();
            forma.ShowDialog();
            Close();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            FormaUpravljajTehnickom forma = new FormaUpravljajTehnickom();
            forma.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaUpravljajLicnomZastitom forma = new FormaUpravljajLicnomZastitom();
            forma.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult odluka = MessageBox.Show(
                "Zatvaramo ovu formu?",
                "Info",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (odluka == DialogResult.Yes)
                Close();
        }

        private void FormaOpremaDodaj_Load(object sender, EventArgs e)
        {
        }
    }
}
