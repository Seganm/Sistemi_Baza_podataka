using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaJedinicaVozila : Form
    {
        public readonly string maticni;
        public readonly int idjed;

        public FormaJedinicaVozila(string maticniBroj)
        {
            InitializeComponent();
            maticni = maticniBroj;
            UcitajPodatke();
        }

        public FormaJedinicaVozila(int id)
        {
            InitializeComponent();
            idjed = id;
            UcitajPodatke();
        }

        public async void UcitajPodatke()
        {
            try
            {
                if (idjed != 0)
                {
                    gridVozila.DataSource = await DTOManager.VratiDodeljivanjaJedinic(idjed);
                }
                else if (!string.IsNullOrEmpty(maticni))
                {
                    gridVozila.DataSource = await DTOManager.VratiDodeljenaVozilaRadniku(maticni);
                }

                gridVozila.Refresh();
                gridVozila.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Podaci nisu lepo ucitani: " + ex.Message);
            }
        }

        private async void buttonObrisi_Click(object sender, EventArgs e)
        {
            if (gridVozila.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koje vozilo brisemo?", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var v = gridVozila.CurrentRow?.DataBoundItem as DTOVozilo;
            if (v == null)
                return;

            DialogResult ok = MessageBox.Show(
                "Brisem vozilo?",
                "info",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (ok == DialogResult.OK)
            {
                await DTOManager.ObrisiVozilo(v.Registarska_Oznaka);
                MessageBox.Show("Obrisano vozilo", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajPodatke();
            }
        }

        private void FormaJedinicaVozila_Load(object sender, EventArgs e)
        {
        }
    }
}
