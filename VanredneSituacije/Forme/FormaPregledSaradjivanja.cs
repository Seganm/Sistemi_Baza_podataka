using System;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledSaradjivanja : Form
    {
        public FormaPregledSaradjivanja()
        {
            InitializeComponent();
        }

        private void FormaPregledSaradjivanja_Load(object sender, EventArgs e)
        {
            UcitajSaradnje();
        }

        private async void UcitajSaradnje()
        {
            var lista = await DTOManager.VratiSaradnje();
            mrezaSaradnje.DataSource = lista;
            mrezaSaradnje.Refresh();
            mrezaSaradnje.ClearSelection();
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            var forma = new FormaUpravljajSaradjivanjem();
            forma.ShowDialog();
            UcitajSaradnje();
        }

        private async void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (mrezaSaradnje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Aj izaberi neku saradnju da mogu da izmenim ", "Obaveštenje");
                return;
            }

            int saradnjaId = int.Parse(mrezaSaradnje.SelectedRows[0].Cells[0].Value.ToString());
            var saradnja = await DTOManager.VratiSaradnju(saradnjaId);
            var forma = new FormaUpravljajSaradjivanjem(saradnja);
            forma.ShowDialog();
            UcitajSaradnje();
        }

        private async void dugmeObrisi_Click(object sender, EventArgs e)
        {
            if (mrezaSaradnje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nisi označio nijednu saradnju za brisanje ", "Obaveštenje");
                return;
            }

            int id = int.Parse(mrezaSaradnje.SelectedRows[0].Cells[0].Value.ToString());
            var potvrda = MessageBox.Show(
                "Hoćeš sigurno da izbrišemo ovu saradnju? ",
                "Provera",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (potvrda == DialogResult.OK)
            {
                await DTOManager.ObrisiSaradnju(id);
                MessageBox.Show("Gotovo, saradnja obrisana bez greške! ", "Info");
                UcitajSaradnje();
            }
            else
            {
                MessageBox.Show("Ništa nismo dirali, sve ostaje kako je bilo. ", "Info");
            }
        }
    }
}
