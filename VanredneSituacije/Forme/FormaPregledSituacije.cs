using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;
using VanredneSituacije.Entitet;
using VanredneSituacije.Forme;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledSituacije : Form
    {
        public FormaPregledSituacije()
        {
            InitializeComponent();
        }

        private void dugmeDodajSituaciju_Click(object sender, EventArgs e)
        {
            var forma = new FormaUpravljajSituacijom();
            forma.ShowDialog();
            OsveziPodatke();
        }

        private void dugmeIzmeniSituaciju_Click(object sender, EventArgs e)
        {
            if (tabelaSituacije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi situaciju koju želiš da izmeniš.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var situacija = tabelaSituacije.CurrentRow.DataBoundItem as DTOVanrednaSituacija;
            var forma = new FormaUpravljajSituacijom(situacija);
            forma.ShowDialog();
            OsveziPodatke();
        }

        private async void dugmeObrisiSituaciju_Click(object sender, EventArgs e)
        {
            if (tabelaSituacije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi situaciju koju želiš da obrišeš.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var situacija = tabelaSituacije.CurrentRow.DataBoundItem as DTOVanrednaSituacija;

            DialogResult rezultat = MessageBox.Show(
                "Da obrišem izabranu situaciju?",
                "Info",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (rezultat == DialogResult.OK)
            {
                await DTOManager.VanrednaObrisii(situacija.Id);
                MessageBox.Show("Situacija je obrisana.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OsveziPodatke();
            }
        }

        private void FormaPregledSituacije_Load(object sender, EventArgs e)
        {
            OsveziPodatke();
        }

        public async void OsveziPodatke()
        {
            var podaci = await DTOManager.VanredneVratii();
            tabelaSituacije.DataSource = podaci;
            tabelaSituacije.Refresh();
            tabelaSituacije.ClearSelection();
        }

        private void dugmePrikaziUcesce_Click(object sender, EventArgs e)
        {
            if (tabelaSituacije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi situaciju da vidiš ko je učestvovao.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var situacija = tabelaSituacije.CurrentRow.DataBoundItem as DTOVanrednaSituacija;
            if (situacija == null)
            {
                MessageBox.Show("Desila se greška pri učitavanju podataka o situaciji.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var forma = new FormaPregledIntervenise(situacija.Id);
            forma.ShowDialog();
        }
    }
}
