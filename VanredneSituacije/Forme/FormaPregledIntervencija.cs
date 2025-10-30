using System;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledIntervencija : Form
    {
        public FormaPregledIntervencija()
        {
            InitializeComponent();
        }

        private void FormaPregledIntervencija_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private async void UcitajPodatke()
        {
            gridIntervencije.DataSource = await DTOManager.VratiIntervencije();
            gridIntervencije.Refresh();
            gridIntervencije.ClearSelection();
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            var forma = new FormaUpravljajIntervencijama();
            forma.ShowDialog();
            UcitajPodatke();
        }

        private async void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (gridIntervencije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koju intervenciju menjamo?", "Info");
                return;
            }

            var selektovana = gridIntervencije.CurrentRow.DataBoundItem as DTOIntervencija;
            var forma = new FormaUpravljajIntervencijama(selektovana);
            forma.ShowDialog();
            UcitajPodatke();
        }

        private async void dugmeObrisi_Click(object sender, EventArgs e)
        {
            if (gridIntervencije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koju intervenciju brišemo?", "Info");
                return;
            }

            var selektovana = gridIntervencije.CurrentRow.DataBoundItem as DTOIntervencija;
            var potvrda = MessageBox.Show("Brisanje ove intervencije?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (potvrda == DialogResult.OK)
            {
                await DTOManager.ObrisiIntervenciju(selektovana.Id);
                MessageBox.Show("Intervencija uspešno obrisana.", "Info");
                UcitajPodatke();
            }
        }
    }
}
