using System;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledPrijava : Form
    {
        public FormaPregledPrijava()
        {
            InitializeComponent();
        }

        private void mrezaPrijave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormaPregledPrijava_Load(object sender, EventArgs e)
        {
            UcitajPrijave();
        }

        public async void UcitajPrijave()
        {
            var lista = await DTOManager.VratiPrijave();
            mrezaPrijave.DataSource = lista;
            mrezaPrijave.Refresh();
            mrezaPrijave.ClearSelection();
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            var forma = new FormaUpravljajPrijavama();
            forma.ShowDialog();
            UcitajPrijave();
        }

        private void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (mrezaPrijave.CurrentRow == null || mrezaPrijave.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Odaberite prijavu koju želite izmeniti.", "Info");
                return;
            }

            var prijava = mrezaPrijave.CurrentRow.DataBoundItem as DTOPrijava;
            var forma = new FormaUpravljajPrijavama(prijava);
            forma.ShowDialog();
            UcitajPrijave();
        }

        private async void dugmeObrisi_Click(object sender, EventArgs e)
        {
            if (mrezaPrijave.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite prijavu koju želite obrisati.", "Info");
                return;
            }

            var prijava = mrezaPrijave.CurrentRow.DataBoundItem as DTOPrijava;
            var potvrda = MessageBox.Show(
                "Da li sigurno želite da obrišete ovu prijavu?",
                "Potvrda brisanja",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (potvrda == DialogResult.OK)
            {
                await DTOManager.ObrisiPrijavu(prijava.Id);
                MessageBox.Show("Prijava obrisana.", "Info");
                UcitajPrijave();
            }
        }
    }
}
