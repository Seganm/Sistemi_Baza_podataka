using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledIntervenise : Form
    {
        private int? trenutnaSituacijaId = null;

        public FormaPregledIntervenise()
        {
            InitializeComponent();
        }

        public FormaPregledIntervenise(int situacijaId)
        {
            InitializeComponent();
            trenutnaSituacijaId = situacijaId;
            UcitajZaSituaciju(situacijaId);
        }

        public async void UcitajZaSituaciju(int situacijaId)
        {
            var lista = await DTOManager.VanrednaUcestvovanjaVratii(situacijaId);
            gridUcestvovanja.DataSource = lista;
            gridUcestvovanja.Refresh();
            gridUcestvovanja.ClearSelection();
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            var forma = new FormaUpravljajIntervenise();
            forma.ShowDialog();
            OsveziPrikaz();
        }

        private void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (gridUcestvovanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koje učešće menjamo?", "Info");
                return;
            }

            var selektovana = gridUcestvovanja.CurrentRow.DataBoundItem as DTOVratiIntervenise;
            var forma = new FormaUpravljajIntervenise(selektovana);
            forma.ShowDialog();
            OsveziPrikaz();
        }

        private async void dugmeObrisi_Click(object sender, EventArgs e)
        {
            if (gridUcestvovanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koje učešće brišemo?", "Info");
                return;
            }

            var selektovana = gridUcestvovanja.CurrentRow.DataBoundItem as DTOVratiIntervenise;
            var potvrda = MessageBox.Show("Brisanje ovog učešća?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (potvrda == DialogResult.OK)
            {
                await DTOManager.InterveniseObrisii(selektovana.Id);
                MessageBox.Show("Učešće uspešno obrisano.", "Info");
                OsveziPrikaz();
            }
        }

        public void OsveziPrikaz()
        {
            if (trenutnaSituacijaId.HasValue)
                UcitajZaSituaciju(trenutnaSituacijaId.Value);
            else
                UcitajSvaUcestvovanja();
        }

        public async void UcitajSvaUcestvovanja()
        {
            var lista = await DTOManager.UcestvovanjaVratii();
            gridUcestvovanja.DataSource = lista;
            gridUcestvovanja.Refresh();
            gridUcestvovanja.ClearSelection();
        }

        private void FormaPregledIntervenise_Load(object sender, EventArgs e)
        {
            if (!trenutnaSituacijaId.HasValue)
                UcitajSvaUcestvovanja();
        }
    }
}
