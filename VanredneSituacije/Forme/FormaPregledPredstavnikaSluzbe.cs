using System;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledPredstavnikaSluzbe : Form
    {
        public FormaPregledPredstavnikaSluzbe()
        {
            InitializeComponent();
        }

        private void FormaPregledPredstavnikaSluzbe_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private async void UcitajPodatke()
        {
            var lista = await DTOManager.VratiPredstavnike();
            tabelaPredstavnici.DataSource = lista;
            tabelaPredstavnici.Refresh();
            tabelaPredstavnici.ClearSelection();
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            var forma = new FormaUpravljajPredstavnikomSluzbe();
            forma.ShowDialog();
            UcitajPodatke();
        }

        private void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (tabelaPredstavnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite predstavnika kojeg želite izmeniti.", "Info");
                return;
            }

            var selektovani = tabelaPredstavnici.CurrentRow.DataBoundItem as DTOPredstavnikSluzbe;
            var forma = new FormaUpravljajPredstavnikomSluzbe(selektovani);
            forma.ShowDialog();
            UcitajPodatke();
        }

        private async void dugmeObrisi_Click(object sender, EventArgs e)
        {
            if (tabelaPredstavnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite predstavnika kojeg želite obrisati.", "Info");
                return;
            }

            var selektovani = tabelaPredstavnici.CurrentRow.DataBoundItem as DTOPredstavnikSluzbe;
            var potvrda = MessageBox.Show(
                "Da li sigurno želite da obrišete ovog predstavnika?",
                "Potvrda brisanja",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (potvrda == DialogResult.OK)
            {
                await DTOManager.ObrisiPredstavnika(selektovani.JMBG);
                MessageBox.Show("Predstavnik uspešno obrisan.", "Info");
                UcitajPodatke();
            }
        }
    }
}
