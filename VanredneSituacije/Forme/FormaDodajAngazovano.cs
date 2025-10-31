using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaDodajAngazovano : Form
    {
        DTOVratiAngazovano angazovanost;

        public FormaDodajAngazovano()
        {
            InitializeComponent();
        }

        public FormaDodajAngazovano(DTOVratiAngazovano aktuelno)
        {
            InitializeComponent();
            angazovanost = aktuelno;
            PopuniPostojecePodatke();
        }

        private async void FormaDodajAngazovano_Load(object sender, EventArgs e)
        {
            listaIntervencija.DataSource = await DTOManager.VratiIntervencije();
            listaIntervencija.DisplayMember = "Id";
            listaIntervencija.ValueMember = "Id";

            listaVozila.DataSource = await DTOManager.VratiSvaVozila();
            listaVozila.DisplayMember = "Registarska_Oznaka";
            listaVozila.ValueMember = "Registarska_Oznaka";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void PopuniPostojecePodatke()
        {
            listaIntervencija.SelectedValue = angazovanost.IntervencijaID;
            listaVozila.SelectedValue = angazovanost.VoziloReg;

            datumOdPicker.Value = angazovanost.DatumPoc;

            if (angazovanost.DatumKraj == null)
                datumDoPicker.Value = DateTime.Now;
            else
                datumDoPicker.Value = (DateTime)angazovanost.DatumKraj;

            listaIntervencija.Enabled = false;
            listaVozila.Enabled = false;
            listaIntervencija.BackColor = Color.LightGray;
            listaVozila.BackColor = Color.LightGray;
        }

        private async void dugmeSacuvaj_Click(object sender, EventArgs e)
        {
            if (listaIntervencija.SelectedIndex == -1 || listaVozila.SelectedIndex == -1)
            {
                MessageBox.Show("Popuni sve", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DTODodajAngazovano info = new DTODodajAngazovano
            {
                IntervencijaID = (int)listaIntervencija.SelectedValue,
                VoziloReg = (string)listaVozila.SelectedValue,
                DatumPoc = datumOdPicker.Value,
                DatumKraj = datumDoPicker.Value
            };

            if (angazovanost == null)
            {
                await DTOManager.DodajUcestvovanje(info);
            }
            else
            {
                await DTOManager.IzmeniUcestvovanje(info, angazovanost.Id);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void dugmePonisti_Click(object sender, EventArgs e)
        {
            datumOdPicker.Value = DateTime.Now;
            datumDoPicker.Value = DateTime.Now;
        }

        private void dugmeZatvori_Click(object sender, EventArgs e)
        {
            DialogResult ok = MessageBox.Show(
                "Zatvaram formu?",
                "info",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ok == DialogResult.Yes)
                Close();
        }
    }
}
