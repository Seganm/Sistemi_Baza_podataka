using System;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledIstorijeUloga : Form
    {
        private string jmbgZaposlenog;

        public FormaPregledIstorijeUloga()
        {
            InitializeComponent();
        }

        public FormaPregledIstorijeUloga(string jmbg)
        {
            InitializeComponent();
            jmbgZaposlenog = jmbg;
            UcitajPodatke(jmbg);
        }

        private async void UcitajPodatke(string jmbg)
        {
            var lista = await DTOManager.VratiIstorijuUZaposlenog(jmbg);
            gridIstorija.DataSource = lista;
            gridIstorija.Refresh();
            gridIstorija.ClearSelection();
        }

        private async void UcitajSve()
        {
            var lista = await DTOManager.VratiIstoriju();
            gridIstorija.DataSource = lista;
            gridIstorija.Refresh();
            gridIstorija.ClearSelection();
        }

        private void FormaPregledIstorijeUloga_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(jmbgZaposlenog))
                UcitajSve();
            else
                UcitajPodatke(jmbgZaposlenog);
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(jmbgZaposlenog))
            {
                var forma = new FormaUpravljajIstorijomUloga();
                forma.ShowDialog();
                UcitajSve();
            }
            else
            {
                var forma = new FormaUpravljajIstorijomUloga(jmbgZaposlenog);
                forma.ShowDialog();
                UcitajPodatke(jmbgZaposlenog);
            }
        }

        private void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (gridIstorija.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koju istoriju menjamo?", "Info");
                return;
            }

            var selektovana = gridIstorija.CurrentRow.DataBoundItem as DTOIstorijaUloga;
            var forma = new FormaUpravljajIstorijomUloga(selektovana);
            forma.ShowDialog();

            if (string.IsNullOrEmpty(jmbgZaposlenog))
                UcitajSve();
            else
                UcitajPodatke(jmbgZaposlenog);
        }

        private async void dugmeObrisi_Click(object sender, EventArgs e)
        {
            if (gridIstorija.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koju istoriju brišemo?", "Info");
                return;
            }

            var selektovana = gridIstorija.CurrentRow.DataBoundItem as DTOIstorijaUloga;
            var potvrda = MessageBox.Show("Brisanje ove istorije?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (potvrda == DialogResult.OK)
            {
                await DTOManager.ObrisiIstorijuUloga(selektovana.Id);
                MessageBox.Show("Istorija uspešno obrisana.", "Info");

                if (string.IsNullOrEmpty(jmbgZaposlenog))
                    UcitajSve();
                else
                    UcitajPodatke(jmbgZaposlenog);
            }
        }
    }
}
