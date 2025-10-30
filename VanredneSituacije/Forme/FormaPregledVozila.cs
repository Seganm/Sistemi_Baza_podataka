using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledVozila : Form
    {
        public FormaPregledVozila()
        {
            InitializeComponent();
        }

        private void dugmeDodajVozilo_Click(object sender, EventArgs e)
        {
            var forma = new FormaVoziloDodaj();
            forma.ShowDialog();
            OsveziPrikazVozila();
        }

        public async void OsveziPrikazVozila()
        {
            string izborTipa = izborTipaVozila.SelectedItem?.ToString();

            if (izborTipa == "Sva vozila")
                tabelaVozila.DataSource = await DTOManager.VratiSvaVozila();
            else if (izborTipa == "Sanitetska vozila")
                tabelaVozila.DataSource = await DTOManager.VratiSanitetskaVozila();
            else if (izborTipa == "Specijalna vozila")
                tabelaVozila.DataSource = await DTOManager.VratiSpecijalnaVozila();
            else if (izborTipa == "Kamioni")
                tabelaVozila.DataSource = await DTOManager.VratiKamione();
            else if (izborTipa == "Džipovi")
                tabelaVozila.DataSource = await DTOManager.VratiDzipove();
            else
                tabelaVozila.DataSource = await DTOManager.VratiSvaVozila();

            tabelaVozila.Refresh();
            tabelaVozila.ClearSelection();
        }

        private void dugmeIzmeniVozilo_Click(object sender, EventArgs e)
        {
            if (tabelaVozila.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi vozilo koje želiš da izmeniš.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var vozilo = tabelaVozila.CurrentRow.DataBoundItem as DTOVozilo;
            Form forma;

            if (vozilo is DTOSanitetsko sanitetsko)
                forma = new FormaUpravljajSanitetskim(sanitetsko);
            else if (vozilo is DTOSpecijalno specijalno)
                forma = new FormaUpravljajSpecijalnim(specijalno.Registarska_Oznaka);
            else if (vozilo is DTOKamion kamion)
                forma = new FormaUpravljajKamionom(kamion.Registarska_Oznaka);
            else if (vozilo is DTODzip dzip)
                forma = new FormaUpravljajDzipom(dzip.Registarska_Oznaka);
            else
                throw new Exception("Nepoznat tip vozila.");

            forma.ShowDialog();
            OsveziPrikazVozila();
        }

        private async void dugmeObrisiVozilo_Click(object sender, EventArgs e)
        {
            if (tabelaVozila.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi vozilo koje želiš da obrišeš.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult potvrda = MessageBox.Show("Da obrišem izabrano vozilo?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (potvrda == DialogResult.OK)
            {
                var vozilo = tabelaVozila.CurrentRow.DataBoundItem as DTOVozilo;

                if (vozilo is DTOSanitetsko sanitetsko)
                    await DTOManager.ObrisiSanitetskoVozilo(sanitetsko.Registarska_Oznaka);
                else if (vozilo is DTOSpecijalno specijalno)
                    await DTOManager.ObrisiSpecijalnoVozilo(specijalno.Registarska_Oznaka);
                else if (vozilo is DTOKamion kamion)
                    await DTOManager.ObrisiKamion(kamion.Registarska_Oznaka);
                else if (vozilo is DTODzip dzip)
                    await DTOManager.ObrisiDzip(dzip.Registarska_Oznaka);
                else
                    throw new Exception("Nepoznat tip vozila.");

                MessageBox.Show("Vozilo je obrisano.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OsveziPrikazVozila();
            }
        }

        private void dugmeIntervencije_Click(object sender, EventArgs e)
        {
            if (tabelaVozila.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi vozilo da vidiš istoriju intervencija.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var vozilo = tabelaVozila.CurrentRow.DataBoundItem as DTOVozilo;
            var forma = new FormaAngazovanostVozila(vozilo.Registarska_Oznaka);
            forma.ShowDialog();
            OsveziPrikazVozila();
        }

        private void dugmeServisi_Click(object sender, EventArgs e)
        {
            if (tabelaVozila.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi vozilo da vidiš istoriju servisa.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var vozilo = tabelaVozila.CurrentRow.DataBoundItem as DTOVozilo;
            var forma = new FormaPregledEvidencijeServisa(vozilo);
            forma.ShowDialog();
            OsveziPrikazVozila();
        }

        private void izborTipaVozila_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsveziPrikazVozila();
        }

        private async void FormaPregledVozila_Load(object sender, EventArgs e)
        {
            izborTipaVozila.SelectedIndex = 0;
            tabelaVozila.DataSource = await DTOManager.VratiSvaVozila();
            OsveziPrikazVozila();
        }
    }
}
