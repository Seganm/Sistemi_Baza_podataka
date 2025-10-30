using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledSoftvera : Form
    {
        private DTOAnaliticar analiticar;

        public FormaPregledSoftvera(DTOAnaliticar a)
        {
            InitializeComponent();
            analiticar = a;
            OsveziPrikazSoftvera();
        }

        private void dugmeDodajSoftver_Click(object sender, EventArgs e)
        {
            var forma = new FormaUpravljajSoftverom(analiticar.JMBG);
            forma.ShowDialog();
            OsveziPrikazSoftvera();
        }

        private void dugmeIzmeniSoftver_Click(object sender, EventArgs e)
        {
            if (tabelaSoftveri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi softver koji želiš da izmeniš.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var softver = tabelaSoftveri.CurrentRow.DataBoundItem as DTOSoftveri;
            var forma = new FormaUpravljajSoftverom(softver);
            forma.ShowDialog();
            OsveziPrikazSoftvera();
        }

        private async void dugmeObrisiSoftver_Click(object sender, EventArgs e)
        {
            if (tabelaSoftveri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi softver koji želiš da obrišeš.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult potvrda = MessageBox.Show(
                "Da obrišem izabrani softver?",
                "Info",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (potvrda == DialogResult.OK)
            {
                var softver = tabelaSoftveri.SelectedRows[0].DataBoundItem as DTOSoftveri;
                await DTOManager.ObrisiSoftver(softver.Id);
                MessageBox.Show("Softver je obrisan.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OsveziPrikazSoftvera();
            }
        }

        private void tabelaSoftveri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OsveziPrikazSoftvera();
        }

        public async void OsveziPrikazSoftvera()
        {
            var lista = await DTOManager.VratiSoftvereAnaliticara(analiticar.JMBG);
            tabelaSoftveri.DataSource = lista;
            tabelaSoftveri.Refresh();
            tabelaSoftveri.ClearSelection();
        }

        private void FormaPregledSoftvera_Load(object sender, EventArgs e)
        {
            OsveziPrikazSoftvera();
        }
    }
}
