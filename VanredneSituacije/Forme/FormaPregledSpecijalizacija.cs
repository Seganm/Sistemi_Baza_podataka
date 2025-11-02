using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledSpecijalizacija : Form
    {
        private DTOKoordinator koordinator;

        public FormaPregledSpecijalizacija(DTOKoordinator kord)
        {
            InitializeComponent();
            koordinator = kord;
            OsveziPrikazSpecijalizacija();
        }

        public async void OsveziPrikazSpecijalizacija()
        {
            var podaci = await DTOManager.SpecijalizacijeVratiPoJMBG(koordinator.JMBG);
            tabelaSpecijalizacija.DataSource = podaci;
            tabelaSpecijalizacija.Refresh();
            tabelaSpecijalizacija.ClearSelection();
        }

        private void dugmeSpecijalizacijaDodajj_Click(object sender, EventArgs e)
        {
            var forma = new FormaUpravljajSpecijalizacijama(koordinator.JMBG);
            forma.ShowDialog();
            OsveziPrikazSpecijalizacija();
        }

        private async void dugmeSpecijalizacijaIzmenii_Click(object sender, EventArgs e)
        {
            if (tabelaSpecijalizacija.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi specijalizaciju koju želiš da izmeniš.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = int.Parse(tabelaSpecijalizacija.SelectedRows[0].Cells["Id"].Value.ToString());
            var specijalizacija = await DTOManager.SpecijalizacijaVratii(id);

            var forma = new FormaUpravljajSpecijalizacijama(specijalizacija);
            forma.ShowDialog();
            OsveziPrikazSpecijalizacija();
        }

        private async void dugmeSpecijalizacijaObrisii_Click(object sender, EventArgs e)
        {
            if (tabelaSpecijalizacija.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi specijalizaciju koju želiš da obrišeš.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = int.Parse(tabelaSpecijalizacija.SelectedRows[0].Cells["Id"].Value.ToString());

            DialogResult potvrda = MessageBox.Show(
                "Da obrišem izabranu specijalizaciju?",
                "Info",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (potvrda == DialogResult.OK)
            {
                await DTOManager.SpecijalizacijaObrisii(id);
                MessageBox.Show("Specijalizacija je obrisana.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OsveziPrikazSpecijalizacija();
            }
        }

        private void FormaPregledSpecijalizacija_Load(object sender, EventArgs e)
        {
            OsveziPrikazSpecijalizacija();
        }
    }
}
