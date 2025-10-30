using System;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledEvidencijeServisa : Form
    {
        private DTOVozilo vozilo;

        public FormaPregledEvidencijeServisa()
        {
            InitializeComponent();
        }

        public FormaPregledEvidencijeServisa(DTOVozilo v)
        {
            InitializeComponent();
            vozilo = v;
            UcitajPodatke();
        }

        public async void UcitajPodatke()
        {
            var lista = await DTOManager.VratiServiseVozila(vozilo.Registarska_Oznaka);
            gridServisi.DataSource = lista;
            gridServisi.Refresh();
            gridServisi.ClearSelection();
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            var forma = new FormaUpravljajEvidencijomServisa(vozilo.Registarska_Oznaka);
            forma.ShowDialog();
            UcitajPodatke();
        }

        private async void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (gridServisi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koju evidenciju menjamo?", "Info");
                return;
            }

            var selektovana = gridServisi.CurrentRow.DataBoundItem as DTOEvidencijaServis;
            var forma = new FormaUpravljajEvidencijomServisa(selektovana);
            forma.ShowDialog();
            UcitajPodatke();
        }

        private async void dugmeObrisi_Click(object sender, EventArgs e)
        {
            if (gridServisi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koju evidenciju brišemo?", "Info");
                return;
            }

            var selektovana = gridServisi.CurrentRow.DataBoundItem as DTOEvidencijaServis;
            var potvrda = MessageBox.Show("Brisanje ove evidencije?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (potvrda == DialogResult.Yes)
            {
                await DTOManager.ObrisiServis(selektovana.Id);
                MessageBox.Show("Evidencija uspešno obrisana.", "Info");
                UcitajPodatke();
            }
        }

        private void FormaPregledEvidencijeServisa_Load(object sender, EventArgs e)
        {
        }
    }
}
