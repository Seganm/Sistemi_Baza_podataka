using System;
using System.Drawing;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledAngazovanih : Form
    {
        public FormaPregledAngazovanih()
        {
            InitializeComponent();
        }

        public async void PopuniPodacima()
        {
            gridAngazovanja.DataSource = await DTOManager.AngazovanjaVratii();
            gridAngazovanja.Refresh();
            gridAngazovanja.ClearSelection();
        }

        private void FormaPregledAngazovanih_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        private void naslovLabel_Click(object sender, EventArgs e)
        {
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            FormaDodajAngazovano forma = new FormaDodajAngazovano();
            forma.ShowDialog();
            PopuniPodacima();
        }

        private async void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (gridAngazovanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koje angažovanje menjamo?", "Info");
                return;
            }

            var selektovano = gridAngazovanja.CurrentRow.DataBoundItem as DTOVratiAngazovano;
            FormaDodajAngazovano forma = new FormaDodajAngazovano(selektovano);
            forma.ShowDialog();
            PopuniPodacima();
        }

        private async void dugmeObrisi_Click(object sender, EventArgs e)
        {
            if (gridAngazovanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koje angažovanje brišemo?", "Info");
                return;
            }

            var selektovano = gridAngazovanja.CurrentRow.DataBoundItem as DTOVratiAngazovano;
            var potvrda = MessageBox.Show("Brišemo ovu istoriju?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (potvrda == DialogResult.OK)
            {
                await DTOManager.AngazovanjeObrisii(selektovano.Id);
                MessageBox.Show("Uspešno obrisano!", "Info");
                PopuniPodacima();
            }
        }
    }
}
