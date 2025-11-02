using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaOperativciJedinice : Form
    {
        public readonly int jedId;

        public FormaOperativciJedinice(int id)
        {
            InitializeComponent();
            this.jedId = id;
            UcitajRadnike();
        }

        public async void UcitajRadnike()
        {
            try
            {
                dataGridRadnici.DataSource = await DTOManager.JedinicaRadniciVratii(jedId);
                dataGridRadnici.Refresh();
                dataGridRadnici.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Podaci nisu lepo ucitani: " + ex.Message);
            }
        }

        private async void dugmeBrisi_Click_1(object sender, EventArgs e)
        {
            if (dataGridRadnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Kog operativnog brisemo?", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var operativni = dataGridRadnici.CurrentRow.DataBoundItem as DTOZaposleni;
            if (operativni == null) return;

            DialogResult potvrda = MessageBox.Show(
                "Brisemo ovog operativnog?",
                "info",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (potvrda == DialogResult.OK)
            {
                await DTOManager.OperativniObrisii(operativni.JMBG);
                MessageBox.Show("Obrisan operativni!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajRadnike();
            }
        }

        private void dataGridRadnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormaOperativciJedinice_Load(object sender, EventArgs e)
        {
          
        }
    }
}
