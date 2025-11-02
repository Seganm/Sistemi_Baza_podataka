using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajSertifikatima : Form
    {
        private DTODodajIdSertifikata _idSertifikata;
        private DTOSertifikatVratii _postojeciSertifikat;
        public readonly string _jmbgRadnika;

        public FormaUpravljajSertifikatima()
        {
            InitializeComponent();
            PodesiStil();
        }

        public FormaUpravljajSertifikatima(string jmbg)
        {
            InitializeComponent();
            PodesiStil();

            _jmbgRadnika = jmbg;
            txtJmbgRadnika.Text = jmbg;
            txtJmbgRadnika.Enabled = false;
            txtJmbgRadnika.BackColor = Color.LightGray;
        }

        public FormaUpravljajSertifikatima(DTOSertifikatVratii sertifikat)
        {
            InitializeComponent();
            PodesiStil();

            _postojeciSertifikat = sertifikat;
            PopuniPolja();
        }

        private void PodesiStil()
        {
            BackColor = Color.WhiteSmoke;
            Font = new Font("Segoe UI", 9.75f, FontStyle.Regular);

            btnSacuvajSertifikat.BackColor = Color.FromArgb(76, 175, 80);
            btnSacuvajSertifikat.ForeColor = Color.White;
            btnSacuvajSertifikat.FlatStyle = FlatStyle.Flat;

            btnPonistiUnos.BackColor = Color.FromArgb(255, 224, 130);
            btnPonistiUnos.ForeColor = Color.Black;
            btnPonistiUnos.FlatStyle = FlatStyle.Flat;

            btnZatvoriFormu.BackColor = Color.FromArgb(239, 83, 80);
            btnZatvoriFormu.ForeColor = Color.White;
            btnZatvoriFormu.FlatStyle = FlatStyle.Flat;

            foreach (var t in Controls.OfType<TextBox>())
            {
                t.BorderStyle = BorderStyle.FixedSingle;
                t.BackColor = Color.White;
            }

            foreach (var l in Controls.OfType<Label>())
                l.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
        }

        private void PopuniPolja()
        {
            if (_postojeciSertifikat != null)
            {
                txtJmbgRadnika.Text = _postojeciSertifikat.JMBGOperativnogRadnika;
                txtJmbgRadnika.Enabled = false;
                txtJmbgRadnika.BackColor = Color.LightGray;

                txtNazivSertifikata.Text = _postojeciSertifikat.Naziv;
                txtNazivSertifikata.Enabled = false;
                txtNazivSertifikata.BackColor = Color.LightGray;

                txtInstitucijaSertifikata.Text = _postojeciSertifikat.Institucija;
                txtInstitucijaSertifikata.Enabled = false;
                txtInstitucijaSertifikata.BackColor = Color.LightGray;

                dtpDatIzdavanje.Value = _postojeciSertifikat.DatIzdavanje;
                dtpDatVazenje.Value = _postojeciSertifikat.DatVazenje ?? DateTime.Now;
            }
        }

        private async void btnSacuvajSertifikat_Click(object sender, EventArgs e)
        {
            DTOSertifikat sertifikat = new DTOSertifikat
            {
                Id = new DTODodajIdSertifikata
                {
                    JMBGRadnika = string.IsNullOrWhiteSpace(_jmbgRadnika) ? txtJmbgRadnika.Text.Trim() : _jmbgRadnika,
                    Naziv = txtNazivSertifikata.Text.Trim(),
                    Institucija = txtInstitucijaSertifikata.Text.Trim()
                },
                DatIzdavanje = dtpDatIzdavanje.Value,
                DatVazenje = dtpDatVazenje.Checked ? dtpDatVazenje.Value : (DateTime?)null
            };

            if (string.IsNullOrEmpty(sertifikat.Id.JMBGRadnika) ||
                string.IsNullOrEmpty(sertifikat.Id.Naziv) ||
                string.IsNullOrEmpty(sertifikat.Id.Institucija))
            {
                MessageBox.Show("Popunite sva obavezna polja.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_postojeciSertifikat == null)
            {
                await DTOManager.SertifikatDodajj(sertifikat);
                MessageBox.Show("Sertifikat je uspešno dodat!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                await DTOManager.SertifikatIzmenii(sertifikat);
                MessageBox.Show("Sertifikat je izmenjen", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnPonistiUnos_Click(object sender, EventArgs e)
        {
            txtNazivSertifikata.Clear();
            txtInstitucijaSertifikata.Clear();
            dtpDatIzdavanje.Value = DateTime.Now;
            dtpDatVazenje.Value = DateTime.Now;
        }

        private void btnZatvoriFormu_Click(object sender, EventArgs e)
        {
            var potvrda = MessageBox.Show("Da li želite da zatvorite prozor?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (potvrda == DialogResult.Yes)
                Close();
        }

        private void FormaUpravljajSertifikatima_Load(object sender, EventArgs e) { }
    }
}
