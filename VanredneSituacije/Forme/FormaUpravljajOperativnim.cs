using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;
using VanredneSituacije.Entitet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajOperativnim : Form
    {
        public DTOOperativniRadnik? OperativniRadnik;
        public FormaUpravljajOperativnim()
        {
            InitializeComponent();
            PopuniCombo();
            cmbJedinica.SelectedIndex = -1;
        }

        public FormaUpravljajOperativnim(DTOOperativniRadnik radnik)
        {
            OperativniRadnik = radnik;
            InitializeComponent();
            PopuniPodacima();
            txtJmbg.Enabled = false;
            txtJmbg.BackColor = Color.LightGray;
        }

        public async void PopuniCombo()
        {
            cmbSpremnost.DataSource = Enum.GetValues(typeof(Spremnost));
            cmbSpremnost.SelectedIndex = -1;
        }

        public async void PopuniPodacima()
        {
            PopuniCombo();
            txtJmbg.Text = OperativniRadnik.JMBG;
            txtIme.Text = OperativniRadnik.Ime;
            txtPrezime.Text = OperativniRadnik.Prezime;
            dtpRodjenje.Value = OperativniRadnik.Datum_Rodjenja;
            if (OperativniRadnik.Pol == "M")
            {
                chkMusko.Checked = true;
                chkZensko.Checked = false;
            }
            else if (OperativniRadnik.Pol == "Z")
            {
                chkMusko.Checked = false;
                chkZensko.Checked = true;
            }

            txtTelefon.Text = OperativniRadnik.Kontakt_Telefon;
            txtEmail.Text = OperativniRadnik.Email;
            txtAdresa.Text = OperativniRadnik.AdresaStanovanja;
            dtpZaposlenje.Value = OperativniRadnik.Datum_Zaposlenja;
            numSati.Value = OperativniRadnik.Broj_Sati;
            cmbSpremnost.SelectedItem = OperativniRadnik.Fizicka_Spremnost;

            if (OperativniRadnik.InterventnaJedinica.Jedinstveni_Broj == null)
                cmbJedinica.SelectedIndex = -1;
            else
                cmbJedinica.SelectedValue = OperativniRadnik.InterventnaJedinica.Jedinstveni_Broj;
        }

        private async void FormaUpravljajOperativnim_Load(object sender, EventArgs e)
        {
            var jedinice = await DTOManager.VratiSveJedinice();
            cmbJedinica.DataSource = jedinice;
            cmbJedinica.DisplayMember = "Naziv";
            cmbJedinica.ValueMember = "Jedinstveni_Broj";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIme.Clear();
            txtPrezime.Clear();
            dtpRodjenje.Value = DateTime.Now;
            chkMusko.Checked = false;
            chkZensko.Checked = false;
            txtTelefon.Clear();
            txtEmail.Clear();
            txtAdresa.Clear();
            dtpZaposlenje.Value = DateTime.Now;
            numSati.Value = 0;
            cmbSpremnost.SelectedIndex = -1;
            cmbJedinica.SelectedIndex = -1;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Da li si siguran da želiš da zatvoriš formu?",
                "Potvrda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Close();
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                DTODodajOperativnogRadnika operativni = new DTODodajOperativnogRadnika
                {
                    JMBG = txtJmbg.Text,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Datum_Rodjenja = dtpRodjenje.Value,
                    Kontakt_Telefon = txtTelefon.Text,
                    Email = txtEmail.Text,
                    AdresaStanovanja = txtAdresa.Text,
                    Datum_Zaposlenja = dtpZaposlenje.Value,
                    Broj_Sati = (int)numSati.Value,
                    Fizicka_Spremnost = (Spremnost)cmbSpremnost.SelectedValue
                };

                if (txtJmbg.Text.Length != 13 || int.TryParse(txtJmbg.Text, out _))
                {
                    MessageBox.Show("Neispravan JMBG!");
                    return;
                }

                if (!int.TryParse(txtTelefon.Text, out _))
                {
                    MessageBox.Show("Neispravan telefon");
                    return;
                }

                if (chkMusko.Checked)
                    operativni.Pol = "M";
                else if (chkZensko.Checked)
                    operativni.Pol = "Z";
                else
                {
                    MessageBox.Show("Morate izabrati pol!");
                    return;
                }

                if (cmbJedinica.SelectedValue != null)
                    operativni.InterventnaJedinica = (int)cmbJedinica.SelectedValue;
                else
                    operativni.InterventnaJedinica = null;

                if (string.IsNullOrEmpty(txtJmbg.Text) ||
                    string.IsNullOrEmpty(txtIme.Text) ||
                    string.IsNullOrEmpty(txtPrezime.Text) ||
                    string.IsNullOrEmpty(txtTelefon.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtAdresa.Text) ||
                    decimal.IsNegative(numSati.Value))
                {
                    MessageBox.Show("Popuni sva polja.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (OperativniRadnik == null)
                    await DTOManager.DodajOperativnogRadnik(operativni);
                else
                    await DTOManager.IzmeniOperativnog(operativni, OperativniRadnik.JMBG);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}