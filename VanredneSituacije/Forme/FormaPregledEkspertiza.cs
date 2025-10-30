using System;
using System.Drawing;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledEkspertiza : Form
    {
        private DTOAnaliticar analiticar;

        public FormaPregledEkspertiza(DTOAnaliticar a)
        {
            InitializeComponent();
            analiticar = a;
            UcitajEkspertize();
        }

        public async void UcitajEkspertize()
        {
            var lista = await DTOManager.VratiEkspertizeAnaliticara(analiticar.JMBG);
            gridEkspertize.DataSource = lista;
            gridEkspertize.Refresh();
            gridEkspertize.ClearSelection();
        }

        private void FormaPregledEkspertiza_Load(object sender, EventArgs e)
        {
            UcitajEkspertize();
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            var forma = new FormaUpravljajEkspertizama(analiticar.JMBG);
            forma.ShowDialog();
            UcitajEkspertize();
        }

        private async void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (gridEkspertize.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koju ekspertizu menjamo?", "Info");
                return;
            }

            var selektovana = gridEkspertize.CurrentRow.DataBoundItem as DTOEkspertize;
            var forma = new FormaUpravljajEkspertizama(selektovana);
            forma.ShowDialog();
            UcitajEkspertize();
        }

        private async void dugmeObrisi_Click(object sender, EventArgs e)
        {
            if (gridEkspertize.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koju ekspertizu brišemo?", "Info");
                return;
            }

            var selektovana = gridEkspertize.CurrentRow.DataBoundItem as DTOEkspertize;
            var potvrda = MessageBox.Show("Brisanje ove ekspertize?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (potvrda == DialogResult.OK)
            {
                await DTOManager.ObrisiEkspertizu(selektovana.Id);
                MessageBox.Show("Ekspertiza uspešno obrisana.", "Info");
                UcitajEkspertize();
            }
        }
    }
}
