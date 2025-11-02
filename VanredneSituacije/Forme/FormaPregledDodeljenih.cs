using System;
using System.Drawing;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledDodeljenih : Form
    {
        public FormaPregledDodeljenih()
        {
            InitializeComponent();
        }

        private void FormaPregledDodeljenih_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private async void UcitajPodatke()
        {
            var lista = await DTOManager.DodeljivanjaVratii();
            gridDodeljivanja.DataSource = lista;
            gridDodeljivanja.Refresh();
            gridDodeljivanja.ClearSelection();
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            FormaUpravljajDodeljenim forma = new FormaUpravljajDodeljenim();
            forma.ShowDialog();
            UcitajPodatke();
        }

        private async void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (gridDodeljivanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koje dodeljivanje menjamoo?", "Info");
                return;
            }

            int dodeljenId = int.Parse(gridDodeljivanja.SelectedRows[0].Cells[0].Value.ToString());
            DTOVratiDodeljen dodeljen = await DTOManager.DodeljivanjeVratii(dodeljenId);
            MessageBox.Show($"ID dodeljivanja: {dodeljen.Id}");
            FormaUpravljajDodeljenim forma = new FormaUpravljajDodeljenim(dodeljen);
            forma.ShowDialog();
            UcitajPodatke();
        }

        private async void dugmeObrisi_Click(object sender, EventArgs e)
        {
            if (gridDodeljivanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koje dodeljivanje brišemo?", "Info");
                return;
            }

            var selektovano = gridDodeljivanja.CurrentRow.DataBoundItem as DTOVratiDodeljen;
            var potvrda = MessageBox.Show("Brisanje ovog dodeljivanja?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (potvrda == DialogResult.OK)
            {
                await DTOManager.DodeljivanjeObrisii(selektovano.Id);
                MessageBox.Show("Uspešno obrisano dodeljivanje!", "Info");
                UcitajPodatke();
            }
        }
    }
}
