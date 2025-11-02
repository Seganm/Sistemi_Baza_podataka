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
            grIdIntervencijee.DataSource = await DTOManager.IntervencijeVratii();
            grIdIntervencijee.Refresh();
            grIdIntervencijee.ClearSelection();
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            var forma = new FormaUpravljajIntervencijama();
            forma.ShowDialog();
            UcitajPodatke();
        }

        private async void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (grIdIntervencijee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koju intervenciju menjamo?", "Info");
                return;
            }

            var selektovana = grIdIntervencijee.CurrentRow.DataBoundItem as DTOIntervencija;
            var forma = new FormaUpravljajIntervencijama(selektovana);
            forma.ShowDialog();
            UcitajPodatke();
        }

        private async void dugmeObrisi_Click(object sender, EventArgs e)
        {
            if (grIdIntervencijee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koju intervenciju brišemo?", "Info");
                return;
            }

            var selektovana = grIdIntervencijee.CurrentRow.DataBoundItem as DTOIntervencija;
            var potvrda = MessageBox.Show("Brisanje ove intervencije?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (potvrda == DialogResult.OK)
            {
                await DTOManager.IntervencijaObrisii(selektovana.Id);
                MessageBox.Show("Intervencija uspešno obrisana.", "Info");
                UcitajPodatke();
            }
        }
    }
}
