using System;
using System.Drawing;
using System.Windows.Forms;
using VanredneSituacije.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajPredstavnikomSluzbe : Form
    {
        DTOPredstavnikSluzbe predstavnik;

        public FormaUpravljajPredstavnikomSluzbe()
        {
            InitializeComponent();
        }

        public FormaUpravljajPredstavnikomSluzbe(DTOPredstavnikSluzbe p)
        {
            predstavnik = p;
            InitializeComponent();
            PopuniPodacima();
            txtJmbg.Enabled = false;
            txtJmbg.BackColor = Color.LightGray;
        }

        public void PopuniPodacima()
        {
            txtJmbg.Text = predstavnik.JMBG;
            txtIme.Text = predstavnik.Ime;
            txtPrezime.Text = predstavnik.Prezime;
            txtPozicija.Text = predstavnik.Pozicija;
            txtKontakt.Text = predstavnik.Telefon;
            txtEmail.Text = predstavnik.Email;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                DTOPredstavnikSluzbe pred = new DTOPredstavnikSluzbe();
                pred.JMBG = txtJmbg.Text;
                pred.Ime = txtIme.Text;
                pred.Prezime = txtPrezime.Text;
                pred.Pozicija = txtPozicija.Text;
                pred.Telefon = txtKontakt.Text;
                pred.Email = txtEmail.Text;

                if (txtJmbg.Text.Length != 13 || int.TryParse(txtJmbg.Text, out _))
                {
                    MessageBox.Show("Neispravan JMBG!");
                    return;
                }

                if (!int.TryParse(txtKontakt.Text, out _))
                {
                    MessageBox.Show("Neispravan telefon! Koristite samo brojeve!");
                    return;
                }

                if (string.IsNullOrEmpty(txtJmbg.Text) || string.IsNullOrEmpty(txtIme.Text) || string.IsNullOrEmpty(txtPrezime.Text) ||
                    string.IsNullOrEmpty(txtPozicija.Text) || string.IsNullOrEmpty(txtKontakt.Text) || string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Popunite sva polja.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (predstavnik == null)
                {
                    await DTOManager.PredstavnikSluzbeDodajj(pred);
                }
                else
                {
                    await DTOManager.PredstavnikSluzbeIzmenii(pred, predstavnik.JMBG);
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIme.Clear();
            txtPrezime.Clear();
            txtPozicija.Clear();
            txtKontakt.Clear();
            txtEmail.Clear();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Da li  želiš da zatvoriš formu?",
               "",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormaUpravljajPredstavnikomSluzbe_Load(object sender, EventArgs e)
        {
        }
    }
}