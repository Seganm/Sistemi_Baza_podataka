using System;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledSertifikata : Form
    {
        DTOOperativniRadnik operativni;

        public FormaPregledSertifikata(DTOOperativniRadnik op)
        {
            InitializeComponent();
            operativni = op;
            UcitajSertifikate();
        }

        private void FormaPregledSertifikata_Load(object sender, EventArgs e)
        {
            UcitajSertifikate();
        }

        private async void UcitajSertifikate()
        {
            var sertifikati = await DTOManager.VratiSertifikateZaposlenog(operativni.JMBG);
            mrezaSertifikati.DataSource = sertifikati;
            mrezaSertifikati.Refresh();
            mrezaSertifikati.ClearSelection();
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            var forma = new FormaUpravljajSertifikatima(operativni.JMBG);
            forma.ShowDialog();
            UcitajSertifikate();
        }

        private async void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (mrezaSertifikati.SelectedRows.Count == 0)
            {
                MessageBox.Show("Aj izaberi neki sertifikat da mogu da ga otvorim ", "Info");
                return;
            }

            var sertifikat = mrezaSertifikati.CurrentRow.DataBoundItem as DTOVratiSertifikat;
            var forma = new FormaUpravljajSertifikatima(sertifikat);
            forma.ShowDialog();
            UcitajSertifikate();
        }

        private async void dugmeObrisi_Click(object sender, EventArgs e)
        {
            if (mrezaSertifikati.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nisi označio nijedan sertifikat za brisanje ", "Info");
                return;
            }

            string jmbg = mrezaSertifikati.SelectedRows[0].Cells["JMBGOperativnogRadnika"].Value.ToString();
            string naziv = mrezaSertifikati.SelectedRows[0].Cells["Naziv"].Value.ToString();
            string institucija = mrezaSertifikati.SelectedRows[0].Cells["Institucija"].Value.ToString();

            var sertifikatId = new DTODodajIdSertifikata
            {
                JMBGRadnika = jmbg,
                Naziv = naziv,
                Institucija = institucija
            };

            var potvrda = MessageBox.Show(
                "Hoćeš da obrišemo ovaj sertifikat? ",
                "Provera",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (potvrda == DialogResult.OK)
            {
                await DTOManager.ObrisiSertifikat(sertifikatId);
                MessageBox.Show("Sertifikat je uspešno obrisan! ", "Info");
                UcitajSertifikate();
            }
            else
            {
                MessageBox.Show("Okej, ništa nismo dirali. ", "Info");
            }
        }
    }
}
