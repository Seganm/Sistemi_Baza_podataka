using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajSpecijalnomInterventnom : Form
    {
        DTOVratiSpecijalnuInterventnuJedinicu specijalna;

        public FormaUpravljajSpecijalnomInterventnom()
        {
            InitializeComponent();
            PopuniPodacima();
        }

        public FormaUpravljajSpecijalnomInterventnom(DTOVratiSpecijalnuInterventnuJedinicu sp)
        {
            InitializeComponent();
            specijalna = sp;
            PopuniPodacima();
        }

        public async void PopuniPodacima()
        {
            var operativni = await DTOManager.RadniciVratii();
            cmbKomandir.DataSource = operativni;
            cmbKomandir.DisplayMember = "PunoIme";
            cmbKomandir.ValueMember = "JMBG";

            if (specijalna != null)
            {
                txtNaziv.Text = specijalna.Naziv;
                txtBaza.Text = specijalna.Baza;
                txtTip.Text = specijalna.SpecijalnaTip;

                if (specijalna.JMBGKomandira != null)
                {
                    cmbKomandir.SelectedValue = specijalna.JMBGKomandira;
                    cmbKomandir.Enabled = false;
                }
                else
                {
                    cmbKomandir.SelectedIndex = -1;
                    cmbKomandir.Enabled = true;
                }
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text) || string.IsNullOrEmpty(txtBaza.Text) ||
                string.IsNullOrEmpty(txtTip.Text) || cmbKomandir.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo popunite sva obavezna polja pre čuvanja podataka.",
                    "Nedovoljno podataka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DTOOsnovnaSpecijalnaInterventnaJedinica spec = new DTOOsnovnaSpecijalnaInterventnaJedinica
            {
                Naziv = txtNaziv.Text,
                Baza = txtBaza.Text,
                JMBGKomandira = cmbKomandir.SelectedValue?.ToString(),
                SpecijalnaTip = txtTip.Text
            };

            if (specijalna == null)
                await DTOManager.SpecijalnaJedinicaDodajj(spec);
            else
                await DTOManager.SpecijalnaJedinicaIzmenii(spec, specijalna.JedinstveniBroj);

            MessageBox.Show("Podaci o specijalnoj jedinici su uspešno sačuvani.",
                "Uspešno čuvanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            txtNaziv.Clear();
            txtBaza.Clear();
            txtTip.Clear();
            cmbKomandir.SelectedIndex = -1;
            MessageBox.Show("Sva polja su resetovana.",
                "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show(
                "Da li ste sigurni da želite da zatvorite ovu formu?",
                "Potvrda zatvaranja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rez == DialogResult.Yes)
                Close();
        }

        private void FormaUpravljajSpecijalnomInterventnom_Load(object sender, EventArgs e) { }
    }
}