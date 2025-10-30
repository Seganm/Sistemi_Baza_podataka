using System;
using System.Drawing;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajPrijavama : Form
    {
        public DTOPrijava prijava;

        public FormaUpravljajPrijavama()
        {
            InitializeComponent();
            dtDatumVreme.Format = DateTimePickerFormat.Custom;
        }

        public FormaUpravljajPrijavama(DTOPrijava prijava)
        {
            InitializeComponent();
            this.prijava = prijava;
            PopuniPodacima();
        }

        public async void PopuniPodacima()
        {
            dtDatumVreme.Value = prijava.Datum_I_Vreme;
            tbTip.Text = prijava.Tip;
            tbIme.Text = prijava.Ime_Prijavioca;
            tbKontakt.Text = prijava.Kontakt;
            tbLokacija.Text = prijava.Lokacija;
            tbOpis.Text = prijava.Opis;
            tbDispecer.Text = prijava.JMBG_Dispecer;
            numPrioritet.Value = (int)prijava.Prioritet;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            DTODodajPrijavu pr = new DTODodajPrijavu
            {
                Datum_I_Vreme = dtDatumVreme.Value,
                Tip = tbTip.Text,
                Ime_Prijavioca = tbIme.Text,
                Kontakt = tbKontakt.Text,
                Lokacija = tbLokacija.Text,
                Opis = tbOpis.Text,
                Prioritet = (int)numPrioritet.Value,
                JMBG_Dispecer = tbDispecer.Text
            };

            if (!dtDatumVreme.Checked || string.IsNullOrEmpty(tbTip.Text) || string.IsNullOrEmpty(tbIme.Text) ||
                string.IsNullOrEmpty(tbKontakt.Text) || string.IsNullOrEmpty(tbLokacija.Text) ||
                string.IsNullOrEmpty(tbOpis.Text) || string.IsNullOrEmpty(tbDispecer.Text) || numPrioritet.Value <= 0)
            {
                MessageBox.Show("Popunite sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (prijava == null)
                await DTOManager.DodajPrijavu(pr);
            else
                await DTOManager.IzmeniPrijavu(pr, prijava.Id);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtDatumVreme.Value = DateTime.Now;
            tbTip.Clear();
            tbIme.Clear();
            tbKontakt.Clear();
            tbLokacija.Clear();
            tbOpis.Clear();
            numPrioritet.Value = 0;
            tbDispecer.Clear();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Da li želiš da zatvoriš formu?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Close();
        }

        private void FormaUpravljajPrijavama_Load(object sender, EventArgs e) { }
    }
}