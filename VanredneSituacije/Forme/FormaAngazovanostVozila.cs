using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaAngazovanostVozila : Form
    {
        private string oznaka;

        public FormaAngazovanostVozila(string registracija)
        {
            InitializeComponent();
            this.oznaka = registracija;
            MessageBox.Show("Registracija: " + registracija);
            PopuniPodacima();
        }
        
        private async void FormaAngazovanostVozila_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await DTOManager.IntervencijeSaVozilomVratii(oznaka);
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        public async void PopuniPodacima()
        {
            dataGridView1.DataSource = await DTOManager.IntervencijeSaVozilomVratii(oznaka);
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopuniPodacima();
        }
    }
}
