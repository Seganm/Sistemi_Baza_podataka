using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajKoordinatorom : Form
    {
        public DTOKoordinator? kord;

        public FormaUpravljajKoordinatorom()
        {
            InitializeComponent();
        }

        public FormaUpravljajKoordinatorom(DTOKoordinator koordView)
        {
            InitializeComponent();
            this.kord = koordView;
            PopuniPodacima();
            textJmbg.Enabled = false;
            textJmbg.BackColor = Color.LightGray;
            kord = koordView;
        }

        public async void PopuniPodacima()
        {
            textJmbg.Text = kord.JMBG;
            textIme.Text = kord.Ime;
            textPrezime.Text = kord.Prezime;
            dateRodjenje.Value = kord.DatumRodj;
            if (kord.Pol == "M")
            {
                checkMusko.Checked = true;
                checkZensko.Checked = false;
            }
            else if (kord.Pol == "Z")
            {
                checkMusko.Checked = false;
                checkZensko.Checked = true;
            }

            textKontakt.Text = kord.BrojTelefona;
            textEmail.Text = kord.Email;
            textAdresa.Text = kord.AdresaStan;
            try
            {
                dateZaposlenje.Value = kord.DatumZap;
            }
            catch (Exception ex)
            {
                dateZaposlenje.Value = DateTime.Now;
            }
        }

        private void buttonRst_Click(object sender, EventArgs e)
        {
            textIme.Clear();
            textPrezime.Clear();
            dateZaposlenje.Value = DateTime.Now;
            checkMusko.Checked = false;
            checkZensko.Checked = false;
            textKontakt.Clear();
            textEmail.Clear();
            textAdresa.Clear();
            dateZaposlenje.Value = DateTime.Now;
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Da li si siguran da želiš da zatvoriš formu?",
           "Potvrda",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Close();
            }
            else
            {

            }
        }

        private async void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                DTOKoordinator Koordinator = new DTOKoordinator();
                Koordinator.JMBG = textJmbg.Text;
                Koordinator.Ime = textIme.Text;
                Koordinator.Prezime = textPrezime.Text;
                Koordinator.DatumRodj = dateRodjenje.Value;
                Koordinator.BrojTelefona = textKontakt.Text;
                Koordinator.Email = textEmail.Text;
                Koordinator.AdresaStan = textAdresa.Text;

                if (textJmbg.Text.Length != 13 || int.TryParse(textJmbg.Text, out _))
                {
                    MessageBox.Show("Neispravan JMBG!");
                }
                if (!int.TryParse(textKontakt.Text, out _))
                {
                    MessageBox.Show("Neispravan telefon! Koristite samo brojeve!");
                    return;
                }
                if (checkMusko.Checked == true)
                {
                    Koordinator.Pol = "M";
                }
                else if (checkZensko.Checked == true)
                {
                    Koordinator.Pol = "Z";
                }
                else
                {
                    MessageBox.Show("Morate izabrati pol!");
                    return;
                }
                if (string.IsNullOrEmpty(textJmbg.Text) || string.IsNullOrEmpty(textIme.Text) || string.IsNullOrEmpty(textPrezime.Text) || string.IsNullOrEmpty(textKontakt.Text) || string.IsNullOrEmpty(textEmail.Text) ||
                    string.IsNullOrEmpty(textAdresa.Text))
                {
                    MessageBox.Show("Sva polja moraju biti popunjena.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (kord == null)
                {
                    await DTOManager.KoordinatorDodajj(Koordinator);
                }
                else
                {
                    await DTOManager.KoordinatorIzmenii(Koordinator, kord.JMBG);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
        }

        private void FormaUpravljajKoordinatorom_Load(object sender, EventArgs e)
        {

        }
    }
}
