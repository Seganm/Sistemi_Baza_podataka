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
                tabelaVozila.DataSource = await DTOManager.VozilaVratii();
            else if (izborTipa == "Sanitetska vozila")
                tabelaVozila.DataSource = await DTOManager.SanitetskaVratii();
            else if (izborTipa == "Specijalna vozila")
                tabelaVozila.DataSource = await DTOManager.SpecijalnaVratii();
            else if (izborTipa == "Kamioni")
                tabelaVozila.DataSource = await DTOManager.KamioniVratii();
            else if (izborTipa == "Džipovi")
                tabelaVozila.DataSource = await DTOManager.DzipoviVratii();
            else
                tabelaVozila.DataSource = await DTOManager.VozilaVratii();

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
                forma = new FormaUpravljajSpecijalnim(specijalno.Registracijaa);
            else if (vozilo is DTOKamion kamion)
                forma = new FormaUpravljajKamionom(kamion.Registracijaa);
            else if (vozilo is DTODzip dzip)
                forma = new FormaUpravljajDzipom(dzip.Registracijaa);
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
                    await DTOManager.SanitetskoObrisii(sanitetsko.Registracijaa);
                else if (vozilo is DTOSpecijalno specijalno)
                    await DTOManager.SpecijalnoObrisii(specijalno.Registracijaa);
                else if (vozilo is DTOKamion kamion)
                    await DTOManager.KamionObrisii(kamion.Registracijaa);
                else if (vozilo is DTODzip dzip)
                    await DTOManager.DzipObrisii(dzip.Registracijaa);
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
            var forma = new FormaAngazovanostVozila(vozilo.Registracijaa);
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
            tabelaVozila.DataSource = await DTOManager.VozilaVratii();
            OsveziPrikazVozila();
        }
    }
}
