using System;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaZaposleni : Form
    {
        private readonly string zaposleniJMBG;

        public FormaZaposleni(string zaposleniJMBG)
        {
            InitializeComponent();
            this.zaposleniJMBG = zaposleniJMBG;
        }

        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (tblIstorija.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali stavku za izmenu.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idIstorije = int.Parse(tblIstorija.SelectedRows[0].Cells["Id"].Value.ToString());
            DTOIstorijaUloga istorija = await DTOManager.IstorijaVratiiU(idIstorije);

            new FormaUpravljajIstorijomUloga(istorija).ShowDialog();
            UcitajPodatke();
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            if (tblIstorija.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali stavku za brisanje.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var potvrda = MessageBox.Show(
                "Da li želite da obrišete izabranu stavku?",
                "Potvrda", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (potvrda == DialogResult.OK)
            {
                var uloga = tblIstorija.CurrentRow.DataBoundItem as DTOIstorijaUloga;
                await DTOManager.IstorijaObrisii(uloga.Id);

                MessageBox.Show("Stavka je uspešno obrisana.",
                    "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UcitajPodatke();
            }
        }

        private void FormaZaposleni_Load(object sender, EventArgs e) => UcitajPodatke();

        public async void UcitajPodatke()
        {
            try
            {
                tblIstorija.DataSource = await DTOManager.IstorijaVratii();
                tblIstorija.Refresh();
                tblIstorija.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške pri učitavanju podataka.\nDetalji: {ex.Message}",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
