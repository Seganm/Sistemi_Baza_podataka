using System;
using System.Drawing;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajAnaliticarom : Form
    {
        private DTOAnaliticar? _analiticar;

        public FormaUpravljajAnaliticarom()
        {
            InitializeComponent();
        }

        public FormaUpravljajAnaliticarom(DTOAnaliticar analiticar)
        {
            InitializeComponent();
            _analiticar = analiticar;
            PopuniPodacima();
            textJmbg.Enabled = false;
            textJmbg.BackColor = Color.LightGray;
        }

        private void FormaUpravljajAnaliticarom_Load(object sender, EventArgs e)
        {
            Text = _analiticar == null ? "Dodaj analitičara" : "Izmeni analitičara";
        }

        public void PopuniPodacima()
        {
            textJmbg.Text = _analiticar!.JMBG;
            textIme.Text = _analiticar.Ime;
            textPrezime.Text = _analiticar.Prezime;
            dateRodjenja.Value = _analiticar.Datum_Rodjenja;

            checkMusko.Checked = _analiticar.Pol == "M";
            checkZensko.Checked = _analiticar.Pol == "Z";

            textKontakt.Text = _analiticar.Kontakt_Telefon;
            textEmail.Text = _analiticar.Email;
            textAdresa.Text = _analiticar.AdresaStanovanja;
            dateZaposlenje.Value = _analiticar.Datum_Zaposlenja;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textIme.Clear();
            textPrezime.Clear();
            textKontakt.Clear();
            textEmail.Clear();
            textAdresa.Clear();
            checkMusko.Checked = false;
            checkZensko.Checked = false;
            dateRodjenja.Value = DateTime.Now;
            dateZaposlenje.Value = DateTime.Now;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Zatvaram formu bez čuvanja izmena?",
                "Info",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
                Close();
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textJmbg.Text) ||
                    string.IsNullOrWhiteSpace(textIme.Text) ||
                    string.IsNullOrWhiteSpace(textPrezime.Text) ||
                    string.IsNullOrWhiteSpace(textKontakt.Text) ||
                    string.IsNullOrWhiteSpace(textEmail.Text) ||
                    string.IsNullOrWhiteSpace(textAdresa.Text))
                {
                    MessageBox.Show("Popuni sva polja.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (textJmbg.Text.Length != 13 || !long.TryParse(textJmbg.Text, out _))
                {
                    MessageBox.Show("JMBG mora imati tačno 13 cifara.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!long.TryParse(textKontakt.Text, out _))
                {
                    MessageBox.Show("Telefon mora sadržati samo brojeve.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string pol = checkMusko.Checked ? "M" :
                             checkZensko.Checked ? "Z" : string.Empty;

                if (string.IsNullOrEmpty(pol))
                {
                    MessageBox.Show("Izaberi pol.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DTOAnaliticar novi = new DTOAnaliticar
                {
                    JMBG = textJmbg.Text,
                    Ime = textIme.Text,
                    Prezime = textPrezime.Text,
                    Datum_Rodjenja = dateRodjenja.Value,
                    Pol = pol,
                    Kontakt_Telefon = textKontakt.Text,
                    Email = textEmail.Text,
                    AdresaStanovanja = textAdresa.Text,
                    Datum_Zaposlenja = dateZaposlenje.Value
                };

                if (_analiticar == null)
                    await DTOManager.DodajAnalitcar(novi);
                else
                    await DTOManager.IzmeniAnaliticar(novi, _analiticar.JMBG);

                MessageBox.Show("Podaci su sačuvani.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čuvanju podataka:\n{ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
