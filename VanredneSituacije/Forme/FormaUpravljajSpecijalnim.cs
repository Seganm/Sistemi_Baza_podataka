using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajSpecijalnim : Form
    {
        private readonly string _regOznaka;

        public FormaUpravljajSpecijalnim()
        {
            InitializeComponent();
            UcitajPodatke();
        }

        public FormaUpravljajSpecijalnim(string regOznaka)
        {
            InitializeComponent();
            _regOznaka = regOznaka;
            UcitajPodatke();
            txtRegistarskaOznaka.Enabled = false;
            txtRegistarskaOznaka.BackColor = Color.Gainsboro;
        }

        private async void UcitajPodatke()
        {
            cmbStatusVozila.Items.Clear();
            cmbNamenaVozila.Items.Clear();

            cmbStatusVozila.DataSource = Enum.GetValues(typeof(StatusVozila));
            cmbNamenaVozila.DataSource = Enum.GetValues(typeof(Namena));

            if (_regOznaka != null)
            {
                var vozilo = await DTOManager.SpecijalnoVratii(_regOznaka);
                txtRegistarskaOznaka.Text = vozilo.Registracijaa;
                txtProizvodjac.Text = vozilo.Proizvodjac;
                txtLokacija.Text = vozilo.Lokacija;
                cmbStatusVozila.SelectedItem = vozilo.Status;
                cmbNamenaVozila.SelectedItem = vozilo.Namena;
            }
        }

        private async void btnSacuvajPodatke_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegistarskaOznaka.Text) ||
                string.IsNullOrWhiteSpace(txtProizvodjac.Text) ||
                string.IsNullOrWhiteSpace(txtLokacija.Text) ||
                cmbStatusVozila.SelectedIndex == -1 || cmbNamenaVozila.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo popunite sva polja .", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DTODodajSpecijalno vozilo = new DTODodajSpecijalno
            {
                Registracijaa = txtRegistarskaOznaka.Text,
                Proizvodjac = txtProizvodjac.Text,
                Lokacija = txtLokacija.Text,
                Status = (StatusVozila)cmbStatusVozila.SelectedItem,
                Namena = (Namena)cmbNamenaVozila.SelectedItem
            };

            if (_regOznaka == null)
                await DTOManager.SpecijalnoDodajj(vozilo);
            else
                await DTOManager.SpecijalnaIzmenii(vozilo, _regOznaka);

            MessageBox.Show("Podaci su  sačuvani.", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnResetujPolja_Click(object sender, EventArgs e)
        {
            txtProizvodjac.Clear();
            txtLokacija.Clear();
            cmbStatusVozila.SelectedIndex = -1;
            cmbNamenaVozila.SelectedIndex = -1;
        }

        private void btnZatvoriFormu_Click(object sender, EventArgs e)
        {
            var rezultat = MessageBox.Show("Da li  želite da izađete?", "Zatvaranje forme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rezultat == DialogResult.Yes)
                Close();
        }
    }
}