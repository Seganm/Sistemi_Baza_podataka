using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledSluzbe : Form
    {
        public FormaPregledSluzbe()
        {
            InitializeComponent();
        }

        private void FormaPregledSluzbe_Load(object sender, EventArgs e)
        {
            OsveziPrikazSluzbi();
        }

        public async void OsveziPrikazSluzbi()
        {
            var listaSluzbi = await DTOManager.SluzbeVratii();
            tabelaSluzbi.DataSource = listaSluzbi;
            tabelaSluzbi.Refresh();
            tabelaSluzbi.ClearSelection();
        }

        private void dugmeSluzbaDodajj_Click(object sender, EventArgs e)
        {
            var forma = new FormaUpravljajSluzbom();
            forma.ShowDialog();
            OsveziPrikazSluzbi();
        }

        private async void dugmeSluzbaIzmenii_Click(object sender, EventArgs e)
        {
            if (tabelaSluzbi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi službu koju želiš da izmeniš.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSluzbe = Convert.ToInt32(tabelaSluzbi.SelectedRows[0].Cells[0].Value);
            var sluzba = await DTOManager.SluzbaVratii(idSluzbe);

            var forma = new FormaUpravljajSluzbom(sluzba);
            forma.ShowDialog();
            OsveziPrikazSluzbi();
        }

        private async void dugmeSluzbaObrisii_Click(object sender, EventArgs e)
        {
            if (tabelaSluzbi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Označi službu koju želiš da obrišeš.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(tabelaSluzbi.SelectedRows[0].Cells[0].Value);

            DialogResult potvrda = MessageBox.Show(
                "Da obrišem izabranu službu?",
                "Info",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (potvrda == DialogResult.OK)
            {
                await DTOManager.SluzbaObrisii(id);
                MessageBox.Show("Služba je obrisana.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OsveziPrikazSluzbi();
            }
        }
    }
}
