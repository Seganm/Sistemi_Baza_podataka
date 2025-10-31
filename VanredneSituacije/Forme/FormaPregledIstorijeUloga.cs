using System;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledIstorijeUloga : Form
    {
        private string JMBGZap;

        public FormaPregledIstorijeUloga()
        {
            InitializeComponent();
        }

        public FormaPregledIstorijeUloga(string jmbg)
        {
            InitializeComponent();
            JMBGZap = jmbg;
            UcitajPodatke(jmbg);
        }

        private async void UcitajPodatke(string jmbg)
        {
            var lista = await DTOManager.IstorijaVratiPoJMBG(jmbg);
            gridIstorija.DataSource = lista;
            gridIstorija.Refresh();
            gridIstorija.ClearSelection();
        }

        private async void UcitajSve()
        {
            var lista = await DTOManager.IstorijaVratii();
            gridIstorija.DataSource = lista;
            gridIstorija.Refresh();
            gridIstorija.ClearSelection();
        }

        private void FormaPregledIstorijeUloga_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(JMBGZap))
                UcitajSve();
            else
                UcitajPodatke(JMBGZap);
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(JMBGZap))
            {
                var forma = new FormaUpravljajIstorijomUloga();
                forma.ShowDialog();
                UcitajSve();
            }
            else
            {
                var forma = new FormaUpravljajIstorijomUloga(JMBGZap);
                forma.ShowDialog();
                UcitajPodatke(JMBGZap);
            }
        }

        private void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (gridIstorija.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koju istoriju menjamo?", "Info");
                return;
            }

            var selektovana = gridIstorija.CurrentRow.DataBoundItem as DTOIstorijaUloga;
            var forma = new FormaUpravljajIstorijomUloga(selektovana);
            forma.ShowDialog();

            if (string.IsNullOrEmpty(JMBGZap))
                UcitajSve();
            else
                UcitajPodatke(JMBGZap);
        }

        private async void dugmeObrisi_Click(object sender, EventArgs e)
        {
            if (gridIstorija.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koju istoriju brišemo?", "Info");
                return;
            }

            var selektovana = gridIstorija.CurrentRow.DataBoundItem as DTOIstorijaUloga;
            var potvrda = MessageBox.Show("Brisanje ove istorije?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (potvrda == DialogResult.OK)
            {
                await DTOManager.IstorijaObrisii(selektovana.Id);
                MessageBox.Show("Istorija uspešno obrisana.", "Info");

                if (string.IsNullOrEmpty(JMBGZap))
                    UcitajSve();
                else
                    UcitajPodatke(JMBGZap);
            }
        }
    }
}
